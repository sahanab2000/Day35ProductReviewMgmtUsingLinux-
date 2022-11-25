using Day35ProductReviewManagementUsingLinq;
using System.Collections.Generic;
using System.ComponentModel;

//Add 25 default values in list
List<UC1ProductReview> productReviews = new List<UC1ProductReview>()
{
    new UC1ProductReview() { ProductID = 1, UserID = 1, Rating = 5, Review = "Good", isLike = true },
    new UC1ProductReview(){ProductID=1,UserID=5,Rating=5,Review="Good",isLike=true},
    new UC1ProductReview(){ProductID=2,UserID=5,Rating=5,Review="Good",isLike=true},
    new UC1ProductReview(){ProductID=2,UserID=2,Rating=4,Review="Good",isLike=true},
    new UC1ProductReview(){ProductID=3,UserID=2,Rating=5,Review="Good",isLike=true},
    new UC1ProductReview(){ProductID=3,UserID=1,Rating=5,Review="Good",isLike=false},
    new UC1ProductReview(){ProductID=4,UserID=2,Rating=2,Review="Good",isLike=true},
    new UC1ProductReview(){ProductID=4,UserID=3,Rating=2,Review="Good",isLike=false},
    new UC1ProductReview(){ProductID=5,UserID=4,Rating=2,Review="Bad",isLike=true},
    new UC1ProductReview(){ProductID=5,UserID=3,Rating=2,Review="Bad",isLike=true},
    new UC1ProductReview(){ProductID=6,UserID=4,Rating=1,Review="Bad",isLike=false},
    new UC1ProductReview(){ProductID=6,UserID=2,Rating=1,Review="Bad",isLike=false},
    new UC1ProductReview(){ProductID=7,UserID=1,Rating=3,Review="Bad",isLike=true},
    new UC1ProductReview(){ProductID=7,UserID=4,Rating=3,Review="Bad",isLike=true},
    new UC1ProductReview(){ProductID=8,UserID=2,Rating=4,Review="nice",isLike=true},
    new UC1ProductReview(){ProductID=9,UserID=5,Rating=5,Review="Good",isLike=true},
    new UC1ProductReview(){ProductID=10,UserID=5,Rating=5,Review="Good",isLike=true},
    new UC1ProductReview() { ProductID = 11, UserID = 1, Rating = 5, Review = "Good", isLike = false },
    new UC1ProductReview(){ProductID=12,UserID=2,Rating=4,Review="Good",isLike=true},
    new UC1ProductReview(){ProductID=13,UserID=1,Rating=5,Review="Good",isLike=true},
    new UC1ProductReview(){ProductID=14,UserID=3,Rating=2,Review="Good",isLike=false},
    new UC1ProductReview(){ProductID=15,UserID=3,Rating=2,Review="Bad",isLike=true},
    new UC1ProductReview(){ProductID=16,UserID=4,Rating=1,Review="Bad",isLike=false},
    new UC1ProductReview(){ProductID=17,UserID=4,Rating=3,Review="Bad",isLike=true},
    new UC1ProductReview(){ProductID=18,UserID=2,Rating=4,Review="nice",isLike=true},
    
};

//display all the records
foreach(var review in productReviews)
{
    Console.WriteLine("ProductID: " + review.ProductID + " Userid : " + review.UserID + " Rating : " + review.Rating + " Review : " + review.Review + " isLike: " + review.isLike);
}

//call the uc2 to find the top 3 records
Console.WriteLine("\nThe top 3 records of high ratings are:");
UC2Top3Records topRecords = new();
topRecords.selectTopRecord(productReviews);

//Retrieve all record from the list who’s rating are greater then 3 and productID is 1 or 4 or 9 using LINQ
Console.WriteLine("\nRecords who’s rating are greater then 3 and productID is 1 or 4 or 9:");
UC3TopRecords uC3TopRecords = new();
uC3TopRecords.selectTopRatingRecords(productReviews);

//Retrieve count of review present for each productID
Console.WriteLine("\ncount of review present for each productID");
UC4CountGroupBy countGroupBy = new();
countGroupBy.countProductByID(productReviews);

//Retrieve only productId and review from the list for all records.
Console.WriteLine("\nRetrieve productId and review from the list for all records");
UC5SelecttProductIDReview productIDReview = new();
productIDReview.retrieveIDReview(productReviews);

//skip top 5 records from the list using LINQ and display other records
Console.WriteLine("\nRetrieve All records skip top 5 records");
UC6SkipTop5Records skipTop5 = new();
skipTop5.selectTopRecord(productReviews);

//Retrieve only productId and review from the list for all records.
Console.WriteLine("\nRetrieve productId and review from the list for all records");
UC7SelecttProductIDReview IDReview = new();
IDReview.retrieveIDReview(productReviews);

//Retreive all records from the list who’s review message contain nice message
Console.WriteLine("\n Retreive all records from the list who’s review message contain \"nice\"");
UC11Review Review = new();
Review.retrieveReviewMsg(productReviews);

