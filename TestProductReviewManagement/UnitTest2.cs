using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductReviewManagement;
using System;
using System.Collections.Generic;
using System.Data;

namespace TestProductReviewManagement
{
    [TestClass]
    public class UnitTest2
    {
        /// <summary>
        /// When product review table is created,
        /// it should add 25 records to a data table
        /// </summary>
        [TestMethod]
        public void ProductReviewDataTable_WhenCreated_ShouldAdd25Reviews()
        {
            //Arrange
            ProductReviewDataTable productReviewDataTable = new ProductReviewDataTable();
            //Act
            int actualCount = productReviewDataTable.dataTableStorage.Rows.Count;
            //Assert
            Assert.AreEqual(25, actualCount);
        }

        /// <summary>
        /// Test method which returns all records with IsLike as true
        /// </summary>
        [TestMethod]
        public void RetrieveAllTrueIsLike_ShouldReturn_RecordsWithIsLikeTrue()
        {
            //Arrange
            ProductReviewDataTable productReviewDataTable = new ProductReviewDataTable();
            //Act
            int actualCount = productReviewDataTable.RetrieveAllTrueIsLike().Count;
            //Assert
            Assert.AreEqual(18, actualCount);
        }

        /// <summary>
        /// Test method that returns average rating of products by product id
        /// </summary>
        [TestMethod]
        public void Test_AvgRatingOfProductsMethod()
        { 
            //Arrange
            ProductReviewDataTable productReviewDataTable = new ProductReviewDataTable();
            //Act
            Dictionary<int,double> result = productReviewDataTable.AvgRatingOfProducts();
            //Assert
            Assert.AreEqual(7.33, Math.Round(result[1],2));
        }

        /// <summary>
        /// Test method that filters records by specific keyword in review
        /// </summary>
        [TestMethod]
        public void Test_FilterReviewsByKeywordMethod()
        {
            //Arrange
            ProductReviewDataTable productReviewDataTable = new ProductReviewDataTable();
            //Act
            List<DataRow> result = productReviewDataTable.FilterReviewsByKeyword("nice");
            //Assert
            Assert.AreEqual(3, result.Count);
        }

        /// <summary>
        /// Test method that returns
        /// records ordered by rating for given product id
        /// </summary>
        [TestMethod]
        public void TestMethod_WhenCalledShould_RetrieveRecordsOrderedByRating()
        {
            //Arrange
            ProductReviewDataTable productReviewDataTable = new ProductReviewDataTable();
            //Act
            List<DataRow> result = productReviewDataTable.OrderedRecordsForGivenId(10);
            //Assert
            Assert.AreEqual("Great noise cancellation quality", result[0].Field<string>("Review"));
        }
    }
}
