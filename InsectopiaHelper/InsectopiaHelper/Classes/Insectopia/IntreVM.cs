using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace InsectopiaHelper
{
    public class IntreVM : INotifyPropertyChanged
    {
        protected Intre _intre;
        public Intre Intre
        {
            get
            {
                return _intre;
            }
            set
            {
                _intre = Intre;
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public IntreVM(Intre intre)
        {
            _intre = intre;
        }

        public string IntreName
        {
            get => _intre.Name;
            set
            {
                _intre.Name = value;
                NotifyPropertyChanged();
            }
        }

        #region Stats

        public int Wings
        {
            get => _intre.Stats.Wings; set
            {
                _intre.Stats.Wings = value;
                NotifyPropertyChanged();
            }
        }
        public int Antenna
        {
            get => _intre.Stats.Antenna; set
            {
                _intre.Stats.Antenna = value;
                NotifyPropertyChanged();
            }
        }
        public int Spirit
        {
            get => _intre.Stats.Spirit; set
            {
                _intre.Stats.Spirit = value;
                NotifyPropertyChanged();
            }
        }
        public int Mandibule
        {
            get => _intre.Stats.Mandibule; set
            {
                _intre.Stats.Mandibule = value;
                NotifyPropertyChanged();
            }
        }
        public int Chitine
        {
            get => _intre.Stats.Chitine; set
            {
                _intre.Stats.Chitine = value;
                NotifyPropertyChanged();
            }
        }
        public int Temperature
        {
            get => _intre.Stats.Temperature; set
            {
                _intre.Stats.Temperature = value;
                NotifyPropertyChanged();
            }
        }

        public int Agility
        {
            get => _intre.Stats.Agility; set
            {
                _intre.Stats.Agility = value;
                NotifyPropertyChanged();
            }
        }
        public int Defense
        {
            get => _intre.Stats.Defense; set
            {
                _intre.Stats.Defense = value;
                NotifyPropertyChanged();
            }
        }

        public int Pheromone
        {
            get => _intre.Stats.Pheromone; set
            {
                _intre.Stats.Pheromone = value;
                NotifyPropertyChanged();
            }
        }
        public int Aim
        {
            get => _intre.Stats.Aim; set
            {
                _intre.Stats.Aim = value;
                NotifyPropertyChanged();
            }
        }

        public int Instinct
        {
            get => _intre.Stats.Instinct; set
            {
                _intre.Stats.Instinct = value;
                NotifyPropertyChanged();
            }
        }
        public int Intelligence
        {
            get => _intre.Stats.Intelligence; set
            {
                _intre.Stats.Intelligence = value;
                NotifyPropertyChanged();
            }
        }

        public int Melee
        {
            get => _intre.Stats.Melee; set
            {
                _intre.Stats.Melee = value;
                NotifyPropertyChanged();
            }
        }
        public int Predator
        {
            get => _intre.Stats.Predator; set
            {
                _intre.Stats.Predator = value;
                NotifyPropertyChanged();
            }
        }

        public int Chrysalid
        {
            get => _intre.Stats.Chrysalid; set
            {
                _intre.Stats.Chrysalid = value;
                NotifyPropertyChanged();
            }
        }
        public int Resistance
        {
            get => _intre.Stats.Resistance; set
            {
                _intre.Stats.Resistance = value;
                NotifyPropertyChanged();
            }
        }

        public int Activity
        {
            get => _intre.Stats.Activity; set
            {
                _intre.Stats.Activity = value;
                NotifyPropertyChanged();
            }
        }
        public int Metabolism
        {
            get => _intre.Stats.Metabolism; set
            {
                _intre.Stats.Metabolism = value;
                NotifyPropertyChanged();
            }
        }

        public int Cast
        {
            get => _intre.Stats.Cast; set
            {
                _intre.Stats.Cast = value;
                NotifyPropertyChanged();
            }
        }

        #endregion

        #region CharacterInfos
        public string Species
        {
            get
            {
                return _intre.CharacterInfos.Species;
            }
            set
            {
                _intre.CharacterInfos.Species = value;
                NotifyPropertyChanged();
            }
        }

        public string Subspecies
        {
            get
            {
                return _intre.CharacterInfos.Subspecies;
            }
            set
            {
                _intre.CharacterInfos.Subspecies = value;
                NotifyPropertyChanged();
            }
        }

        public string Color
        {
            get
            {
                return _intre.CharacterInfos.Color;
            }
            set
            {
                _intre.CharacterInfos.Color = value;
                NotifyPropertyChanged();
            }
        }

        public string Diet
        {
            get
            {
                return _intre.CharacterInfos.Diet;
            }
            set
            {
                _intre.CharacterInfos.Diet = value;
                NotifyPropertyChanged();
            }
        }

        public string CastInfos
        {
            get
            {
                return _intre.CharacterInfos.Cast;
            }
            set
            {
                _intre.CharacterInfos.Cast = value;
                NotifyPropertyChanged();
            }
        }

        public string Religion
        {
            get
            {
                return _intre.CharacterInfos.Religion;
            }
            set
            {
                _intre.CharacterInfos.Religion = value;
                NotifyPropertyChanged();
            }
        }

        public string Alignement
        {
            get
            {
                return _intre.CharacterInfos.Alignement;
            }
            set
            {
                _intre.CharacterInfos.Alignement = value;
                NotifyPropertyChanged();
            }
        }

        public string Title
        {
            get
            {
                return _intre.CharacterInfos.Title;
            }
            set
            {
                _intre.CharacterInfos.Title = value;
                NotifyPropertyChanged();
            }
        }
        public string Work
        {
            get
            {
                return _intre.CharacterInfos.Work;
            }
            set
            {
                _intre.CharacterInfos.Work = value;
                NotifyPropertyChanged();
            }
        }
        public string Gender
        {
            get
            {
                return _intre.CharacterInfos.Gender;
            }
            set
            {
                _intre.CharacterInfos.Gender = value;
                NotifyPropertyChanged();
            }
        }
        public string Age
        {
            get
            {
                return _intre.CharacterInfos.Age;
            }
            set
            {
                _intre.CharacterInfos.Age = value;
                NotifyPropertyChanged();
            }
        }
        #endregion
    }
}
