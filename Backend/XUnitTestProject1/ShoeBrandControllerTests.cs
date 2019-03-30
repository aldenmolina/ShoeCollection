using NSubstitute;
using Microsoft.AspNetCore.Mvc;
using ShoeCollection.Controllers;
using ShoeCollection.Models;
using ShoeCollection.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace ShoeCollection.Tests
{
    public class ShoeBrandControllerTests
    {
        //public ShoeBrandController underTest;
        //public IShoeBrandRepository repo;

        //public ShoeBrandControllerTests()
        //{
        //    repo = Substitute.For<IShoeBrandRepository>();

        //    underTest = new ShoeBrandController();
        //}

        //[Fact]
        //public void Get_Returns_A_List_Of_Shoe_Brands()
        //{

        //    var result = underTest.Get();

        //    Assert.Equal(1, result.Value.Count());
        //}

        //[Fact]
        //public void Post_Creates_New_Meme()
        //{
        //    var underTest = new MemeController();

        //    var result = underTest.Post("Hello World");

        //    Assert.True(result.Value);
        //}

        //[Fact(Skip = "Post should increase number of memes")]
        //public void Post_Should_Increase_Memes_Count()
        //{
        //    var underTest = new MemeController();

        //    var result = underTest.Get();

        //    Assert.Equal(4, result.Value.Count());
        //}
    }
}
