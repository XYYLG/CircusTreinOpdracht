using CircusTreinOpdracht.Enums;

namespace CircusTreinOpdracht.Classes
{
    public class AnimalFactory
    {
        public static List<Animal> CreateAnimals(int count, AnimalSize size, AnimalType type)
        {
            List<Animal> animals = new List<Animal>();

            // Create the specified number of animals with the given size and type
            for (int i = 0; i < count; i++)
            {
                animals.Add(new Animal(type, size));
            }

            return animals;
        }
    }
}
