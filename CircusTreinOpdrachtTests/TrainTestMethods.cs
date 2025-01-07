namespace CircusTreinOpdracht.Classes.Tests
{
    public class TrainTestMethods
    {
        public Train CreateTrain()
        {
            return new Train();
        }

        public void AddAnimalToList(Train train, List<Animal> actualAnimals)
        {
            foreach (var wagon in train.Wagons)
            {
                if (wagon.Animals != null)
                {
                    actualAnimals.AddRange(wagon.Animals);
                }
            }
        }
    }
}
