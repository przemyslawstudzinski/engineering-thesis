﻿using ApplicationToSupportAndControlDiet.Models;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace TestsControlDiet.Test
{
    [TestClass]
    public class MeasureServiceTest
    {
        private const double GRAM_OF_PRODUCT_IN_DB = 100;
        private Product product;

        [TestInitialize]
        public void SetUp()
        {
            product = new Product();
            product.Energy = 1000;
            product.Fat = 10;
            product.Fiber = 10;
            product.Protein = 10;
            product.Sugar = 10;
            product.Carbohydrate = 10;
            product.Name = "product1";
            product.WeightInTeaspoon = 5;
        }

        [TestMethod]
        public void ShouldCalculateValuesWithMeasureGramTest()
        {
            Ingridient definiedProduct = new Ingridient(product, 200, Measure.Gram);
            Assert.AreEqual((int) definiedProduct.Energy, (int) (2 * product.Energy));
            Assert.AreEqual((int) definiedProduct.Protein, (int) (2 * product.Protein));
            Assert.AreEqual((int) definiedProduct.Fat, (int) (2 * product.Fat));
            Assert.AreEqual((int) definiedProduct.Sugar, (int) (2 * product.Sugar));
            Assert.AreEqual((int) definiedProduct.Carbohydrate, (int) (2 * product.Carbohydrate));
            Assert.AreEqual((int) definiedProduct.Fiber, (int) (2 * product.Fiber));
        }

        [TestMethod]
        public void ShouldCalculateValuesWithMeasureTeaspoonTest()
        {
            Ingridient definiedProduct = new Ingridient(product, 2, Measure.Teaspoon);
            Assert.AreEqual((int) definiedProduct.Energy, (int) ((product.Energy / GRAM_OF_PRODUCT_IN_DB) * 2 * product.WeightInTeaspoon));
            Assert.AreEqual((int) definiedProduct.Protein, (int) ((product.Protein / GRAM_OF_PRODUCT_IN_DB) * 2 * product.WeightInTeaspoon));
            Assert.AreEqual((int) definiedProduct.Fiber, (int) ((product.Fiber / GRAM_OF_PRODUCT_IN_DB) * 2 * product.WeightInTeaspoon));
            Assert.AreEqual((int) definiedProduct.Fat, (int) ((product.Fat / GRAM_OF_PRODUCT_IN_DB) * 2 * product.WeightInTeaspoon));
            Assert.AreEqual((int) definiedProduct.Carbohydrate, (int) ((product.Carbohydrate / GRAM_OF_PRODUCT_IN_DB) * 2 * product.WeightInTeaspoon));       
            Assert.AreEqual((int) definiedProduct.Sugar, (int) ((product.Sugar / GRAM_OF_PRODUCT_IN_DB) * 2 * product.WeightInTeaspoon));
        }

        [TestMethod]
        public void ShouldCalculateValuesWithMeasureSpoonTest()
        {
            Ingridient definiedProduct = new Ingridient(product, 2, Measure.Spoon);
            Assert.AreEqual((int) definiedProduct.Energy, (int) ((product.Energy / GRAM_OF_PRODUCT_IN_DB) * 6 * product.WeightInTeaspoon));
            Assert.AreEqual((int) definiedProduct.Protein, (int) ((product.Protein / GRAM_OF_PRODUCT_IN_DB) * 6 * product.WeightInTeaspoon));
            Assert.AreEqual((int) definiedProduct.Fat, (int) ((product.Fat / GRAM_OF_PRODUCT_IN_DB) * 6 * product.WeightInTeaspoon));
            Assert.AreEqual((int) definiedProduct.Carbohydrate, (int) ((product.Carbohydrate / GRAM_OF_PRODUCT_IN_DB) * 6 * product.WeightInTeaspoon));
            Assert.AreEqual((int) definiedProduct.Sugar, (int) ((product.Sugar / GRAM_OF_PRODUCT_IN_DB) * 6 * product.WeightInTeaspoon));
            Assert.AreEqual((int) definiedProduct.Fiber, (int) ((product.Fiber / GRAM_OF_PRODUCT_IN_DB) * 6 * product.WeightInTeaspoon));
        }

        [TestMethod]
        public void ShouldCalculateValuesWithMeasureGlassTest()
        {
            Ingridient definiedProduct = new Ingridient(product, 1, Measure.Glass);
            Assert.AreEqual((int) definiedProduct.Energy, (int) ((product.Energy / GRAM_OF_PRODUCT_IN_DB) * 16 * 3 * product.WeightInTeaspoon));
            Assert.AreEqual((int) definiedProduct.Protein, (int) ((product.Protein / GRAM_OF_PRODUCT_IN_DB) * 16 * 3 * product.WeightInTeaspoon));
            Assert.AreEqual((int) definiedProduct.Sugar, (int) ((product.Sugar / GRAM_OF_PRODUCT_IN_DB) * 16 * 3 * product.WeightInTeaspoon));
            Assert.AreEqual((int) definiedProduct.Fiber, (int) ((product.Fiber / GRAM_OF_PRODUCT_IN_DB) * 16 * 3 * product.WeightInTeaspoon));
            Assert.AreEqual((int) definiedProduct.Fat, (int) ((product.Fat / GRAM_OF_PRODUCT_IN_DB) * 16 * 3 * product.WeightInTeaspoon));
            Assert.AreEqual((int) definiedProduct.Carbohydrate, (int) ((product.Carbohydrate / GRAM_OF_PRODUCT_IN_DB) * 16 * 3 * product.WeightInTeaspoon));
        }
    }
}