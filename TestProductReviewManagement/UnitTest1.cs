using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductReviewManagement;
using System.Collections.Generic;

namespace TestProductReviewManagement
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// ProductReviewData Class should add 25 records when instansiated
        /// </summary>
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

        /// <summary>
        /// Test method that should return top 3 records by rating
        /// </summary>
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

        /// <summary>
        /// Test TopThreeReview method should have top rated at first
        /// </summary>
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

        /// <summary>
        /// Test method that have rating more than specified rating
        /// having product id among specified ids
        /// </summary>
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

        /// <summary>
        /// Test method that should return count by product id
        /// </summary>
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

        /// <summary>
        /// Test method that retrieve list of reviews by product Id
        /// </summary>
        [TestMethod]
        public void GetAllIdAndReview_ShouldReturn_DictWithIdAndReviewList()
        {
            //Arrange
            ProductReviewData productReviewData = new ProductReviewData();
            Dictionary<int, List<string>> reviews = new Dictionary<int, List<string>>();
            //Act
            reviews = ReviewAdapter.GetAllIdAndReviews(); 
            //Assert
            Assert.AreEqual(10, reviews.Keys.Count);
            Assert.AreEqual(3, reviews[1].Count);
        }

        /// <summary>
        /// Test method that returns records except specified number of records from top 
        /// </summary>
        [TestMethod]
        public void GetAllReportExceptTop_ShouldReturnAll_ExceptSpecifiedNumberOfTopRecord()
        {
            //Arrange
            ProductReviewData productReviewData = new ProductReviewData();
           List<ProductReviewModel> reviews = new List<ProductReviewModel>();
            //Act
            reviews = ReviewAdapter.GetAllReportExceptTops(5);
            //Assert
            Assert.AreEqual(20, reviews.Count);
            Assert.AreNotEqual(3, reviews[0].ProductId);
        }
    }
}
