using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductReviewManagement;
using System.Collections.Generic;


namespace TestProductReviewManagement
{
    [TestClass]
    class UnitTest2
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

    }
}
