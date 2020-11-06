using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductReviewManagement;
using System.Collections.Generic;

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

        [TestMethod]
        public void GetTopThreeReview_WhenCalleded_ShouldReturnThreeReviews()
        {
            //Arrange
            ProductReviewData productReviewData = new ProductReviewData();
            List<ProductReviewModel> topReviewIds = new List<ProductReviewModel>();
            //Act
            topReviewIds = ReviewAdapter.GetTopThreeReview();
            //Assert
            Assert.AreEqual(3,topReviewIds.Count);
        }

        [TestMethod]
        public void GetTopThreeReview_ShouldReturn_ThreeTopRatedReviews()
        {
            //Arrange
            ProductReviewData productReviewData = new ProductReviewData();
            List<ProductReviewModel> topReviewIds = new List<ProductReviewModel>();
            //Act
            topReviewIds = ReviewAdapter.GetTopThreeReview();
            //Assert
            Assert.AreEqual(10, topReviewIds[0].Rating);
        }
    }
}
