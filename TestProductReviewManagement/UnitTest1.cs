using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductReviewManagement;

namespace TestProductReviewManagement
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ProductReviewDataClass_WhenInstanciated_ShouldAdd25ReviewsToList()
        {
            //Arrange
            ProductReviewData productReviewData = new ProductReviewData();
            //Act
            int actualCount = productReviewData.ProductReviewList.Count;
            //Assert
            Assert.AreEqual(25, actualCount);
        }
    }
}
