using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CircusTreinOpdracht.Enums;

namespace CircusTreinOpdracht.Classes
{
    public class Animal
    {
        public AnimalTypes AnimalType { get; private set; }
        public AnimalSize AnimalSize { get; private set; }
        public string AnimalName { get; private set; }


        public Animal(AnimalTypes AnimalType, AnimalSize AnimalSize, string AnimalName )
        {
            this.AnimalType = AnimalType;
            this.AnimalSize = AnimalSize;
            this.AnimalName = AnimalName;
        }
         


        public override string ToString()
        {
            return AnimalName;
        }

        public bool CheckifCompatible(Animal animal)
        {
            if (this.AnimalType == AnimalTypes.Herbivore && animal.AnimalType == AnimalTypes.Herbivore)
            {
                return true;
            }
            else if (this.AnimalType == AnimalTypes.Herbivore && animal.AnimalType == AnimalTypes.Carnivore && this.AnimalSize > animal.AnimalSize)
            {
                return true;
            }
            else if (this.AnimalType == AnimalTypes.Carnivore && animal.AnimalType == AnimalTypes.Herbivore && this.AnimalSize < animal.AnimalSize)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

