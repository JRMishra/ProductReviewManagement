using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductReviewManagement;
using System.Collections.Generic;


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
<<<<<<< HEAD

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
||||||| 057fa8d... [JR Mishra]Add. Testcases for ninth UC

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
=======
>>>>>>> parent of 057fa8d... [JR Mishra]Add. Testcases for ninth UC
    }
}
