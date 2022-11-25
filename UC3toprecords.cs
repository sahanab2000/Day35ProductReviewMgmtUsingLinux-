using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day35ProductReviewManagementUsingLinq
{
    public class UC3TopRecords
    {
        public void selectTopRatingRecords(List<UC1ProductReview> productReviewList)
        {
            var records = from review in productReviewList
                          where (review.Rating > 3 && review.ProductID == 1) ||
                            (review.Rating > 3 && review.ProductID == 4) ||
                            (review.Rating > 3 && review.ProductID == 9)
                          select review;
               
            foreach (var record in records)
            {
                Console.WriteLine("ProductID: " + record.ProductID + " Userid : " + record.UserID + " Rating : " + record.Rating + " Review : " + record.Review + " isLike: " + record.isLike);
            }
        }
    }
}