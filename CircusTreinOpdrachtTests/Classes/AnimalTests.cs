using CircusTreinOpdracht.Enums;
namespace CircusTreinOpdracht.Classes.Tests
  
{
    [TestClass()]
    public class AnimalTests
    {
        [TestMethod()]
        public void CheckifCompatible_H5_C1_IsTrue()
        {
            //Arrange
            Animal heavyHerbivore = new Animal(AnimalType.Herbivore, AnimalSize.Heavy, "testAnimal1");
            Animal lightCarnivore = new Animal(AnimalType.Carnivore, AnimalSize.Light, "testAnimal2");

            //Act
            bool isCompatible  = heavyHerbivore.CheckifCompatible(lightCarnivore);

            //Assert
            Assert.IsTrue(isCompatible);
        }

        [TestMethod()]

        public void CheckifCompatible_H1_C5_IsFalse()
        {
            Animal lightHerbivore = new Animal(AnimalType.Herbivore, AnimalSize.Light, "testAnimal1");
            Animal heavyCarnivore = new Animal(AnimalType.Carnivore, AnimalSize.Heavy, "testAnimal2");

            bool isCompatible = lightHerbivore.CheckifCompatible(heavyCarnivore);

            Assert.IsFalse(isCompatible);
        }

        [TestMethod()]

        public void CheckifCompatible_C3_H1_IsFalse()
        {
            Animal mediumCarnivore = new Animal(AnimalType.Carnivore, AnimalSize.Medium, "testAnimal1");
            Animal lightHerbivore = new Animal(AnimalType.Herbivore, AnimalSize.Light, "testAnimal2");

            bool isCompatible = mediumCarnivore.CheckifCompatible(lightHerbivore);

            Assert.IsFalse(isCompatible);
        }

        [TestMethod()]

        public void CheckifCompatible_H3_H3_IsTrue()
        {
            Animal mediumHerbivore1 = new Animal(AnimalType.Herbivore, AnimalSize.Medium, "testAnimal1");
            Animal mediumHerbivore2 = new Animal(AnimalType.Herbivore, AnimalSize.Medium, "testAnimal2");

            bool isCompatible = mediumHerbivore1.CheckifCompatible(mediumHerbivore2);

            Assert.IsTrue(isCompatible);
        }

        [TestMethod()]

        public void CheckifCompatible_C5_C5_IsFalse()
        {
            Animal heavyCarnivore1 = new Animal(AnimalType.Carnivore, AnimalSize.Heavy, "testAnimal1");
            Animal heavyCarnivore2 = new Animal(AnimalType.Carnivore, AnimalSize.Heavy, "testAnimal2");

            bool isCompatible = heavyCarnivore1.CheckifCompatible(heavyCarnivore2);

            Assert.IsFalse(isCompatible);
        }

        [TestMethod()]

        public void CheckifCompatible_H1_H1_IsTrue()
        {
            Animal lightHerbivore1 = new Animal(AnimalType.Herbivore, AnimalSize.Light, "testAnimal1");
            Animal lightHerbivore2 = new Animal(AnimalType.Herbivore, AnimalSize.Light, "testAnimal2");

            bool isCompatible = lightHerbivore1.CheckifCompatible(lightHerbivore2);

            Assert.IsTrue(isCompatible);
        }

        [TestMethod()]
        public void CheckifCompatible_H3_C3_IsFalse()
        {
            Animal mediumHerbivore = new Animal(AnimalType.Herbivore, AnimalSize.Medium, "testAnimal1");
            Animal mediumCarnivore = new Animal(AnimalType.Carnivore, AnimalSize.Medium, "testAnimal2");

            bool isCompatible = mediumHerbivore.CheckifCompatible(mediumCarnivore);

            Assert.IsFalse(isCompatible);
        }

        [TestMethod()]

        public void CheckifCompatible_H5_C3_IsTrue()
        {
            Animal heavyHerbivore = new Animal(AnimalType.Herbivore, AnimalSize.Heavy, "testAnimal1");
            Animal mediumCarnivore = new Animal(AnimalType.Carnivore, AnimalSize.Medium, "testAnimal2");

            bool isCompatible = heavyHerbivore.CheckifCompatible(mediumCarnivore);

            Assert.IsTrue(isCompatible);
        }

        [TestMethod()]
        public void CheckifCompatible_C1_H1_IsFalse()
        {
            Animal lightCarnivore = new Animal(AnimalType.Carnivore, AnimalSize.Light, "testAnimal1");
            Animal lightHerbivore = new Animal(AnimalType.Herbivore, AnimalSize.Light, "testAnimal2");

            bool isCompatible = lightCarnivore.CheckifCompatible(lightHerbivore);

            Assert.IsFalse(isCompatible);
        }

        [TestMethod()]
        public void CheckifCompatible_H1_H3_IsTrue()
        {
            Animal lightHerbivore = new Animal(AnimalType.Herbivore, AnimalSize.Light, "testAnimal1");
            Animal mediumHerbivore = new Animal(AnimalType.Herbivore, AnimalSize.Medium, "testAnimal2");

            bool isCompatible = lightHerbivore.CheckifCompatible(mediumHerbivore);

            Assert.IsTrue(isCompatible);
        }

        [TestMethod()]
        public void CheckifCompatible_C1_C1_IsFalse()
        {
            Animal lightCarnivoreOne = new Animal(AnimalType.Carnivore,AnimalSize.Light, "testAnimal1");
            Animal lightCarnivoreTwo = new Animal(AnimalType.Carnivore, AnimalSize.Light, "testANimal2");
            
            bool isCompatible = lightCarnivoreOne.CheckifCompatible(lightCarnivoreTwo);

            Assert.IsFalse(isCompatible);
        }

        [TestMethod()]
        public void CheckifCompatible_C1_C3_IsFalse()
        {
            Animal lightCarnivore = new Animal(AnimalType.Carnivore, AnimalSize.Light, "testAnimal1");
            Animal mediumCarnivore = new Animal(AnimalType.Carnivore, AnimalSize.Medium, "testANimal2");

            bool isCompatible = lightCarnivore.CheckifCompatible(mediumCarnivore);

            Assert.IsFalse(isCompatible);
        }

        [TestMethod()]
        public void CheckifCompatible_C1_C5_IsFalse()
        {
            Animal lightCarnivore = new Animal(AnimalType.Carnivore, AnimalSize.Light, "testAnimal1");
            Animal heavyCarnivore = new Animal(AnimalType.Carnivore, AnimalSize.Heavy, "testANimal2");

            bool isCompatible = lightCarnivore.CheckifCompatible(heavyCarnivore);

            Assert.IsFalse(isCompatible);
        }

        [TestMethod()]
        public void CheckifCompatible_C1_H3_IsTrue()
        {
            Animal lightCarnivore = new Animal(AnimalType.Carnivore, AnimalSize.Light, "testAnimal1");
            Animal mediunHerbivore = new Animal(AnimalType.Herbivore, AnimalSize.Medium, "testANimal2");

            bool isCompatible = lightCarnivore.CheckifCompatible(mediunHerbivore);

            Assert.IsTrue(isCompatible);
        }

        [TestMethod()]
        public void CheckifCompatible_C3_C3_IsFalse()
        {
            Animal mediumCarnivore = new Animal(AnimalType.Carnivore, AnimalSize.Medium, "testAnimal1");
            Animal mediunCarnivore = new Animal(AnimalType.Carnivore, AnimalSize.Medium, "testANimal2");

            bool isCompatible = mediumCarnivore.CheckifCompatible(mediunCarnivore);

            Assert.IsFalse(isCompatible);
        }

        [TestMethod()]
        public void CheckifCompatible_C3_C5_IsFalse()
        {
            Animal mediumCarnivore = new Animal(AnimalType.Carnivore, AnimalSize.Medium, "testAnimal1");
            Animal heavyCarnivore = new Animal(AnimalType.Carnivore, AnimalSize.Heavy, "testANimal2");

            bool isCompatible = mediumCarnivore.CheckifCompatible(heavyCarnivore);

            Assert.IsFalse(isCompatible);
        }

        [TestMethod()]
        public void CheckifCompatible_C5_H3_IsFalse()
        {
            Animal heavyCarnivore = new Animal(AnimalType.Carnivore, AnimalSize.Heavy, "testAnimal1");
            Animal mediumHerbivore = new Animal(AnimalType.Herbivore, AnimalSize.Medium, "testANimal2");

            bool isCompatible = heavyCarnivore.CheckifCompatible(mediumHerbivore);

            Assert.IsFalse(isCompatible);
        }

        [TestMethod()]
        public void CheckifCompatible_C5_H5_IsFalse()
        {
            Animal heavyCarnivore = new Animal(AnimalType.Carnivore, AnimalSize.Heavy, "testAnimal1");
            Animal heavyHerbivore = new Animal(AnimalType.Herbivore, AnimalSize.Heavy, "testANimal2");

            bool isCompatible = heavyCarnivore.CheckifCompatible(heavyHerbivore);

            Assert.IsFalse(isCompatible);
        }

        [TestMethod()]
        public void CheckifCompatible_H1_H5_IsTrue()
        {
            Animal lightHerbivore = new Animal(AnimalType.Herbivore, AnimalSize.Light, "testAnimal1");
            Animal heavyHerbivore = new Animal(AnimalType.Herbivore, AnimalSize.Heavy, "testANimal2");

            bool isCompatible = lightHerbivore.CheckifCompatible(heavyHerbivore);

            Assert.IsTrue(isCompatible);
        }

        [TestMethod()]
        public void CheckifCompatible_H3_H5_IsTrue()
        {
            Animal mediumHerbivore = new Animal(AnimalType.Herbivore, AnimalSize.Medium, "testAnimal1");
            Animal heavyHerbivore = new Animal(AnimalType.Herbivore, AnimalSize.Heavy, "testANimal2");

            bool isCompatible = mediumHerbivore.CheckifCompatible(heavyHerbivore);

            Assert.IsTrue(isCompatible);
        }

        [TestMethod()]
        public void CheckIfCompatible_H5_H5_IsTrue()
        {
            Animal heavyHerbivoreOne = new Animal(AnimalType.Herbivore, AnimalSize.Heavy, "testAnimal1");
            Animal heavyHerbivoreTwo = new Animal(AnimalType.Herbivore, AnimalSize.Heavy, "testANimal2");

            bool isCompatible = heavyHerbivoreOne.CheckifCompatible(heavyHerbivoreTwo);

            Assert.IsTrue(isCompatible);
        }

    }
}