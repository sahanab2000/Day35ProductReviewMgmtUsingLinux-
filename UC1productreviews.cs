using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day35ProductReviewManagementUsingLinq
{
    public class UC1ProductReview
    {
        public int ProductID { get; set; }
        public int UserID { get; set; }
        public int Rating { get; set; }
        public string Review { get; set; }
        public bool isLike { get; set; }

        
    }
}