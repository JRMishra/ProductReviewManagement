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
