using CircusTreinOpdracht.Classes;
using CircusTreinOpdracht.Enums;

List<Animal> AllAnimals = new List<Animal>()
{
    new Animal(AnimalTypes.Herbivore, AnimalSize.Medium,""),
    new Animal(AnimalTypes.Herbivore, AnimalSize.Medium,""),
    new Animal(AnimalTypes.Herbivore, AnimalSize.Medium,""),
    new Animal(AnimalTypes.Herbivore, AnimalSize.Heavy,""),
    new Animal(AnimalTypes.Herbivore, AnimalSize.Heavy,""),
    new Animal(AnimalTypes.Carnivore, AnimalSize.Light,""),
   
};

 Train train = new Train();
 train.FillTrain(AllAnimals);
 Console.WriteLine(train);
  








