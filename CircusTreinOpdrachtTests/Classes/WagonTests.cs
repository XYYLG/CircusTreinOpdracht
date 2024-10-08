using CircusTreinOpdracht.Enums;

namespace CircusTreinOpdracht.Classes.Tests
{
    [TestClass()]
    public class WagonTests
    {
        [TestMethod()]
        public void AddAnimal_H5_IsTrue() 
        {
            //Arrange
            Wagon wagon = new Wagon();
            Animal heavyHerbivore = new Animal(AnimalType.Herbivore, AnimalSize.Heavy, "testAnimal1");

            //Act
            bool isAdded = wagon.TryAddAnimal(heavyHerbivore);

            //Assert
            Assert.IsTrue(wagon.Animals.Contains(heavyHerbivore));
            Assert.AreEqual(1, wagon.Animals.Count);
            Assert.IsTrue(isAdded);
        }

        [TestMethod()] 
        public void AddAnimal_WagonsContainsH5AddH3_IsTrue()
        {
            Wagon wagon = new Wagon();
            Animal h5 = new Animal(AnimalType.Herbivore, AnimalSize.Heavy, "testAnimal1");
            wagon.TryAddAnimal(h5);

            Animal h3 = new Animal(AnimalType.Herbivore, AnimalSize.Medium, "testAnimal1");

            bool isAdded = wagon.TryAddAnimal(h3);

            Assert.IsTrue(wagon.Animals.Contains(h3));
            Assert.AreEqual(2, wagon.Animals.Count);
            Assert.IsTrue(isAdded);
        }

        [TestMethod()]

        public void AddAnimal_WagonsContainsH5H3AddH1_IsTrue()
        {
            Wagon wagon = new Wagon();
            Animal h5 = new Animal(AnimalType.Herbivore, AnimalSize.Heavy, "testAnimal1");
            Animal h3 = new Animal(AnimalType.Herbivore, AnimalSize.Medium, "testAnimal2");
            wagon.TryAddAnimal(h5);
            wagon.TryAddAnimal(h3);

            Animal h1 = new Animal(AnimalType.Herbivore, AnimalSize.Light, "testAnimal3");

            bool isAdded = wagon.TryAddAnimal(h1);

            Assert.IsTrue(wagon.Animals.Contains(h1));
            Assert.AreEqual(3, wagon.Animals.Count);
            Assert.IsTrue(isAdded);
        }

        [TestMethod()]

        public void AddAnimal_WagonContainsH5H3AddC1_IsTrue()
        {
            Wagon wagon = new Wagon();
            Animal h5 = new Animal(AnimalType.Herbivore, AnimalSize.Heavy, "testAnimal1");
            Animal h3 = new Animal(AnimalType.Herbivore, AnimalSize.Medium, "testAnimal2");
            wagon.TryAddAnimal(h5);
            wagon.TryAddAnimal(h3);

            Animal C1 = new Animal(AnimalType.Carnivore, AnimalSize.Light, "testAnimal3");

            bool isAdded = wagon.TryAddAnimal(C1);

            Assert.IsTrue(wagon.Animals.Contains(C1));
            Assert.AreEqual(3, wagon.Animals.Count);
            Assert.IsTrue(isAdded);
        }

        [TestMethod()]
        public void AddAnimal_WagonContainsH5H3AddC5_IsFalse()
        {
            Wagon wagon = new Wagon();
            Animal h5 = new Animal(AnimalType.Herbivore, AnimalSize.Heavy, "testAnimal1");
            Animal h3 = new Animal(AnimalType.Herbivore, AnimalSize.Medium, "testAnimal2");
            wagon.TryAddAnimal(h5);
            wagon.TryAddAnimal(h3);

            Animal C5 = new Animal(AnimalType.Carnivore, AnimalSize.Heavy, "testAnimal3");

            bool isAdded = wagon.TryAddAnimal(C5);

            Assert.IsFalse(wagon.Animals.Contains(C5));
            Assert.AreEqual(2, wagon.Animals.Count);
            Assert.IsFalse(isAdded);
        }

        [TestMethod()]
        public void AddAnimal_WagonContainsC5AddC3_IsFalse()
        {
            Wagon wagon = new Wagon();
            Animal C5 = new Animal(AnimalType.Carnivore, AnimalSize.Heavy, "testAnimal1");
            wagon.TryAddAnimal(C5);

            Animal C3 = new Animal(AnimalType.Carnivore, AnimalSize.Medium, "testAnimal2");

            bool isAdded = wagon.TryAddAnimal(C3);

            Assert.IsFalse(wagon.Animals.Contains(C3));
            Assert.AreEqual(1, wagon.Animals.Count);
            Assert.IsFalse(isAdded);
        }

        [TestMethod()]
        public void AddAnimal_WagonContainsC5AddH1_IsFalse()
        {
            Wagon wagon = new Wagon();
            Animal C5 = new Animal(AnimalType.Carnivore, AnimalSize.Heavy, "testAnimal1");
            wagon.TryAddAnimal(C5);

            Animal H1 = new Animal(AnimalType.Herbivore, AnimalSize.Light, "testAnimal2");

            bool isAdded = wagon.TryAddAnimal(H1);

            Assert.IsFalse(wagon.Animals.Contains(H1));
            Assert.AreEqual(1, wagon.Animals.Count);
            Assert.IsFalse(isAdded);
        }

        [TestMethod()]

        public void AddAnimal_C5_IsTrue()
        {
            Wagon wagon = new Wagon();
            Animal heavyCarnivore = new Animal(AnimalType.Carnivore, AnimalSize.Heavy, "testAnimal1");

            bool isAdded = wagon.TryAddAnimal(heavyCarnivore);

            Assert.IsTrue(wagon.Animals.Contains(heavyCarnivore));
            Assert.AreEqual(1, wagon.Animals.Count);
            Assert.IsTrue(isAdded);
        }
    }
}