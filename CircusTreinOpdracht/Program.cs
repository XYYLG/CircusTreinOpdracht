using CircusTreinOpdracht.Classes;
using CircusTreinOpdracht.Enums;

List<Animal> AllAnimals = new List<Animal>()
{
    new Animal(AnimalType.Herbivore, AnimalSize.Medium,""),
    new Animal(AnimalType.Herbivore, AnimalSize.Medium,""),
    new Animal(AnimalType.Herbivore, AnimalSize.Medium,""),
    new Animal(AnimalType.Herbivore, AnimalSize.Heavy,""),
    new Animal(AnimalType.Herbivore, AnimalSize.Heavy,""),
    new Animal(AnimalType.Carnivore, AnimalSize.Light,""),
   
};

 Train train = new Train();
 train.FillTrain(AllAnimals);
 Console.WriteLine(train);











