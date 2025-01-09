using System.Collections.ObjectModel;

namespace CircusTreinOpdracht.Classes
{
    public class Train
    {
        private List<Wagon> _wagons = new List<Wagon>();
        public ReadOnlyCollection<Wagon> Wagons => _wagons.AsReadOnly(); //alleen get (readonly property)

        public void FillTrain(List<Animal> animals)
        {
            var sortedAnimals = animals
                .OrderBy(a => a.Type)
                .ThenBy(a => a.Size)
                .ToList();

            foreach (var animal in sortedAnimals)
            {
                bool animalAdded = false;

                foreach (var wagon in _wagons)
                {
                    if (wagon.TryAddAnimal(animal))
                    {
                        animalAdded = true;
                        break;
                    }
                }

                if (!animalAdded)
                {
                    var newWagon = new Wagon();
                    newWagon.TryAddAnimal(animal);
                    _wagons.Add(newWagon);
                }
            }
        }

        public override string ToString()
        {
            string result = $"Train with {_wagons.Count} wagons\r\n";
            foreach (var wagon in _wagons)
            {
                result += $"{wagon} \r\n";
            }
            return result;
        }
    }
}
