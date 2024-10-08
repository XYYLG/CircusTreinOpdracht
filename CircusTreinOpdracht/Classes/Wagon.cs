using System.Collections.ObjectModel;

namespace CircusTreinOpdracht.Classes
{
    public class Wagon
    {
        private const int MaxCapacity = 10;
        private List<Animal> animals = new List<Animal>();
        public ReadOnlyCollection<Animal> Animals => animals.AsReadOnly(); //alleen get (readonly property)

        private int SumAnimalSize()
        {
            int totalSize = 0;

            for (int i = 0; i < animals.Count; i++)
            {
                totalSize += (int)animals[i].Size;
            }

            return totalSize;
        }

        public bool TryAddAnimal(Animal newAnimal)
        {          
            int currentTotalSize = SumAnimalSize(); 

            if (currentTotalSize + (int)newAnimal.Size > MaxCapacity)
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