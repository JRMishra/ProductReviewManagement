using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductReviewManagement
{
    public class ReviewAdapter
    {
        /// <summary>
        /// Retrieve top three records by rating
        /// </summary>
        /// <returns>top 3 records</returns>
        public static IList<ProductReviewModel> GetTopThreeReview()
        {
            ProductReviewData reviewData = new ProductReviewData();
            var productReviews = from review in reviewData.ProductReviewList
                             orderby review.Rating descending
                             select review;
                            
            return productReviews.Take(3).ToList();
        }

        /// <summary>
        /// Retrieve records with rating above a specified rating and product id with in mentioned Ids
        /// </summary>
        /// <param name="rating">product rating</param>
        /// <param name="ids">specified product ids</param>
        /// <returns>retrieved record</returns>
        public static IList<ProductReviewModel> GetReviews_AboveSpecifiedRating_HavingGivenIds(int rating, params int[] ids)
        {
            ProductReviewData reviewData = new ProductReviewData();
            var productReviews = (from review in reviewData.ProductReviewList
                                 where review.Rating > 3
                                 select review);

            List<ProductReviewModel> finalProductReview = new List<ProductReviewModel>();
            foreach(int id in ids)
            {
                var products = (from review in productReviews
                                where review.ProductId == id
                                select review);
                finalProductReview.AddRange(products.ToList());
            }
            return finalProductReview;
        }

        /// <summary>
        /// Return count of reviews for all products
        /// </summary>
        /// <returns>Dictionary: Key - Product Key, Value - Review counts</returns>
        public static Dictionary<int,int> GetReviewCountByProductId()
        {
            ProductReviewData reviewData = new ProductReviewData();
            var result = (from review in reviewData.ProductReviewList
                          group review by review.ProductId)
                         .ToDictionary(r => r.Key, r => r.Count());

            return result;
        }

        /// <summary>
        /// retrieve list of reviews aggregated by product id
        /// </summary>
        /// <returns>Dictionary: Key - Product Id, Value - Review list</returns>
        public static Dictionary<int, List<string>> GetAllIdAndReviews()
        {
            ProductReviewData reviewData = new ProductReviewData();
            
            var result = (from review in reviewData.ProductReviewList
                          group review.Review by review.ProductId)
                         .ToDictionary(r => r.Key, r => r.ToList() );
            return result;
        }

        /// <summary>
        /// Retrieve all records except specified top records by rating
        /// </summary>
        /// <param name="n">number of top records to skip</param>
        /// <returns>list of retrieved data rows</returns>
        public static List<ProductReviewModel> GetAllReportExceptTops(int n)
        {
            ProductReviewData reviewData = new ProductReviewData();
            var productReviews = (from review in reviewData.ProductReviewList
                                 orderby review.Rating descending
                                 select review).TakeLast(reviewData.ProductReviewList.Count- n);

            return productReviews.ToList();
        }

    }
}
