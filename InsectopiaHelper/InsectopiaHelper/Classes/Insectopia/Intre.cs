using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace InsectopiaHelper
{
    public class Intre
    {
        private string name = "Default Name";
        private string raceID;
        private string id;
        public string ID { get => id; set => id = value; }

        private IntreCharacterInfos characterInfos = new IntreCharacterInfos();
        private IntreStats stats = new IntreStats();
        public IntreStats Stats => stats;
        public IntreCharacterInfos CharacterInfos => characterInfos;

        private ObservableCollection<string> skillsID = new ObservableCollection<string>();
        private ObservableCollection<string> castSkillsID = new ObservableCollection<string>();

        public List<string> SkillsID => new List<string>(skillsID);
        public List<string> CastSkillsID => new List<string>(castSkillsID);

        public Intre()
        {

        }

        public Intre(bool generateID)
        {
            id = Guid.NewGuid().ToString();
        }

        public Intre(IntreStats intreStats, IntreCharacterInfos characterInfos)
        {
            stats = intreStats;
            this.characterInfos = characterInfos;
            id = Guid.NewGuid().ToString();
        }

        public string Name
        {
            get => name; set
            {
                name = value;
            }
        }
        public string RaceID
        {
            get => raceID; set
            {
                raceID = value;
            }
        }

        public int Initiative => stats.Activity;
        public int Defense => stats.Defense;
        public int Shell => stats.Chitine;
        public int MaxImpact => stats.Resistance;
        public int MaxInjuries => stats.Metabolism;
        public int MaxFluid => stats.Activity;
        public int GroundSpeed => 3 + stats.Wings;
        public int AirSpeed => stats.Wings * 2;
    }
}
