using Microsoft.VisualStudio.TestTools.UnitTesting;
using CircusTreinOpdracht.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTreinOpdracht.Classes.Tests
{
    [TestClass()]
    public class AnimalTests
    {
        [TestMethod()]
        public void CheckifCompatibleHeavyHerbivorelightCarnivoreTrue()
        {
            //Arrange
            Animal heavyHerbivore = new Animal(Enums.AnimalTypes.Herbivore, Enums.AnimalSize.Heavy, "testAnimal1");
            Animal lightCarnivore = new Animal(Enums.AnimalTypes.Carnivore, Enums.AnimalSize.Light, "testAnimal2");

            //Act
            bool isCompatible  = heavyHerbivore.CheckifCompatible(lightCarnivore);

            //Assert
            Assert.IsTrue(isCompatible);
        }

        [TestMethod()]

        public void CheckifCompatibleLightHerbivoreHeavyCarnivoreFalse()
        {
            Animal lightHerbivore = new Animal(Enums.AnimalTypes.Herbivore, Enums.AnimalSize.Light, "testAnimal1");
            Animal heavyCarnivore = new Animal(Enums.AnimalTypes.Carnivore, Enums.AnimalSize.Heavy, "testAnimal2");

            bool isCompatible = lightHerbivore.CheckifCompatible(heavyCarnivore);

            Assert.IsFalse(isCompatible);
        }

        [TestMethod()]

        public void CheckifCompatibleMediumCarnivoreLightHerbivoreFalse()
        {
            Animal mediumCarnivore = new Animal(Enums.AnimalTypes.Carnivore, Enums.AnimalSize.Medium, "testAnimal1");
            Animal lightHerbivore = new Animal(Enums.AnimalTypes.Herbivore, Enums.AnimalSize.Light, "testAnimal2");

            bool isCompatible = mediumCarnivore.CheckifCompatible(lightHerbivore);

            Assert.IsFalse(isCompatible);
        }

        [TestMethod()]

        public void CheckifCompatibleMediumHerbivoreMediumHerbivoreTrue()
        {
            Animal mediumHerbivore1 = new Animal(Enums.AnimalTypes.Herbivore, Enums.AnimalSize.Medium, "testAnimal1");
            Animal mediumHerbivore2 = new Animal(Enums.AnimalTypes.Herbivore, Enums.AnimalSize.Medium, "testAnimal2");

            bool isCompatible = mediumHerbivore1.CheckifCompatible(mediumHerbivore2);

            Assert.IsTrue(isCompatible);
        }

        [TestMethod()]

        public void CheckifCompatibleHeavyCarnivoreHeavyCarnivoreFalse()
        {
            Animal heavyCarnivore1 = new Animal(Enums.AnimalTypes.Carnivore, Enums.AnimalSize.Heavy, "testAnimal1");
            Animal heavyCarnivore2 = new Animal(Enums.AnimalTypes.Carnivore, Enums.AnimalSize.Heavy, "testAnimal2");

            bool isCompatible = heavyCarnivore1.CheckifCompatible(heavyCarnivore2);

            Assert.IsFalse(isCompatible);
        }

        [TestMethod()]

        public void CheckifCompatibleLightHerbivoreLightHerbivoreTrue()
        {
            Animal lightHerbivore1 = new Animal(Enums.AnimalTypes.Herbivore, Enums.AnimalSize.Light, "testAnimal1");
            Animal lightHerbivore2 = new Animal(Enums.AnimalTypes.Herbivore, Enums.AnimalSize.Light, "testAnimal2");

            bool isCompatible = lightHerbivore1.CheckifCompatible(lightHerbivore2);

            Assert.IsTrue(isCompatible);
        }

        [TestMethod()]
        public void CheckifCompatibleMediumHerbivoreMediumCarnivoreFalse()
        {
            Animal mediumHerbivore = new Animal(Enums.AnimalTypes.Herbivore, Enums.AnimalSize.Medium, "testAnimal1");
            Animal mediumCarnivore = new Animal(Enums.AnimalTypes.Carnivore, Enums.AnimalSize.Medium, "testAnimal2");

            bool isCompatible = mediumHerbivore.CheckifCompatible(mediumCarnivore);

            Assert.IsFalse(isCompatible);
        }

        [TestMethod()]

        public void CheckifCompatibleHeavyHerbivoreMediumCarnivoreTrue()
        {
            Animal heavyHerbivore = new Animal(Enums.AnimalTypes.Herbivore, Enums.AnimalSize.Heavy, "testAnimal1");
            Animal mediumCarnivore = new Animal(Enums.AnimalTypes.Carnivore, Enums.AnimalSize.Medium, "testAnimal2");

            bool isCompatible = heavyHerbivore.CheckifCompatible(mediumCarnivore);

            Assert.IsTrue(isCompatible);
        }

        [TestMethod()]
        public void CheckifCompatibleLightCarnivoreLightHerbivoreFalse()
        {
            Animal lightCarnivore = new Animal(Enums.AnimalTypes.Carnivore, Enums.AnimalSize.Light, "testAnimal1");
            Animal lightHerbivore = new Animal(Enums.AnimalTypes.Herbivore, Enums.AnimalSize.Light, "testAnimal2");

            bool isCompatible = lightCarnivore.CheckifCompatible(lightHerbivore);

            Assert.IsFalse(isCompatible);
        }

        [TestMethod()]
        public void CheckifCompatibleLightHerbivoreMediumHerbivoreTrue()
        {
            Animal lightHerbivore = new Animal(Enums.AnimalTypes.Herbivore, Enums.AnimalSize.Light, "testAnimal1");
            Animal mediumHerbivore = new Animal(Enums.AnimalTypes.Herbivore, Enums.AnimalSize.Medium, "testAnimal2");

            bool isCompatible = lightHerbivore.CheckifCompatible(mediumHerbivore);

            Assert.IsTrue(isCompatible);
        }

    }
}