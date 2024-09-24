using Microsoft.VisualStudio.TestTools.UnitTesting;
using CircusTreinOpdracht.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CircusTreinOpdracht.Enums;
using System.Security.Cryptography.X509Certificates;

namespace CircusTreinOpdracht.Classes.Tests
{
    [TestClass()]
    public class WagonTests
    {
        [TestMethod()]
        public void AddAnimalHeavyHerbivorTrue()
        {
            //Arrange
            Wagon wagon = new Wagon();
            Animal heavyHerbivore = new Animal(Enums.AnimalTypes.Herbivore, Enums.AnimalSize.Heavy, "testAnimal1");

            //Act
            bool isAdded = wagon.AddAnimal(heavyHerbivore);

            //Assert
            Assert.IsTrue(wagon.Animals.Contains(heavyHerbivore));
            Assert.AreEqual(1, wagon.Animals.Count);
            Assert.IsTrue(isAdded);
        }

        [TestMethod()]
        public void AddAnimalWagonsContainsH5AddH3True()
        {
            Wagon wagon = new Wagon();
            Animal h5 = new Animal(Enums.AnimalTypes.Herbivore, Enums.AnimalSize.Heavy, "testAnimal1");
            wagon.AddAnimal(h5);

            Animal h3 = new Animal(Enums.AnimalTypes.Herbivore, Enums.AnimalSize.Medium, "testAnimal1");

            bool isAdded = wagon.AddAnimal(h3);

            Assert.IsTrue(wagon.Animals.Contains(h3));
            Assert.AreEqual(2, wagon.Animals.Count);
            Assert.IsTrue(isAdded);
        }

        [TestMethod()]

        public void AddAnimalWagonsContainsH5H3AddH1True()
        {
            Wagon wagon = new Wagon();
            Animal h5 = new Animal(Enums.AnimalTypes.Herbivore, Enums.AnimalSize.Heavy, "testAnimal1");
            Animal h3 = new Animal(Enums.AnimalTypes.Herbivore, Enums.AnimalSize.Medium, "testAnimal2");
            wagon.AddAnimal(h5);
            wagon.AddAnimal(h3);

            Animal h1 = new Animal(Enums.AnimalTypes.Herbivore, Enums.AnimalSize.Light, "testAnimal3");

            bool isAdded = wagon.AddAnimal(h1);

            Assert.IsTrue(wagon.Animals.Contains(h1));
            Assert.AreEqual(3, wagon.Animals.Count);
            Assert.IsTrue(isAdded);
        }

        [TestMethod()]

        public void AddAnimalWagonContainsH5H3AddC1True()
        {
            Wagon wagon = new Wagon();
            Animal h5 = new Animal(Enums.AnimalTypes.Herbivore, Enums.AnimalSize.Heavy, "testAnimal1");
            Animal h3 = new Animal(Enums.AnimalTypes.Herbivore, Enums.AnimalSize.Medium, "testAnimal2");
            wagon.AddAnimal(h5);
            wagon.AddAnimal(h3);

            Animal C1 = new Animal(Enums.AnimalTypes.Carnivore, Enums.AnimalSize.Light, "testAnimal3");

            bool isAdded = wagon.AddAnimal(C1);

            Assert.IsTrue(wagon.Animals.Contains(C1));
            Assert.AreEqual(3, wagon.Animals.Count);
            Assert.IsTrue(isAdded);
        }

        [TestMethod()]
        public void AddAnimalWagonContainsH5H3AddC5False()
        {
            Wagon wagon = new Wagon();
            Animal h5 = new Animal(Enums.AnimalTypes.Herbivore, Enums.AnimalSize.Heavy, "testAnimal1");
            Animal h3 = new Animal(Enums.AnimalTypes.Herbivore, Enums.AnimalSize.Medium, "testAnimal2");
            wagon.AddAnimal(h5);
            wagon.AddAnimal(h3);

            Animal C5 = new Animal(Enums.AnimalTypes.Carnivore, Enums.AnimalSize.Heavy, "testAnimal3");

            bool isAdded = wagon.AddAnimal(C5);

            Assert.IsFalse(wagon.Animals.Contains(C5));
            Assert.AreEqual(2, wagon.Animals.Count);
            Assert.IsFalse(isAdded);
        }

        [TestMethod()]
        public void AddAnimalWagonContainsC5AddC3False()
        {
            Wagon wagon = new Wagon();
            Animal C5 = new Animal(Enums.AnimalTypes.Carnivore, Enums.AnimalSize.Heavy, "testAnimal1");
            wagon.AddAnimal(C5);

            Animal C3 = new Animal(Enums.AnimalTypes.Carnivore, Enums.AnimalSize.Medium, "testAnimal2");

            bool isAdded = wagon.AddAnimal(C3);

            Assert.IsFalse(wagon.Animals.Contains(C3));
            Assert.AreEqual(1, wagon.Animals.Count);
            Assert.IsFalse(isAdded);
        }

        [TestMethod()]
        public void AddAnimalWagonContainsC5AddH1False()
        {
            Wagon wagon = new Wagon();
            Animal C5 = new Animal(Enums.AnimalTypes.Carnivore, Enums.AnimalSize.Heavy, "testAnimal1");
            wagon.AddAnimal(C5);

            Animal H1 = new Animal(Enums.AnimalTypes.Herbivore, Enums.AnimalSize.Light, "testAnimal2");

            bool isAdded = wagon.AddAnimal(H1);

            Assert.IsFalse(wagon.Animals.Contains(H1));
            Assert.AreEqual(1, wagon.Animals.Count);
            Assert.IsFalse(isAdded);
        }
    }
}