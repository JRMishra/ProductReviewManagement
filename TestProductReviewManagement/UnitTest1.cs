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
            IList<ProductReviewModel> topReviewIds = new List<ProductReviewModel>();
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
            IList<ProductReviewModel> topReviewIds = new List<ProductReviewModel>();
            //Act
            topReviewIds = ReviewAdapter.GetTopThreeReview();
            //Assert
            Assert.AreEqual(10, topReviewIds[0].Rating);
            Assert.AreEqual(3, topReviewIds[0].ProductId);
        }

        [TestMethod] 
        public void GetReviews_RatingMoreThan3_ProductId3Or4Or9()
        {
            //Arrange
            ProductReviewData productReviewData = new ProductReviewData();
            IList<ProductReviewModel> reviews = new List<ProductReviewModel>();
            //Act
            reviews = ReviewAdapter.GetReviews_AboveSpecifiedRating_HavingGivenIds(3, 3, 4, 9);
            //Assert
            Assert.AreEqual(6, reviews.Count);
        }

        [TestMethod]
        public void GetReviewCount_ByProductId()
        {
            //Arrange
            ProductReviewData productReviewData = new ProductReviewData();
            Dictionary<int,int> reviews = new Dictionary<int, int>();
            //Act
            reviews = ReviewAdapter.GetReviewCountByProductId();
            //Assert
            Assert.AreEqual(3, reviews[1]);
            Assert.AreEqual(1, reviews[9]);
        }
    }
}
