using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductReviewManagement
{
    public class ReviewAdapter
    {
        public static IList<ProductReviewModel> GetTopThreeReview()
        {
            ProductReviewData reviewData = new ProductReviewData();
            var productReviews = from review in reviewData.ProductReviewList
                             orderby review.Rating descending
                             select review;
                            
            return productReviews.Take(3).ToList();
        }

        public static IList<ProductReviewModel> GetReviews_AboveSpecifiedRating_HavingGivenIds(int rating, params int[] ids)
        {
            return new List<ProductReviewModel>();
        }
    }
}
