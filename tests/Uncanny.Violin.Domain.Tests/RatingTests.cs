using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uncanny.Violin.Domain.Catalog;
using System;

namespace Uncanny.Violin.Domain.Tests;

[TestClass]
public class RatingTests
{
    [TestMethod]
    public void Can_Create_New_Rating()
    {
        var rating = new Rating(1, "Mike", "Great fit!"); 

        Assert.AreEqual(1, rating.Stars); 
        Assert.AreEqual("Mike", rating.UserName); 
        Assert.AreEqual("Great fit!", rating.Review); 
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Cannot_Create_Rating_With_Invalid_Stars()
    {
        var rating = new Rating(0, "Mike", "Great fit!"); 
    }
}