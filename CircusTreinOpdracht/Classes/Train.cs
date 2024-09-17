using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTreinOpdracht.Classes
{
    internal class Train
    {
        private List<Wagon> wagons = new List<Wagon>();



        public void FillTrain(List<Animal> animals)
        {
            var sortedAnimals = animals
                .OrderBy(a => a.AnimalType)
                .ThenByDescending(a => a.AnimalSize)
                .ToList();

            foreach (var animal in sortedAnimals)
            {
                bool animalAdded = false;

                foreach (var wagon in wagons)
                {
                    if (wagon.AddAnimal(animal))
                    {
                        animalAdded = true;
                        break;
                    }
                }

                if (!animalAdded)
                {
                    var newWagon = new Wagon();
                    newWagon.AddAnimal(animal);
                    wagons.Add(newWagon);
                }
            }
        }

        public override string ToString()
        {
            string result = $"Train with {wagons.Count} wagons\r\n";
            foreach (var wagon in wagons)
            {
                result += $"{wagon} \r\n" ;           
            }
            return result;
        }

        
    }
}
