using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace ProductReviewManagement
{
    public class ProductReviewDataTable
    {
        public DataTable dataTableStorage = new DataTable();

        public ProductReviewDataTable()
        {
            dataTableStorage.Columns.Add("ProductId", typeof(int));
            dataTableStorage.Columns.Add("UserId", typeof(int));
            dataTableStorage.Columns.Add("Rating", typeof(int));
            dataTableStorage.Columns.Add("Review", typeof(string));
            dataTableStorage.Columns.Add("IsLike", typeof(bool));

            dataTableStorage.Rows.Add(1, 3, 7, "Loved it", true);
            dataTableStorage.Rows.Add(8, 8, 7, "Better than expectation", true);
            dataTableStorage.Rows.Add(2, 10, 4, "Do not buy it", true);
            dataTableStorage.Rows.Add(10, 6, 9, "Great noise cancellation quality", true);
            dataTableStorage.Rows.Add(2, 2, 6, "Need more colour choice", true);

            dataTableStorage.Rows.Add(3, 6, 10, "I recomend all to buy this", true);
            dataTableStorage.Rows.Add(7, 15, 5, "Boycott... Boycott...", false);
            dataTableStorage.Rows.Add(8, 7, 8, "Best piece for diwali gift", true);
            dataTableStorage.Rows.Add(4, 4, 5, "Product is really nice but, service sucks", true);
            dataTableStorage.Rows.Add(4, 15, 9, "Perfect for its purpose", true);

            dataTableStorage.Rows.Add(1, 12, 6, "Nicely integrated Features", true);
            dataTableStorage.Rows.Add(5, 11, 7, "Best camera, worst Battery life", true);
            dataTableStorage.Rows.Add(6, 3, 6, "Got a different colour than what ordered", true);
            dataTableStorage.Rows.Add(6, 10, 9, "Worth selling my kidney", true);
            dataTableStorage.Rows.Add(7, 4, 2, "Definition of bad product", false);

            dataTableStorage.Rows.Add(7, 13, 3, "Ordered phone, got stone :/", false);
            dataTableStorage.Rows.Add(8, 11, 4, "Got damaged product", false);
            dataTableStorage.Rows.Add(9, 15, 6, "Buy only if budget is really low", false);
            dataTableStorage.Rows.Add(3, 2, 6, "It's heating a lot, rest all good", true);
            dataTableStorage.Rows.Add(4, 1, 8, "Great product, great support", true);

            dataTableStorage.Rows.Add(1, 7, 9, "Really nice product", false);
            dataTableStorage.Rows.Add(10, 2, 5, "Not good at all", true);
            dataTableStorage.Rows.Add(2, 10, 7, "good quality product", true);
            dataTableStorage.Rows.Add(10, 4, 9, "Best thing I bought in Puja deal", true);
            dataTableStorage.Rows.Add(5, 9, 4, "All that glitters isn't gold", false);

        }

        public List<DataRow> RetrieveAllTrueIsLike()
        {
            List<DataRow> result = (from data in dataTableStorage.AsEnumerable()
                                    where data.Field<bool>("IsLike") == true
                                    select data).ToList();
            return result;
        }

        public Dictionary<int, double> AvgRatingOfProducts()
        {
            var result = (from data in dataTableStorage.AsEnumerable()
                          group data by data.Field<int>("ProductId"))
                          .ToDictionary( d => d.Key, d => d.Average(x => x.Field<int>("Rating")));
                          
            return result;
        }

        public List<DataRow> FilterReviewsByKeyword()
        {
            throw new NotImplementedException();
        }
    }
}
