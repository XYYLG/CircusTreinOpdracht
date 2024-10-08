using Microsoft.VisualStudio.TestTools.UnitTesting;
using CircusTreinOpdracht.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CircusTreinOpdracht.Enums;

namespace CircusTreinOpdracht.Classes.Tests
{
    [TestClass()]
    public class TrainTests
    {
        [TestMethod()]
        public void FillTrainTest_ScenarioOne()
        {
            //arrange
            var trainTestMethods = new TrainTestMethods();
            var inputAnimals = new List<Animal>
            {
                new Animal(AnimalType.Herbivore, AnimalSize.Light,"HL"),
                new Animal(AnimalType.Herbivore, AnimalSize.Light,"HL"),
                new Animal(AnimalType.Herbivore, AnimalSize.Light,"HL"),
                new Animal(AnimalType.Herbivore, AnimalSize.Light,"HL"),
                new Animal(AnimalType.Herbivore, AnimalSize.Light,"HL"),
                new Animal(AnimalType.Herbivore, AnimalSize.Medium,"HM"),
                new Animal(AnimalType.Herbivore, AnimalSize.Medium,"HM"),
                new Animal(AnimalType.Herbivore, AnimalSize.Medium,"HM"),
                new Animal(AnimalType.Herbivore, AnimalSize.Heavy ,"HH"),
            };

            var actualAnimals = new List<Animal>
            {
            
            };

            var train = trainTestMethods.CreateTrain();

            //act
            train.FillTrain(inputAnimals);

            //assert

            // Voeg alle dieren uit elke wagon toe aan actualAnimals
            trainTestMethods.AddAnimalToList(train, actualAnimals);

            Assert.AreEqual(2, train.Wagons.Count);

            CollectionAssert.AreEquivalent(inputAnimals, actualAnimals );
        }

        [TestMethod]

        public void FillTrainTest_ScenarioTwo()
        {
            var trainTestMethods = new TrainTestMethods();
            var inputAnimals = new List<Animal>
            {
                new Animal(AnimalType.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalType.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalType.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalType.Carnivore, AnimalSize.Light, "CL"),
                new Animal(AnimalType.Carnivore, AnimalSize.Medium, "CM"),
                new Animal(AnimalType.Carnivore, AnimalSize.Medium, "CM"),
                new Animal(AnimalType.Carnivore, AnimalSize.Medium, "CM"),
                new Animal(AnimalType.Carnivore, AnimalSize.Heavy, "CH"),
                new Animal(AnimalType.Carnivore, AnimalSize.Heavy, "CH")
            };

            var actualAnimals = new List<Animal>
            {

            };

            var train = trainTestMethods.CreateTrain();

            train.FillTrain(inputAnimals);

            // Voeg alle dieren uit elke wagon toe aan actualAnimals
            trainTestMethods.AddAnimalToList(train, actualAnimals);

            Assert.AreEqual(6, train.Wagons.Count);

            CollectionAssert.AreEquivalent(inputAnimals, actualAnimals);
        }

        [TestMethod]

        public void FillTrainTest_ScenarioThree()
        {
            var trainTestMethods = new TrainTestMethods();

            // List<Animal> animals = new List<Animal>();
            // animals.AddRange(AnimalFactory.CreateAnimals(5, AnimalSize.Light, ....));
            // animals.AddRange(AnimalFactory.CreateAnimals(5, AnimalSize.Medium));
            // animals.AddRange(AnimalFactory.CreateAnimals(5, AnimalSize.Heavy));
            // animals.AddRange(AnimalFactory.CreateAnimals(5, AnimalSize.Light));

            var inputAnimals = new List<Animal>
            {
                new Animal(AnimalType.Herbivore, AnimalSize.Light, "HL"),
                new Animal(AnimalType.Herbivore, AnimalSize.Light, "HL"),
                new Animal(AnimalType.Herbivore, AnimalSize.Light, "HL"),
                new Animal(AnimalType.Herbivore, AnimalSize.Light, "HL"),
                new Animal(AnimalType.Herbivore, AnimalSize.Light, "HL"),
                new Animal(AnimalType.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalType.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalType.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalType.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalType.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalType.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalType.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalType.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalType.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalType.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalType.Carnivore, AnimalSize.Light, "CL"),
                new Animal(AnimalType.Carnivore, AnimalSize.Light, "CL"),
                new Animal(AnimalType.Carnivore, AnimalSize.Medium, "CM"),
                new Animal(AnimalType.Carnivore, AnimalSize.Medium, "CM"),
                new Animal(AnimalType.Carnivore, AnimalSize.Heavy, "CH"),
                new Animal(AnimalType.Carnivore, AnimalSize.Heavy, "CH")
            };

            var actualAnimals = new List<Animal>
            {

            };


            var train = trainTestMethods.CreateTrain();

            //Act
            train.FillTrain(inputAnimals);

            trainTestMethods.AddAnimalToList(train, actualAnimals);

            //Assert
            Assert.AreEqual(8, train.Wagons.Count);

            CollectionAssert.AreEquivalent(inputAnimals, actualAnimals); //comparing collections where order is not important
        }

        [TestMethod]

        public void FillTrainTest_ScenarioFour()
        {
            var trainTestMethods = new TrainTestMethods();
            var inputAnimals = new List<Animal>
            {
                new Animal(AnimalType.Herbivore, AnimalSize.Light, "HL"),
                new Animal(AnimalType.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalType.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalType.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalType.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalType.Herbivore, AnimalSize.Heavy, "HH"),
            };

            var actualAnimals = new List<Animal>
            {

            };


            var train = trainTestMethods.CreateTrain();

            train.FillTrain(inputAnimals);

            trainTestMethods.AddAnimalToList(train, actualAnimals);

            Assert.AreEqual(2, train.Wagons.Count);

            CollectionAssert.AreEquivalent(inputAnimals, actualAnimals);
        }

        [TestMethod]

        public void FillTrainTest_ScenarioFive()
        {
            var trainTestMethods = new TrainTestMethods();
            var inputAnimals = new List<Animal>
            {
                new Animal(AnimalType.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalType.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalType.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalType.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalType.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalType.Carnivore, AnimalSize.Light, "CL")
            };

            var actualAnimals = new List<Animal>
            {

            };


            var train = trainTestMethods.CreateTrain();

            train.FillTrain(inputAnimals);

            trainTestMethods.AddAnimalToList(train, actualAnimals);

            Assert.AreEqual(2, train.Wagons.Count);

            CollectionAssert.AreEquivalent(inputAnimals, actualAnimals);

        }

        [TestMethod]

        public void FillTrainTest_ScenarioSix()
        {
            var trainTestMethods = new TrainTestMethods();
            var inputAnimals = new List<Animal>
            {
                new Animal(AnimalType.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalType.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalType.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalType.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalType.Carnivore, AnimalSize.Light, "CL"),
                new Animal(AnimalType.Carnivore, AnimalSize.Light, "CL")

            };

            var actualAnimals = new List<Animal>
            {

            };


            var train = trainTestMethods.CreateTrain();

            train.FillTrain(inputAnimals);

            trainTestMethods.AddAnimalToList(train, actualAnimals);

            Assert.AreEqual(2, train.Wagons.Count);

            CollectionAssert.AreEquivalent(inputAnimals, actualAnimals);
        }

        [TestMethod]

        public void FillTrainTest_ScenarioSeven()
        {
            var trainTestMethods = new TrainTestMethods();
            var inputAnimals = new List<Animal>
            {
                new Animal(AnimalType.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalType.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalType.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalType.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalType.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalType.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalType.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalType.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalType.Carnivore, AnimalSize.Light, "CL"),
                new Animal(AnimalType.Carnivore, AnimalSize.Light, "CL")

            };

            var actualAnimals = new List<Animal>
            {

            };


            var train = trainTestMethods.CreateTrain();

            train.FillTrain(inputAnimals);

            trainTestMethods.AddAnimalToList(train, actualAnimals);

            Assert.AreEqual(3, train.Wagons.Count);

            CollectionAssert.AreEquivalent(inputAnimals, actualAnimals);

        }

        [TestMethod]

        public void FillTrainTest_ScenarioEight()
        {
            var trainTestMethods = new TrainTestMethods();
            var inputAnimals = new List<Animal>
            {
                new Animal(AnimalType.Carnivore, AnimalSize.Light, "CL"),
                new Animal(AnimalType.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalType.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalType.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalType.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalType.Herbivore, AnimalSize.Medium, "HM"),
                
            };

            var actualAnimals = new List<Animal>
            {

            };


            var train = trainTestMethods.CreateTrain();

            train.FillTrain(inputAnimals);

            trainTestMethods.AddAnimalToList(train, actualAnimals);

            Assert.AreEqual(2, train.Wagons.Count);

            CollectionAssert.AreEquivalent(inputAnimals, actualAnimals);

        }

        [TestMethod]

        public void FillTrainTest_ScenarioNine()
        {
            var trainTestMethods = new TrainTestMethods();
            var inputAnimals = new List<Animal>
            {
                new Animal(AnimalType.Carnivore, AnimalSize.Light, "CL"),
                new Animal(AnimalType.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalType.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalType.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalType.Herbivore, AnimalSize.Light, "HL"),
                new Animal(AnimalType.Herbivore, AnimalSize.Light, "HL"),
                new Animal(AnimalType.Herbivore, AnimalSize.Light, "HL"),
                new Animal(AnimalType.Herbivore, AnimalSize.Light, "HL"),
                new Animal(AnimalType.Herbivore, AnimalSize.Light, "HL"),
            };

            var actualAnimals = new List<Animal>
            {

            };


            var train = trainTestMethods.CreateTrain();

            train.FillTrain(inputAnimals);

            trainTestMethods.AddAnimalToList(train, actualAnimals);

            Assert.AreEqual(2, train.Wagons.Count);

            CollectionAssert.AreEquivalent(inputAnimals, actualAnimals);
        }

        [TestMethod]

        public void FillTrainTest_ScenarioTen()
        {
            var trainTestMethods = new TrainTestMethods();
            var inputAnimals = new List<Animal>
            {
                new Animal(AnimalType.Carnivore, AnimalSize.Light, "CL"),
                new Animal(AnimalType.Carnivore, AnimalSize.Medium, "CM"),
                new Animal(AnimalType.Carnivore, AnimalSize.Heavy, "CH"),
                new Animal(AnimalType.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalType.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalType.Herbivore, AnimalSize.Light, "HL")
            };

            var actualAnimals = new List<Animal>
            {

            };

            var train = trainTestMethods.CreateTrain();

            train.FillTrain(inputAnimals);

            trainTestMethods.AddAnimalToList(train, actualAnimals);

            Assert.AreEqual(4, train.Wagons.Count);

            CollectionAssert.AreEquivalent(inputAnimals, actualAnimals);

        }

        [TestMethod]

        public void FillTrainTest_ScenarioEleven()
        {
            var trainTestMethods = new TrainTestMethods();
            var inputAnimals = new List<Animal>
            {
                new Animal(AnimalType.Carnivore, AnimalSize.Light, "CL"),
                new Animal(AnimalType.Carnivore, AnimalSize.Medium, "CM"),
                new Animal(AnimalType.Carnivore, AnimalSize.Heavy, "CH"),
                new Animal(AnimalType.Carnivore, AnimalSize.Heavy, "CH"),
                new Animal(AnimalType.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalType.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalType.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalType.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalType.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalType.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalType.Herbivore, AnimalSize.Light, "HL")
            };

            var actualAnimals = new List<Animal>
            {

            };

            var train = trainTestMethods.CreateTrain();

            train.FillTrain(inputAnimals);

            trainTestMethods.AddAnimalToList(train, actualAnimals);

            Assert.AreEqual(5, train.Wagons.Count);

            CollectionAssert.AreEquivalent(inputAnimals, actualAnimals);

        }

        [TestMethod]

        public void FillTrainTest_ScenarioTwelve()
        {
            var trainTestMethods = new TrainTestMethods();
            var inputAnimals = new List<Animal>
            {
                new Animal(AnimalType.Carnivore, AnimalSize.Light, "CL"),
                new Animal(AnimalType.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalType.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalType.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalType.Herbivore, AnimalSize.Light, "HL")
            };

            var actualAnimals = new List<Animal>
            {

            };

            var train = trainTestMethods.CreateTrain();

            train.FillTrain(inputAnimals);

            trainTestMethods.AddAnimalToList(train, actualAnimals);

            Assert.AreEqual(2, train.Wagons.Count);

            CollectionAssert.AreEquivalent(inputAnimals, actualAnimals);

        }

        [TestMethod]

        public void FillTrainTest_ScenarioThirteen()
        {
            var trainTestMethods = new TrainTestMethods();
            var inputAnimals = new List<Animal>
            {
                new Animal(AnimalType.Carnivore, AnimalSize.Light, "CL"),
                new Animal(AnimalType.Carnivore, AnimalSize.Light, "CL"),
                new Animal(AnimalType.Carnivore, AnimalSize.Light, "CL"),
                new Animal(AnimalType.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalType.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalType.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalType.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalType.Herbivore, AnimalSize.Medium, "HM"),
            };

            var actualAnimals = new List<Animal>
            {

            };

            var train = trainTestMethods.CreateTrain();

            train.FillTrain(inputAnimals);

            trainTestMethods.AddAnimalToList(train, actualAnimals);

            Assert.AreEqual(3, train.Wagons.Count);

            CollectionAssert.AreEquivalent(inputAnimals, actualAnimals);

        }

        [TestMethod]

        public void FillTrainTest_ScenarioFourteen()
        {
            var trainTestMethods = new TrainTestMethods();
            var inputAnimals = new List<Animal>
            {
                new Animal(AnimalType.Carnivore, AnimalSize.Heavy, "CH"),
                new Animal(AnimalType.Carnivore, AnimalSize.Heavy, "CH"),
                new Animal(AnimalType.Carnivore, AnimalSize.Heavy, "CH"),
                new Animal(AnimalType.Carnivore, AnimalSize.Medium, "CM"),
                new Animal(AnimalType.Carnivore, AnimalSize.Medium, "CM"),
                new Animal(AnimalType.Carnivore, AnimalSize.Medium, "CM"),
                new Animal(AnimalType.Carnivore, AnimalSize.Light, "CL"),
                new Animal(AnimalType.Carnivore, AnimalSize.Light, "CL"),
                new Animal(AnimalType.Carnivore, AnimalSize.Light, "CL"),
                new Animal(AnimalType.Carnivore, AnimalSize.Light, "CL"),
                new Animal(AnimalType.Carnivore, AnimalSize.Light, "CL"),
                new Animal(AnimalType.Carnivore, AnimalSize.Light, "CL"),
                new Animal(AnimalType.Carnivore, AnimalSize.Light, "CL"),
                new Animal(AnimalType.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalType.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalType.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalType.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalType.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalType.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalType.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalType.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalType.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalType.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalType.Herbivore, AnimalSize.Medium, "HM")
            };

            var actualAnimals = new List<Animal>
            {

            };

            var train = trainTestMethods.CreateTrain();

            train.FillTrain(inputAnimals);

            trainTestMethods.AddAnimalToList(train, actualAnimals);

            Assert.AreEqual(13, train.Wagons.Count);

            CollectionAssert.AreEquivalent(inputAnimals, actualAnimals);

        }

    }
}