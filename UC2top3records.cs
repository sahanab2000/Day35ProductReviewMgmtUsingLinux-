using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day35ProductReviewManagementUsingLinq;

namespace Day35ProductReviewManagementUsingLinq
{
    public class UC2Top3Records
    {
        public void selectTopRecord(List<UC1ProductReview> productReviewList)
        {
            //Retrieve top 3 records from the list who’s rating is high using LINQ
            var top3Record = (from review in productReviewList orderby review.Rating descending select review).Take(3);

            foreach (var item in top3Record)
            {
                Console.WriteLine("ProductID: " + item.ProductID + " Userid : " + item.UserID + " Rating : " + item.Rating + " Review : " + item.Review + " isLike: " + item.isLike);
            }
        }
    }
}
Footer
© 2022 GitH