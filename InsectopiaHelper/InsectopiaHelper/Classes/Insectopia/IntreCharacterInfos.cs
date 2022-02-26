using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace InsectopiaHelper
{
    [Serializable]
    public class IntreCharacterInfos
    {
        private string species;
        public string Species
        {
            get
            {
                return species;
            }
            set
            {
                species = value;
            }
        }

        private string subspecies;
        public string Subspecies
        {
            get
            {
                return subspecies;
            }
            set
            {
                subspecies = value;
            }
        }

        private string color;
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        private string diet;
        public string Diet
        {
            get
            {
                return diet;
            }
            set
            {
                diet = value;
            }
        }

        private string cast;
        public string Cast
        {
            get
            {
                return cast;
            }
            set
            {
                cast = value;
            }
        }

        private string religion;
        public string Religion
        {
            get
            {
                return religion;
            }
            set
            {
                religion = value;
            }
        }

        private string alignement;
        public string Alignement
        {
            get
            {
                return alignement;
            }
            set
            {
                alignement = value;
            }
        }

        private string title;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        private string work;
        public string Work
        {
            get
            {
                return work;
            }
            set
            {
                work = value;
            }
        }

        private string gender;
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        private string age;
        public string Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
    }
}
