using System;
using System.Collections.Generic;
using System.Text;

namespace InsectopiaHelper
{
    public static class RandomUtility
    {
        public static Random r = new Random();

        public static T RandomItem<T>(this IList<T> list)
        {
            if(list == null || list.Count == 0)
            {
                return default;
            }

            return list[r.Next(list.Count)];
        }

        public static Intre GenerateIntre()
        {
            return new Intre(
                new IntreStats
                {
                    Antenna = 3,
                    Pheromone = 3,
                    Aim = 1,
                    Spirit = 5,
                    Instinct = 2,
                    Intelligence = 4,
                    Wings = 3,
                    Agility = 2,
                    Defense = 2,
                    Temperature = 2,
                    Activity = 2,
                    Metabolism = 2,
                    Chitine = 4,
                    Chrysalid = 3,
                    Resistance = 2,
                    Mandibule = 3,
                    Melee = 3,
                    Predator = 1,
                    Cast = 6
                },
                new IntreCharacterInfos
                {
                    Species = "Brindis",
                    Subspecies = "Phyllis",
                    Color = "Vert",
                    Diet = "Herbivore",
                    Cast = "Divin",
                    Religion = "Cultiste",
                    Alignement = "Loyal Mauvais",
                    Title = "",
                    Work = "Prêtre des Anciens Dieux",
                    Gender = "Masculin",
                    Age = "25"
                })
            {
                Name = "Euid",
            };
        }
    }
}
