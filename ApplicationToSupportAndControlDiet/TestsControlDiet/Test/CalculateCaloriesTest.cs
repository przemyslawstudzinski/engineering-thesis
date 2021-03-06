﻿using ApplicationToSupportAndControlDiet.Models;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace TestsControlDiet
{
    [TestClass]
    public class CalculateCaloriesTest
    {
        private Meal mealOne;
        private Meal mealTwo;

        [TestInitialize]
        public void SetUp()
        {
            Product productOne = new Product();
            productOne.Name = "name One";
            productOne.Energy = 2500;
            Ingridient definiedProductOne = new Ingridient(productOne, 125, Measure.Gram);

            Product productTwo = new Product();
            productTwo.Name = "name Two";
            productTwo.Energy = 1400;
            Ingridient ingridientTwo = new Ingridient(productTwo, 50, Measure.Gram);

            Product productThree = new Product();
            productThree.Name = "name Three";
            productThree.Energy = 3000;
            Ingridient ingridientOne = new Ingridient(productThree, 80, Measure.Gram);

            mealOne = new Meal();
            mealOne.MealName = "mealname 1";
            mealOne.IngridientsInMeal.Add(definiedProductOne);
            mealOne.IngridientsInMeal.Add(ingridientTwo);

            mealTwo = new Meal();
            mealTwo.MealName = "mealname 2";
            mealTwo.IngridientsInMeal.Add(ingridientOne);
        }

        [TestMethod]
        public void ShouldCalculateCaloriesFromMeal()
        {
            Assert.AreEqual(3125, mealOne.IngridientsInMeal[0].Energy);
            Assert.AreEqual(700, mealOne.IngridientsInMeal[1].Energy);
            Assert.AreEqual(3825, mealOne.Energy, "Calculated calories from two products in one meal should be equal to 3825");
            Assert.AreEqual(2400, mealTwo.Energy, "Calculated calories from two products in one meal should be equal to 2400");
        }

        [TestMethod]
        public void ShouldCalculateCaloriesFromDay()
        {
            Day day = new Day();
            day.MealsInDay.Add(mealOne);
            day.MealsInDay.Add(mealTwo);
            Assert.AreEqual(6225, day.Energy, "Calculated calories from both meals in one day should be equal to 6000");
        }
    }
}