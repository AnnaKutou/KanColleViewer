﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grabacr07.KanColleWrapper.Models;
using Grabacr07.KanColleViewer.Properties;
using Livet;

namespace Grabacr07.KanColleViewer.ViewModels.Catalogs
{
    public class SlotItemViewModel : ViewModel
    {
        public SlotItemInfo SlotItem { get; set; }
        public int Level { get; set; }


        public SlotItemViewModel()
        {
        }

        public SlotItemViewModel(SlotItemInfo item)
        {
            this.SlotItem = item;
            this.Level = 0;
        }

        public string DetailedToolTip
        {
            get
            {
                string _Detail = this.Detail;
                return this.SlotItem.Name + (this.Level > 0 ? (this.Level < 10 ? " ★+" + this.Level : " ★max") : "") + (_Detail != "" ? "\n" + _Detail : "");
            }
        }

        public string Detail
        {
            get
            {
                List<string> details = new List<string>();

                if (this.SlotItem.Firepower != 0) details.Add(StatFormat(SlotItem.Firepower, Resources.Stats_Firepower));
                if (this.SlotItem.AA != 0) details.Add(StatFormat(SlotItem.AA, Resources.Stats_AntiAir));
                if (this.SlotItem.Torpedo != 0) details.Add(StatFormat(SlotItem.Torpedo, Resources.Stats_Torpedo));
                if (this.SlotItem.AntiSub != 0) details.Add(StatFormat(SlotItem.AntiSub, Resources.Stats_AntiSub));
                if (this.SlotItem.SightRange != 0) details.Add(StatFormat(SlotItem.SightRange, Resources.Stats_SightRange));
                if (this.SlotItem.Speed != 0) details.Add(StatFormat(SlotItem.Speed, Resources.Stats_Speed));
                if (this.SlotItem.Armor != 0) details.Add(StatFormat(SlotItem.Armor, Resources.Stats_Armor));
                if (this.SlotItem.Health != 0) details.Add(StatFormat(SlotItem.Health, Resources.Stats_Health));
                if (this.SlotItem.Luck != 0) details.Add(StatFormat(SlotItem.Luck, Resources.Stats_Luck));
                if (this.SlotItem.Evasion != 0) details.Add(StatFormat(SlotItem.Evasion, Resources.Stats_Evasion));
                if (this.SlotItem.Accuracy != 0) details.Add(StatFormat(SlotItem.Accuracy, Resources.Stats_Accuracy));
                if (this.SlotItem.DiveBomb != 0) details.Add(StatFormat(SlotItem.DiveBomb, Resources.Stats_DiveBomb));
                if (this.SlotItem.AttackRange > 0) details.Add(String.Format(" {1}({0})", this.SlotItem.AttackRange, Resources.Stats_AttackRange));
                //if (this.SlotItem.RawData.api_raik > 0) AddDetail += (AddDetail != "" ? "\n" : "") + " +" + this.SlotItem.RawData.api_raik + " api_raik";
                //if (this.SlotItem.RawData.api_raim > 0) AddDetail += (AddDetail != "" ? "\n" : "") + " +" + this.SlotItem.RawData.api_raim + " api_raim";
                //if (this.SlotItem.RawData.api_sakb > 0) AddDetail += (AddDetail != "" ? "\n" : "") + " +" + this.SlotItem.RawData.api_sakb + " api_sakb";
                //if (this.SlotItem.RawData.api_atap > 0) AddDetail += (AddDetail != "" ? "\n" : "") + " +" + this.SlotItem.RawData.api_atap + " api_atap";
                //if (this.SlotItem.RawData.api_rare > 0) AddDetail += (AddDetail != "" ? "\n" : "") + " +" + this.SlotItem.RawData.api_rare + " api_rare";
                //if (this.SlotItem.RawData.api_bakk > 0) AddDetail += (AddDetail != "" ? "\n" : "") + " +" + this.SlotItem.RawData.api_bakk + " api_bakk";

                return String.Join("\n", details);
            }
        }

        private string StatFormat(int stat, string name)
        {
            return String.Format(" {0:+#;-#} {1}", stat, name);
        }
    }
}
