﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grabacr07.KanColleWrapper.Internal;

namespace Grabacr07.KanColleWrapper.Models
{
	/// <summary>
	/// 索敵値計算を提供します。
	/// </summary>
	public interface ICalcViewRange
	{
		string Id { get; }

		string Name { get; }

		string Description { get; }

		double Calc(Ship[] ships);
	}


	public abstract class ViewRangeCalcLogic : ICalcViewRange
	{
		private static readonly Dictionary<string, ICalcViewRange> logics = new Dictionary<string, ICalcViewRange>();

		public static IEnumerable<ICalcViewRange> Logics
		{
			get { return logics.Values; }
		}

		public static ICalcViewRange Get(string key)
		{
			ICalcViewRange logic;
			return logics.TryGetValue(key, out logic) ? logic : new ViewRangeType1();
		}

		static ViewRangeCalcLogic()
		{
			// ひどぅい設計を見た
			// ReSharper disable ObjectCreationAsStatement
			new ViewRangeType1();
			new ViewRangeType2();
			new ViewRangeType3();
			// ReSharper restore ObjectCreationAsStatement
		}

		public abstract string Id { get; }
		public abstract string Name { get; }
		public abstract string Description { get; }
		public abstract double Calc(Ship[] ships);

		protected ViewRangeCalcLogic()
		{
			// ReSharper disable once DoNotCallOverridableMethodsInConstructor
			var key = this.Id;
			if (key != null && !logics.ContainsKey(key)) logics.Add(key, this);
		}
	}


	public class ViewRangeType1 : ViewRangeCalcLogic
	{
		public override sealed string Id
		{
			get { return "KanColleViewer.Type1"; }
		}

		public override string Name
		{
			get { return "简单"; }
		}

		public override string Description
		{
			get { return "简单相加船和装备的索敌值"; }
		}

		public override double Calc(Ship[] ships)
		{
			if (ships == null || ships.Length == 0) return 0;

			return ships.Sum(x => x.ViewRange);
		}
	}


	public class ViewRangeType2 : ViewRangeCalcLogic
	{
		public override sealed string Id
		{
			get { return "KanColleViewer.Type2"; }
		}

		public override string Name
		{
			get { return "2-5计算方案(旧)"; }
		}

		public override string Description
		{
			get { return @"(侦察机× 2) + (电探) + √(算上装备的总索敌值 - 
侦察机 - 电探)"; }
		}

		public override double Calc(Ship[] ships)
		{
			if (ships == null || ships.Length == 0) return 0;

			// http://wikiwiki.jp/kancolle/?%C6%EE%C0%BE%BD%F4%C5%E7%B3%A4%B0%E8#area5
			// [索敵装備と装備例] によって示されている計算式
			// stype=7 が偵察機 (2 倍する索敵値)、stype=8 が電探

			var spotter = ships.SelectMany(
				x => x.EquippedSlots
					.Where(s => s.Item.Info.RawData.api_type.Get(1) == 7)
					.Where(s => s.Current > 0)
					.Select(s => s.Item.Info.RawData.api_saku)
				).Sum();

			var radar = ships.SelectMany(
				x => x.EquippedSlots
					.Where(s => s.Item.Info.RawData.api_type.Get(1) == 8)
					.Select(s => s.Item.Info.RawData.api_saku)
				).Sum();

			return (spotter * 2) + radar + (int)Math.Sqrt(ships.Sum(x => x.ViewRange) - spotter - radar);
		}
	}


	public class ViewRangeType3 : ViewRangeCalcLogic
	{
		public override sealed string Id
		{
			get { return "KanColleViewer.Type3"; }
		}

		public override string Name
		{
			get { return "2-5计算方案(新)"; }
		}

		public override string Description
		{
			get
			{
				return @"舰爆 x (1.04) + 舰攻 x (1.37) + 
舰侦 x (1.66) + 水侦 x (2.00) + 水爆 x (1.78) + 
小型电探 x (1.00) + 大型电探 x (0.99) + 探照灯 x (0.91) + √(各舰基础索敌) x 
(1.69) + (提督等级四舍五入到5的倍数) x (-0.61)";
			}
		}

		public override double Calc(Ship[] ships)
		{
			if (ships == null || ships.Length == 0) return 0;

			// http://wikiwiki.jp/kancolle/?%C6%EE%C0%BE%BD%F4%C5%E7%B3%A4%B0%E8#search-calc
			// > 2-5式では説明出来ない事象を解決するため膨大な検証報告数より導き出した新式。2014年11月に改良され精度があがった。
			// > 索敵スコア
			// > = 艦上爆撃機 × (1.04) 
			// > + 艦上攻撃機 × (1.37)
			// > + 艦上偵察機 × (1.66)
			// > + 水上偵察機 × (2.00)
			// > + 水上爆撃機 × (1.78)
			// > + 小型電探 × (1.00)
			// > + 大型電探 × (0.99)
			// > + 探照灯 × (0.91)
			// > + √(各艦毎の素索敵) × (1.69)
			// > + (司令部レベルを5の倍数に切り上げ) × (-0.61)

			var itemScore = ships
				.SelectMany(x => x.EquippedSlots)
				.Select(x => x.Item.Info)
				.GroupBy(
					x => x.Type,
					x => x.RawData.api_saku,
					(type, scores) => new { type, score = scores.Sum() })
				.Aggregate(.0, (score, item) => score + GetScore(item.type, item.score));

			var shipScore = ships
				.Select(x => x.ViewRange - x.EquippedSlots.Sum(s => s.Item.Info.RawData.api_saku))
				.Select(x => Math.Sqrt(x))
				.Sum() * 1.69;

			var level = (((KanColleClient.Current.Homeport.Admiral.Level + 4) / 5) * 5);
			var admiralScore = level * -0.61;

			return itemScore + shipScore + admiralScore;
		}

		private static double GetScore(SlotItemType type, int score)
		{
			switch (type)
			{
				case SlotItemType.艦上爆撃機:
					return score * 1.04;
				case SlotItemType.艦上攻撃機:
					return score * 1.37;
				case SlotItemType.艦上偵察機:
					return score * 1.66;

				case SlotItemType.水上偵察機:
					return score * 2.00;
				case SlotItemType.水上爆撃機:
					return score * 1.78;

				case SlotItemType.小型電探:
					return score * 1.00;
				case SlotItemType.大型電探:
					return score * 0.99;

				case SlotItemType.探照灯:
					return score * 0.91;
			}

			return .0;
		}
	}
}
