using CircusTreinOpdracht.Classes;
using CircusTreinOpdracht.Enums;

List<Animal> AllAnimals = new List<Animal>()
{
    new Animal(AnimalTypes.Carnivore, AnimalSize.Light, "Cat"),
    new Animal(AnimalTypes.Herbivore, AnimalSize.Light, "Koala"),
    new Animal(AnimalTypes.Carnivore, AnimalSize.Medium, "Dog"),
    new Animal(AnimalTypes.Herbivore, AnimalSize.Medium, "Deer"),
    new Animal(AnimalTypes.Carnivore, AnimalSize.Heavy, "Tiger"),
    new Animal(AnimalTypes.Herbivore, AnimalSize.Heavy, "Elephant"),
    new Animal(AnimalTypes.Carnivore, AnimalSize.Light, "Platypus"),
    new Animal(AnimalTypes.Herbivore, AnimalSize.Light, "Parrot"),
    new Animal(AnimalTypes.Carnivore, AnimalSize.Medium, "Penguin"),
    new Animal(AnimalTypes.Herbivore, AnimalSize.Medium, "Koala2"),
    new Animal(AnimalTypes.Carnivore, AnimalSize.Heavy, "Lion"),
    new Animal(AnimalTypes.Herbivore, AnimalSize.Heavy, "Hippopotamus")
};

 Train train = new Train();
 train.FillTrain(AllAnimals);
 Console.WriteLine(train);
  








