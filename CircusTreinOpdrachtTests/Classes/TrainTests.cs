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
            var inputAnimals = new List<Animal>();
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(5, AnimalSize.Light, AnimalType.Herbivore));
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(3, AnimalSize.Medium, AnimalType.Herbivore));
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(1, AnimalSize.Heavy, AnimalType.Herbivore));

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
            var inputAnimals = new List<Animal>();
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(1, AnimalSize.Light, AnimalType.Carnivore));
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(3, AnimalSize.Medium, AnimalType.Carnivore));
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(3, AnimalSize.Heavy, AnimalType.Herbivore));
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(2, AnimalSize.Heavy, AnimalType.Carnivore));

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
            var inputAnimals = new List<Animal>();
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(5, AnimalSize.Light, AnimalType.Herbivore));
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(5, AnimalSize.Medium, AnimalType.Herbivore));
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(5, AnimalSize.Heavy, AnimalType.Herbivore));
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(2, AnimalSize.Light, AnimalType.Carnivore));
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(2, AnimalSize.Medium, AnimalType.Carnivore));
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(2, AnimalSize.Heavy, AnimalType.Carnivore));

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
            var inputAnimals = new List<Animal>();
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(1, AnimalSize.Light, AnimalType.Herbivore));
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(3, AnimalSize.Medium, AnimalType.Herbivore));
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(2, AnimalSize.Heavy, AnimalType.Herbivore));

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
            var inputAnimals = new List<Animal>();
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(3, AnimalSize.Medium, AnimalType.Herbivore));
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(2, AnimalSize.Heavy, AnimalType.Herbivore));
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(1, AnimalSize.Light, AnimalType.Carnivore));

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
            var inputAnimals = new List<Animal>();
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(2, AnimalSize.Medium, AnimalType.Herbivore));
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(2, AnimalSize.Heavy, AnimalType.Herbivore));
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(2, AnimalSize.Light, AnimalType.Carnivore));

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
            var inputAnimals = new List<Animal>();
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(6, AnimalSize.Medium, AnimalType.Herbivore));
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(2, AnimalSize.Heavy, AnimalType.Herbivore));
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(2, AnimalSize.Light, AnimalType.Carnivore));

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
            var inputAnimals = new List<Animal>();
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(1, AnimalSize.Light, AnimalType.Carnivore));
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(3, AnimalSize.Medium, AnimalType.Herbivore));
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(2, AnimalSize.Heavy, AnimalType.Herbivore));

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
            var inputAnimals = new List<Animal>();
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(1, AnimalSize.Light, AnimalType.Carnivore));
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(1, AnimalSize.Heavy, AnimalType.Herbivore));
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(2, AnimalSize.Medium, AnimalType.Herbivore));
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(5, AnimalSize.Light, AnimalType.Herbivore));

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
            var inputAnimals = new List<Animal>();
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(1, AnimalSize.Light, AnimalType.Carnivore));
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(1, AnimalSize.Medium, AnimalType.Carnivore));
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(1, AnimalSize.Heavy, AnimalType.Carnivore));
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(1, AnimalSize.Heavy, AnimalType.Herbivore));
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(1, AnimalSize.Medium, AnimalType.Herbivore));
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(1, AnimalSize.Light, AnimalType.Herbivore));

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
            var inputAnimals = new List<Animal>();
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(1, AnimalSize.Light, AnimalType.Carnivore));
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(1, AnimalSize.Medium, AnimalType.Carnivore));
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(2, AnimalSize.Heavy, AnimalType.Carnivore));
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(1, AnimalSize.Heavy, AnimalType.Herbivore));
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(5, AnimalSize.Medium, AnimalType.Herbivore));
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(1, AnimalSize.Light, AnimalType.Herbivore));

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
            var inputAnimals = new List<Animal>();
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(1, AnimalSize.Light, AnimalType.Carnivore));
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(2, AnimalSize.Heavy, AnimalType.Herbivore));
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(1, AnimalSize.Medium, AnimalType.Herbivore));
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(1, AnimalSize.Light, AnimalType.Herbivore));

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
            var inputAnimals = new List<Animal>();
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(3, AnimalSize.Light, AnimalType.Carnivore));
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(3, AnimalSize.Heavy, AnimalType.Herbivore));
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(2, AnimalSize.Medium, AnimalType.Herbivore));

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
            var inputAnimals = new List<Animal>();
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(3, AnimalSize.Heavy, AnimalType.Carnivore));
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(3, AnimalSize.Medium, AnimalType.Carnivore));
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(7, AnimalSize.Light, AnimalType.Carnivore));
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(6, AnimalSize.Heavy, AnimalType.Herbivore));
            inputAnimals.AddRange(AnimalFactory.CreateAnimals(5, AnimalSize.Medium, AnimalType.Herbivore));

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