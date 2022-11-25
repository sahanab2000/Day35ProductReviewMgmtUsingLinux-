using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day35ProductReviewManagementUsingLinq;

namespace Day35ProductReviewManagementUsingLinq
{
    public class UC6SkipTop5Records
    {
        public void selectTopRecord(List<UC1ProductReview> productReviewList)
        {
            //skip top 5 records from the list using LINQ and display other records
            var RetrieveAllSkipTop5Record = (from review in productReviewList select review).Skip(5);

            foreach (var item in RetrieveAllSkipTop5Record)
            {
                Console.WriteLine("ProductID: " + item.ProductID + " Userid : " + item.UserID + " Rating : " + item.Rating + " Review : " + item.Review + " isLike: " + item.isLike);
            }
        }
    }
}