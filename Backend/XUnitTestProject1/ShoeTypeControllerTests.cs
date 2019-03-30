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
    public class ShoeTypeControllerTests
    {
        //ShoeTypeController underTest;
        //IShoeTypeRepository repo;

        //public ShoeTypeControllerTests()
        //{
        //    repo = Substitute.For<IShoeTypeRepository>();

        //    underTest = new ShoeTypeController(repo);
        //}

        [Fact]
        public void Get_Returns_All_Shoe_Types()
        {
            var mockList = new List<ShoeType>() { new ShoeType(), new ShoeType() };

            repo.GetAll().Returns(mockList);

            var result = underTest.Get();

            Assert.Equal(mockList, result.Value);
        }
    }
}
