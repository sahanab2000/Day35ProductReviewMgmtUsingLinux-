using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day35ProductReviewManagementUsingLinq
{
    public class UC5SelecttProductIDReview
    {
        public void retrieveIDReview(List<UC1ProductReview> productReviews)
        {
            //foreach (UC1ProductReview productReview in productReviews)
            //{
            //    Console.WriteLine("Product ID: "+ productReview.ProductID + " Review: " + productReview.Review);
            //}

            var records = productReviews.Select(x => new { ProductID = x.ProductID, Review = x.Review });

            foreach (var record in records)
            {
                Console.WriteLine("Product ID: " + record.ProductID + " Review: " + record.Review);
            }
        }
    }
}