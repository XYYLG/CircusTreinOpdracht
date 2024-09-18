using CircusTreinOpdracht.Classes;
using CircusTreinOpdracht.Enums;

List<Animal> AllAnimals = new List<Animal>()
{
    new Animal(AnimalTypes.Carnivore, AnimalSize.Light, "CarnivoreLight"),
    new Animal(AnimalTypes.Herbivore, AnimalSize.Light, "HerbivoreLight"),
    new Animal(AnimalTypes.Carnivore, AnimalSize.Medium, "CarnivoreMedium"),
    new Animal(AnimalTypes.Herbivore, AnimalSize.Medium, "HerbivoreMedium"),
    new Animal(AnimalTypes.Carnivore, AnimalSize.Heavy, "CarnivoreHeavy"),
    new Animal(AnimalTypes.Herbivore, AnimalSize.Heavy, "HerbivoreHeavy"),
    new Animal(AnimalTypes.Carnivore, AnimalSize.Light, "CarnivoreLight"),
    new Animal(AnimalTypes.Herbivore, AnimalSize.Light, "HerbivoreLight"),
    new Animal(AnimalTypes.Carnivore, AnimalSize.Medium, "CarnivoreMedium"),
    new Animal(AnimalTypes.Herbivore, AnimalSize.Medium, "HerbivoreMedium"),
    new Animal(AnimalTypes.Carnivore, AnimalSize.Heavy, "CarnivoreHeavy"),
    new Animal(AnimalTypes.Herbivore, AnimalSize.Heavy, "HerbivoreHeavy")
};

 Train train = new Train();
 train.FillTrain(AllAnimals);
 Console.WriteLine(train);
  








