using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day35ProductReviewManagementUsingLinq
{
    public class UC4CountGroupBy
    {
        public void countProductByID(List<UC1ProductReview> productReviews)
        {
            var recordData = productReviews.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });

            foreach (var record in recordData)
            {
                Console.WriteLine(record.ProductID + " ----------- " + record.Count);
            }
        }
    }
}