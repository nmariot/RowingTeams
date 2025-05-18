using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace RowingTeams
{
    internal static class Helper
    {
        public static int GetMinAge(RaceCategory category)
        {
            return category switch
            {
                RaceCategory.A => 27,
                RaceCategory.B => 36,
                RaceCategory.C => 43,
                RaceCategory.D => 50,
                RaceCategory.E => 55,
                RaceCategory.F => 60,
                RaceCategory.G => 65,
                RaceCategory.H => 70,
                RaceCategory.I => 75,
                RaceCategory.J => 80,
                RaceCategory.K => 83,
                RaceCategory.L => 86,
                RaceCategory.M => 89,
                _ => 200
            };
        }

        public static int GetMaxOptimalAge(RaceCategory category) => GetMinAge((RaceCategory)((int)category + 1));

        public static Race CreateRaceFromLibelle(string libelle)
        {
            int number;
            RaceType rt;
            RaceCategory category;
            int nbRowers;

            var data = libelle.Split(' ');
            number = int.Parse(data[0]);

            if (data.Length == 3)
            {
                if (data[1][0] == 'W')
                {
                    rt = RaceType.Women;
                    _ = Enum.TryParse(data[1][1].ToString(), out category);
                }
                else
                {
                    rt = RaceType.Men;
                    _ = Enum.TryParse(data[1], out category);
                }
                nbRowers = int.Parse(data[2][0].ToString());
            }
            else
            {
                rt = RaceType.Mixed;
                _ = Enum.TryParse(data[2], out category);
                nbRowers = int.Parse(data[3][0].ToString());
            }

            return new Race(number, libelle, rt, nbRowers, category);
        }

        public static List<Boat> GetBoatsFromRace(Race race, List<Rower> rowers, bool withOptimalAge)
        {
            // Pseudocode:
            // 1. Filtrer les rameurs selon le type de course (sexe, mixte, âge minimum).
            // 2. Générer toutes les combinaisons possibles de rameurs de taille race.NbRowers.
            // 3. Pour chaque combinaison, vérifier si elle respecte les contraintes (âge, mixité si besoin).
            // 4. Créer un Boat pour chaque combinaison valide et l'ajouter à la liste.
            // 5. Retourner la liste.

            var list = new List<Boat>();
            int nbRowers = race.NbRowers;
            int minAge = GetMinAge(race.Category);

            // Filtrage initial selon le type de course
            IEnumerable<Rower> filteredRowers = rowers;
            switch (race.Type)
            {
                case RaceType.Men:
                    filteredRowers = filteredRowers.Where(r => r.Sex == Sex.Male);
                    break;
                case RaceType.Women:
                    filteredRowers = filteredRowers.Where(r => r.Sex == Sex.Female);
                    break;
                case RaceType.Mixed:
                    // On garde tout, la vérification mixte se fera sur la combinaison
                    break;
            }

            // Générer toutes les combinaisons possibles
            var combinations = GetCombinations([.. filteredRowers], nbRowers);

            foreach (var combo in combinations)
            {
                // Vérif de l'age moyen
                var avgAge = combo.Average(r => r.Age);
                if (avgAge < GetMinAge(race.Category)) continue;
                if (withOptimalAge && avgAge >= GetMaxOptimalAge(race.Category)) continue;

                // En mixte, il faut autant d'hommes que de femmes
                if (race.Type == RaceType.Mixed)
                {
                    var nbMen = combo.Count(c => c.Sex == Sex.Male);
                    var nbWomen = combo.Count(c => c.Sex == Sex.Female);
                    // Vérifier qu'il y a autant d'hommes que de femmes  
                    if (nbMen != nbWomen)
                        continue;
                }

                list.Add(new Boat(combo));
            }

            return list;
        }

        /// <summary>
        /// Génère toutes les combinaisons possibles de k éléments dans la liste (merci Copilot)
        /// </summary>
        /// <param name="list"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        private static IEnumerable<IEnumerable<Rower>> GetCombinations(List<Rower> list, int k)
        {
            if (k == 0) yield return new List<Rower>();
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    var head = list[i];
                    var tail = list.Skip(i + 1).ToList();
                    foreach (var tailComb in GetCombinations(tail, k - 1))
                    {
                        yield return (new List<Rower> { head }).Concat(tailComb);
                    }
                }
            }
        }
    }
}
