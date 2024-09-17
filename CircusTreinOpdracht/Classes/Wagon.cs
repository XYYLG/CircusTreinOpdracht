using CircusTreinOpdracht.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTreinOpdracht.Classes
{
    internal class Wagon
    {

        private List<Animal> animals = new List<Animal>();
        private const int MaxCapacity = 10;

        private int SumAnimalSize()
        {
            int totalSize = 0;

            for (int i = 0; i < animals.Count; i++)
            {
                totalSize += (int)animals[i].AnimalSize;
            }

            return totalSize;
        }


        public bool AddAnimal(Animal newAnimal)
        {          
            int currentTotalSize = SumAnimalSize(); 

            if (currentTotalSize + (int)newAnimal.AnimalSize > MaxCapacity)
            {
                return false;
            }

            foreach (var animal in animals)
            {
                if (!animal.CheckifCompatible(newAnimal))
                {
                    return false;
                }
            }

            animals.Add(newAnimal);
            return true;

        }

      
        public override string ToString()
        {
            string result = $"Wagon with {animals.Count} animals\r\n";
            foreach (var animal in animals)
            {
                result += $"- {animal}\r\n";
            }
            return result ;
        }


    }
}