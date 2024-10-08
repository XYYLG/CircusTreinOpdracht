namespace CircusTreinOpdracht.Classes.Tests
{
    [TestClass()]
    public class AnimalTests
    {
        [TestMethod()]
        public void CheckifCompatible_H5_C1_IsTrue()
        {
            //Arrange
            Animal heavyHerbivore = new Animal(Enums.AnimalType.Herbivore, Enums.AnimalSize.Heavy, "testAnimal1");
            Animal lightCarnivore = new Animal(Enums.AnimalType.Carnivore, Enums.AnimalSize.Light, "testAnimal2");

            //Act
            bool isCompatible  = heavyHerbivore.CheckifCompatible(lightCarnivore);

            //Assert
            Assert.IsTrue(isCompatible);
        }

        [TestMethod()]

        public void CheckifCompatible_H1_C5_IsFalse()
        {
            Animal lightHerbivore = new Animal(Enums.AnimalType.Herbivore, Enums.AnimalSize.Light, "testAnimal1");
            Animal heavyCarnivore = new Animal(Enums.AnimalType.Carnivore, Enums.AnimalSize.Heavy, "testAnimal2");

            bool isCompatible = lightHerbivore.CheckifCompatible(heavyCarnivore);

            Assert.IsFalse(isCompatible);
        }

        [TestMethod()]

        public void CheckifCompatible_C3_H1_IsFalse()
        {
            Animal mediumCarnivore = new Animal(Enums.AnimalType.Carnivore, Enums.AnimalSize.Medium, "testAnimal1");
            Animal lightHerbivore = new Animal(Enums.AnimalType.Herbivore, Enums.AnimalSize.Light, "testAnimal2");

            bool isCompatible = mediumCarnivore.CheckifCompatible(lightHerbivore);

            Assert.IsFalse(isCompatible);
        }

        [TestMethod()]

        public void CheckifCompatible_H3_H3_IsTrue()
        {
            Animal mediumHerbivore1 = new Animal(Enums.AnimalType.Herbivore, Enums.AnimalSize.Medium, "testAnimal1");
            Animal mediumHerbivore2 = new Animal(Enums.AnimalType.Herbivore, Enums.AnimalSize.Medium, "testAnimal2");

            bool isCompatible = mediumHerbivore1.CheckifCompatible(mediumHerbivore2);

            Assert.IsTrue(isCompatible);
        }

        [TestMethod()]

        public void CheckifCompatible_C5_C5_IsFalse()
        {
            Animal heavyCarnivore1 = new Animal(Enums.AnimalType.Carnivore, Enums.AnimalSize.Heavy, "testAnimal1");
            Animal heavyCarnivore2 = new Animal(Enums.AnimalType.Carnivore, Enums.AnimalSize.Heavy, "testAnimal2");

            bool isCompatible = heavyCarnivore1.CheckifCompatible(heavyCarnivore2);

            Assert.IsFalse(isCompatible);
        }

        [TestMethod()]

        public void CheckifCompatible_H1_H1_IsTrue()
        {
            Animal lightHerbivore1 = new Animal(Enums.AnimalType.Herbivore, Enums.AnimalSize.Light, "testAnimal1");
            Animal lightHerbivore2 = new Animal(Enums.AnimalType.Herbivore, Enums.AnimalSize.Light, "testAnimal2");

            bool isCompatible = lightHerbivore1.CheckifCompatible(lightHerbivore2);

            Assert.IsTrue(isCompatible);
        }

        [TestMethod()]
        public void CheckifCompatible_H3_C3_IsFalse()
        {
            Animal mediumHerbivore = new Animal(Enums.AnimalType.Herbivore, Enums.AnimalSize.Medium, "testAnimal1");
            Animal mediumCarnivore = new Animal(Enums.AnimalType.Carnivore, Enums.AnimalSize.Medium, "testAnimal2");

            bool isCompatible = mediumHerbivore.CheckifCompatible(mediumCarnivore);

            Assert.IsFalse(isCompatible);
        }

        [TestMethod()]

        public void CheckifCompatible_H5_C3_IsTrue()
        {
            Animal heavyHerbivore = new Animal(Enums.AnimalType.Herbivore, Enums.AnimalSize.Heavy, "testAnimal1");
            Animal mediumCarnivore = new Animal(Enums.AnimalType.Carnivore, Enums.AnimalSize.Medium, "testAnimal2");

            bool isCompatible = heavyHerbivore.CheckifCompatible(mediumCarnivore);

            Assert.IsTrue(isCompatible);
        }

        [TestMethod()]
        public void CheckifCompatible_C1_H1_IsFalse()
        {
            Animal lightCarnivore = new Animal(Enums.AnimalType.Carnivore, Enums.AnimalSize.Light, "testAnimal1");
            Animal lightHerbivore = new Animal(Enums.AnimalType.Herbivore, Enums.AnimalSize.Light, "testAnimal2");

            bool isCompatible = lightCarnivore.CheckifCompatible(lightHerbivore);

            Assert.IsFalse(isCompatible);
        }

        [TestMethod()]
        public void CheckifCompatible_H1_H3_IsTrue()
        {
            Animal lightHerbivore = new Animal(Enums.AnimalType.Herbivore, Enums.AnimalSize.Light, "testAnimal1");
            Animal mediumHerbivore = new Animal(Enums.AnimalType.Herbivore, Enums.AnimalSize.Medium, "testAnimal2");

            bool isCompatible = lightHerbivore.CheckifCompatible(mediumHerbivore);

            Assert.IsTrue(isCompatible);
        }

    }
}