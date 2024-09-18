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

            var train = new Train();

            //act
            train.FillTrain(inputAnimals);

            //assert
            // Voeg alle dieren uit elke wagon toe aan actualAnimals
            foreach (var wagon in train.Wagons)
            {
                if (wagon.Animals != null)
                {
                    actualAnimals.AddRange(wagon.Animals);
                }
            }

            Assert.AreEqual(2, train.Wagons.Count);

            CollectionAssert.AreEquivalent(inputAnimals, actualAnimals );

        }
    }
}