using NSubstitute;
using shoeCollection.Controllers;
using shoeCollection.Models;
using shoeCollection.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace shoeCollection.Tests
{
    public class ShoeTypeControllerTests
    {
        ShoeTypeController underTest;
        IShoeTypeRepository repo;

        public ShoeTypeControllerTests()
        {
            repo = Substitute.For<IShoeTypeRepository>();

            underTest = new ShoeTypeController(repo);
        }

        //[Fact]
        //public void Get_Returns_All_Shoe_Types()
        //{
        //    var testList = new List<ShoeType>() { new ShoeType(), new ShoeType() };
        //    repo.GetAll().Returns(testList);

        //    var result = underTest.Get();

        //    Assert.Equal(testList, result.Value);
        //}
    }
}
