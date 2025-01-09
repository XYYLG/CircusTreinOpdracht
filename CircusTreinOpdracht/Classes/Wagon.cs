using System.Collections.ObjectModel;

namespace CircusTreinOpdracht.Classes
{
    public class Wagon
    {
        private const int MaxCapacity = 10;
        private List<Animal> _animals = new List<Animal>();
        public ReadOnlyCollection<Animal> Animals => _animals.AsReadOnly(); //alleen get (readonly property)

        private int SumAnimalSize()
        {
            int totalSize = 0;

            for (int i = 0; i < _animals.Count; i++)
            {
                totalSize += (int)_animals[i].Size;
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

            foreach (var animal in _animals)
            {
                if (!animal.CheckifCompatible(newAnimal))
                {
                    return false;
                }
            }

            _animals.Add(newAnimal);

            return true;
        }
      
        public override string ToString()
        {
            string result = $"Wagon with {_animals.Count} animals\r\n";
            foreach (var animal in _animals)
            {
                result += $"- {animal}\r\n";
            }
            return result ;
        }
    }
}