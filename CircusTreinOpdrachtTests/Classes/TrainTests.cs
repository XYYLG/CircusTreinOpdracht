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
        public void FillTrainTestScenarioOne()
        {
            //arrange
            var trainTestMethods = new TrainTestMethods();
            var inputAnimals = new List<Animal>
            {
                new Animal(AnimalTypes.Herbivore, AnimalSize.Light,"HL"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Light,"HL"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Light,"HL"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Light,"HL"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Light,"HL"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Medium,"HM"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Medium,"HM"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Medium,"HM"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Heavy ,"HH"),
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

        public void FillTrainTestScenarioTwo()
        {
            var trainTestMethods = new TrainTestMethods();
            var inputAnimals = new List<Animal>
            {
                new Animal(AnimalTypes.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalTypes.Carnivore, AnimalSize.Light, "CL"),
                new Animal(AnimalTypes.Carnivore, AnimalSize.Medium, "CM"),
                new Animal(AnimalTypes.Carnivore, AnimalSize.Medium, "CM"),
                new Animal(AnimalTypes.Carnivore, AnimalSize.Medium, "CM"),
                new Animal(AnimalTypes.Carnivore, AnimalSize.Heavy, "CH"),
                new Animal(AnimalTypes.Carnivore, AnimalSize.Heavy, "CH")
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

        public void FillTrainTestScenarioThree()
        {
            var trainTestMethods = new TrainTestMethods();
            var inputAnimals = new List<Animal>
            {
                new Animal(AnimalTypes.Herbivore, AnimalSize.Light, "HL"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Light, "HL"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Light, "HL"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Light, "HL"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Light, "HL"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalTypes.Carnivore, AnimalSize.Light, "CL"),
                new Animal(AnimalTypes.Carnivore, AnimalSize.Light, "CL"),
                new Animal(AnimalTypes.Carnivore, AnimalSize.Medium, "CM"),
                new Animal(AnimalTypes.Carnivore, AnimalSize.Medium, "CM"),
                new Animal(AnimalTypes.Carnivore, AnimalSize.Heavy, "CH"),
                new Animal(AnimalTypes.Carnivore, AnimalSize.Heavy, "CH")
            };

            var actualAnimals = new List<Animal>
            {

            };


            var train = trainTestMethods.CreateTrain();

            train.FillTrain(inputAnimals);

            trainTestMethods.AddAnimalToList(train, actualAnimals);

            Assert.AreEqual(8, train.Wagons.Count);

            CollectionAssert.AreEquivalent(inputAnimals, actualAnimals);

        }

        [TestMethod]

        public void FillTrainTestScenarioFour()
        {
            var trainTestMethods = new TrainTestMethods();
            var inputAnimals = new List<Animal>
            {
                new Animal(AnimalTypes.Herbivore, AnimalSize.Light, "HL"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Heavy, "HH"),
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

        public void FillTrainTestScenarioFive()
        {
            var trainTestMethods = new TrainTestMethods();
            var inputAnimals = new List<Animal>
            {
                new Animal(AnimalTypes.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalTypes.Carnivore, AnimalSize.Light, "CL")
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

        public void FillTrainTestScenarioSix()
        {
            var trainTestMethods = new TrainTestMethods();
            var inputAnimals = new List<Animal>
            {
                new Animal(AnimalTypes.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalTypes.Carnivore, AnimalSize.Light, "CL"),
                new Animal(AnimalTypes.Carnivore, AnimalSize.Light, "CL")

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

        public void FillTrainTestScenarioSeven()
        {
            var trainTestMethods = new TrainTestMethods();
            var inputAnimals = new List<Animal>
            {
                new Animal(AnimalTypes.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalTypes.Carnivore, AnimalSize.Light, "CL"),
                new Animal(AnimalTypes.Carnivore, AnimalSize.Light, "CL")

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

        public void FillTrainTestScenarioEight()
        {
            var trainTestMethods = new TrainTestMethods();
            var inputAnimals = new List<Animal>
            {
                new Animal(AnimalTypes.Carnivore, AnimalSize.Light, "CL"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Medium, "HM"),
                
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

        public void FillTrainTestScenarioNine()
        {
            var trainTestMethods = new TrainTestMethods();
            var inputAnimals = new List<Animal>
            {
                new Animal(AnimalTypes.Carnivore, AnimalSize.Light, "CL"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Light, "HL"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Light, "HL"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Light, "HL"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Light, "HL"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Light, "HL"),
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

        public void FillTrainTestScenarioTen()
        {
            var trainTestMethods = new TrainTestMethods();
            var inputAnimals = new List<Animal>
            {
                new Animal(AnimalTypes.Carnivore, AnimalSize.Light, "CL"),
                new Animal(AnimalTypes.Carnivore, AnimalSize.Medium, "CM"),
                new Animal(AnimalTypes.Carnivore, AnimalSize.Heavy, "CH"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Light, "HL")
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

        public void FillTrainTestScenarioEleven()
        {
            var trainTestMethods = new TrainTestMethods();
            var inputAnimals = new List<Animal>
            {
                new Animal(AnimalTypes.Carnivore, AnimalSize.Light, "CL"),
                new Animal(AnimalTypes.Carnivore, AnimalSize.Medium, "CM"),
                new Animal(AnimalTypes.Carnivore, AnimalSize.Heavy, "CH"),
                new Animal(AnimalTypes.Carnivore, AnimalSize.Heavy, "CH"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Light, "HL")
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

        public void FillTrainTestScenarioTwelve()
        {
            var trainTestMethods = new TrainTestMethods();
            var inputAnimals = new List<Animal>
            {
                new Animal(AnimalTypes.Carnivore, AnimalSize.Light, "CL"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Light, "HL")
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

        public void FillTrainTestScenarioThirteen()
        {
            var trainTestMethods = new TrainTestMethods();
            var inputAnimals = new List<Animal>
            {
                new Animal(AnimalTypes.Carnivore, AnimalSize.Light, "CL"),
                new Animal(AnimalTypes.Carnivore, AnimalSize.Light, "CL"),
                new Animal(AnimalTypes.Carnivore, AnimalSize.Light, "CL"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Medium, "HM"),
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

        public void FillTrainTestScenarioFourteen()
        {
            var trainTestMethods = new TrainTestMethods();
            var inputAnimals = new List<Animal>
            {
                new Animal(AnimalTypes.Carnivore, AnimalSize.Heavy, "CH"),
                new Animal(AnimalTypes.Carnivore, AnimalSize.Heavy, "CH"),
                new Animal(AnimalTypes.Carnivore, AnimalSize.Heavy, "CH"),
                new Animal(AnimalTypes.Carnivore, AnimalSize.Medium, "CM"),
                new Animal(AnimalTypes.Carnivore, AnimalSize.Medium, "CM"),
                new Animal(AnimalTypes.Carnivore, AnimalSize.Medium, "CM"),
                new Animal(AnimalTypes.Carnivore, AnimalSize.Light, "CL"),
                new Animal(AnimalTypes.Carnivore, AnimalSize.Light, "CL"),
                new Animal(AnimalTypes.Carnivore, AnimalSize.Light, "CL"),
                new Animal(AnimalTypes.Carnivore, AnimalSize.Light, "CL"),
                new Animal(AnimalTypes.Carnivore, AnimalSize.Light, "CL"),
                new Animal(AnimalTypes.Carnivore, AnimalSize.Light, "CL"),
                new Animal(AnimalTypes.Carnivore, AnimalSize.Light, "CL"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Heavy, "HH"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Medium, "HM"),
                new Animal(AnimalTypes.Herbivore, AnimalSize.Medium, "HM")
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