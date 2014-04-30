﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grabacr07.KanColleWrapper.Models;
using Grabacr07.KanColleViewer.Properties;
using Livet;

namespace Grabacr07.KanColleViewer.ViewModels.Contents
{
	public class SlotItemViewModel : ViewModel
	{
		public SlotItemInfo SlotItem { get; set; }

		public SlotItemViewModel(SlotItemInfo item)
		{
			this.SlotItem = item;
		}

		public string DetailedToolTip
		{
			get
			{
				string _Detail = this.Detail;
				return this.SlotItem.Name + (_Detail != "" ? "\n" + _Detail : "");
			}
		}

		public string Detail
		{
			get
			{
				string AddDetail = "";

				if (this.SlotItem.Firepower> 0) AddDetail += " +" + this.SlotItem.Firepower + " " + Resources.Stats_Firepower;
				if (this.SlotItem.AA > 0) AddDetail += (AddDetail != "" ? "\n" : "") + " +" + this.SlotItem.AA + " " + Resources.Stats_AntiAir;
				if (this.SlotItem.Torpedo > 0) AddDetail += (AddDetail != "" ? "\n" : "") + " +" + this.SlotItem.Torpedo + " " + Resources.Stats_Torpedo;
				if (this.SlotItem.AntiSub > 0) AddDetail += (AddDetail != "" ? "\n" : "") + " +" + this.SlotItem.AntiSub + " " + Resources.Stats_AntiSub;
				if (this.SlotItem.SightRange > 0) AddDetail += (AddDetail != "" ? "\n" : "") + " +" + this.SlotItem.SightRange + " " + Resources.Stats_SightRange;
				if (this.SlotItem.Speed > 0) AddDetail += (AddDetail != "" ? "\n" : "") + " +" + this.SlotItem.Speed + " " + Resources.Stats_Speed;
				if (this.SlotItem.Armor > 0) AddDetail += (AddDetail != "" ? "\n" : "") + " +" + this.SlotItem.Armor + " " + Resources.Stats_Armor;
				if (this.SlotItem.Health > 0) AddDetail += (AddDetail != "" ? "\n" : "") + " +" + this.SlotItem.Health + " " + Resources.Stats_Health;
				if (this.SlotItem.Luck > 0) AddDetail += (AddDetail != "" ? "\n" : "") + " +" + this.SlotItem.Luck + " " + Resources.Stats_Luck;
				if (this.SlotItem.Evasion > 0) AddDetail += (AddDetail != "" ? "\n" : "") + " +" + this.SlotItem.Evasion + " " + Resources.Stats_Evasion;
				if (this.SlotItem.Accuracy > 0) AddDetail += (AddDetail != "" ? "\n" : "") + " +" + this.SlotItem.Accuracy + " " + Resources.Stats_Accuracy;
				if (this.SlotItem.DiveBomb > 0) AddDetail += (AddDetail != "" ? "\n" : "") + " +" + this.SlotItem.DiveBomb + " " + Resources.Stats_DiveBomb;
				if (this.SlotItem.AttackRange > 0) AddDetail += (AddDetail != "" ? "\n" : "") + " " + Resources.Stats_AttackRange + " (" + this.SlotItem.AttackRange + ")";
				//if (this.SlotItem.RawData.api_raik > 0) AddDetail += (AddDetail != "" ? "\n" : "") + " +" + this.SlotItem.RawData.api_raik + " api_raik";
				//if (this.SlotItem.RawData.api_raim > 0) AddDetail += (AddDetail != "" ? "\n" : "") + " +" + this.SlotItem.RawData.api_raim + " api_raim";
				//if (this.SlotItem.RawData.api_sakb > 0) AddDetail += (AddDetail != "" ? "\n" : "") + " +" + this.SlotItem.RawData.api_sakb + " api_sakb";
				//if (this.SlotItem.RawData.api_atap > 0) AddDetail += (AddDetail != "" ? "\n" : "") + " +" + this.SlotItem.RawData.api_atap + " api_atap";
				//if (this.SlotItem.RawData.api_rare > 0) AddDetail += (AddDetail != "" ? "\n" : "") + " +" + this.SlotItem.RawData.api_rare + " api_rare";
				//if (this.SlotItem.RawData.api_bakk > 0) AddDetail += (AddDetail != "" ? "\n" : "") + " +" + this.SlotItem.RawData.api_bakk + " api_bakk";

				return AddDetail;
			}
		}
	}
}
