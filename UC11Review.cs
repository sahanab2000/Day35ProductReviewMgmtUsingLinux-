using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day35ProductReviewManagementUsingLinq
{
    public class UC11Review
    {
        public void retrieveReviewMsg(List<UC1ProductReview> productReviews)
        {
            var recordData = from reviews in productReviews where reviews.Review == "nice" select reviews;
            foreach (var record in recordData)
            {
                Console.WriteLine("ProductID: " + record.ProductID + " Userid : " + record.UserID + " Rating : " + record.Rating + " Review : " + record.Review + " isLike: " + record.isLike);
            }
        }
    }
}