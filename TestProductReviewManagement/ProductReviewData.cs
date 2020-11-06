using System;
using System.Collections.Generic;
using System.Text;

namespace TestProductReviewManagement
{
    public class ProductReviewData
    {
        private static List<ProductReviewModel> productReviewList = new List<ProductReviewModel>();

        static ProductReviewData()
        {
            productReviewList.Add(new ProductReviewModel { ProductId = 1, UserId = 3, Rating = 7, Review = "Loved it", isLike = true });
            productReviewList.Add(new ProductReviewModel { ProductId = 8, UserId = 8, Rating = 7, Review = "Better than expectation", isLike = true });
            productReviewList.Add(new ProductReviewModel { ProductId = 2, UserId = 10, Rating = 4, Review = "Do not buy it", isLike = true });
            productReviewList.Add(new ProductReviewModel { ProductId = 10, UserId = 6, Rating = 9, Review = "Great noise cancellation quality", isLike = true });
            productReviewList.Add(new ProductReviewModel { ProductId = 2, UserId = 2, Rating = 6, Review = "Need more colour choice", isLike = true });
        
            productReviewList.Add(new ProductReviewModel { ProductId = 3, UserId = 6, Rating = 9, Review = "I recomend all to buy this", isLike = true });
            productReviewList.Add(new ProductReviewModel { ProductId = 7, UserId = 15, Rating = 5, Review = "Boycott... Boycott...", isLike = false });
            productReviewList.Add(new ProductReviewModel { ProductId = 8, UserId = 7, Rating = 8, Review = "Best piece for diwali gift", isLike = true });
            productReviewList.Add(new ProductReviewModel { ProductId = 4, UserId = 4, Rating = 5, Review = "Product is good but, service sucks", isLike = true });
            productReviewList.Add(new ProductReviewModel { ProductId = 4, UserId = 15, Rating = 9, Review = "Perfect for its purpose", isLike = true });
        
            productReviewList.Add(new ProductReviewModel { ProductId = 1, UserId = 12, Rating = 6, Review = "Great Features", isLike = true });
            productReviewList.Add(new ProductReviewModel { ProductId = 5, UserId = 11, Rating = 7, Review = "Best camera, worst Battery life", isLike = true });
            productReviewList.Add(new ProductReviewModel { ProductId = 6, UserId = 3, Rating = 6, Review = "Got a different colour than what ordered", isLike = true });
            productReviewList.Add(new ProductReviewModel { ProductId = 6, UserId = 10, Rating = 9, Review = "Worth selling my kidney", isLike = true });
            productReviewList.Add(new ProductReviewModel { ProductId = 7, UserId = 4, Rating = 2, Review = "Definition of bad product", isLike = false });
        
            productReviewList.Add(new ProductReviewModel { ProductId = 7, UserId = 13, Rating = 3, Review = "Ordered phone, got stone :/", isLike = false });
            productReviewList.Add(new ProductReviewModel { ProductId = 8, UserId = 11, Rating = 4, Review = "Got damaged product", isLike = false });
            productReviewList.Add(new ProductReviewModel { ProductId = 9, UserId = 15, Rating = 6, Review = "Buy only if budget is really low", isLike = false });
            productReviewList.Add(new ProductReviewModel { ProductId = 3, UserId = 2, Rating = 6, Review = "It's heating a lot, rest all good", isLike = true });
            productReviewList.Add(new ProductReviewModel { ProductId = 4, UserId = 1, Rating = 8, Review = "Great product, great support", isLike = true });
        
            productReviewList.Add(new ProductReviewModel { ProductId = 1, UserId = 7, Rating = 9, Review = "Really awsome product", isLike = false });
            productReviewList.Add(new ProductReviewModel { ProductId = 10, UserId = 2, Rating = 5, Review = "Not good at all", isLike = true });
            productReviewList.Add(new ProductReviewModel { ProductId = 2, UserId = 10, Rating = 7, Review = "good quality product", isLike = true });
            productReviewList.Add(new ProductReviewModel { ProductId = 10, UserId = 4, Rating = 9, Review = "Best thing I bought in Puja deal", isLike = true });
            productReviewList.Add(new ProductReviewModel { ProductId = 5, UserId = 9, Rating = 4, Review = "All that glitters isn't gold", isLike = false });
        
        }

        public ProductReviewData()
        {
        }

        public List<ProductReviewModel> ProductReviewList { get => productReviewList; }
    }
}
