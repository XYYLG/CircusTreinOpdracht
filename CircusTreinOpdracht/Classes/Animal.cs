using CircusTreinOpdracht.Enums;

namespace CircusTreinOpdracht.Classes
{
    public class Animal
    {
        public AnimalType Type{ get; private set; }
        public AnimalSize Size { get; private set; }
        public string Name { get; private set; }

        
        public Animal(AnimalType type, AnimalSize size) : this(type, size, "Animal")
        {
        }

        public Animal(AnimalType type, AnimalSize size, string name)
        {
            this.Type = type;
            this.Size = size;
            this.Name = name;
        }

        public bool CheckifCompatible(Animal otherAnimal)
        {
            if (this.Type == AnimalType.Herbivore && otherAnimal.Type == AnimalType.Herbivore)
            {
                return true;
            }
            else if (this.Type == AnimalType.Herbivore && otherAnimal.Type == AnimalType.Carnivore && this.Size > otherAnimal.Size)
            {
                return true;
            }
            else if (this.Type == AnimalType.Carnivore && otherAnimal.Type == AnimalType.Herbivore && this.Size < otherAnimal.Size)
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}


