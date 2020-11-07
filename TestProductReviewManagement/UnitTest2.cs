using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductReviewManagement;
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
            List<DataRow> actualCount = productReviewDataTable.RetrieveAllTrueIsLike();
            //Assert
            Assert.AreEqual(25, actualCount);
        }
    }
}
