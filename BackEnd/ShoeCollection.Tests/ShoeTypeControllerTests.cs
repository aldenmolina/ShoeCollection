using NSubstitute;
using NSubstitute.Core;
using shoeCollection.Controllers;
using shoeCollection.Models;
using shoeCollection.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ShoeCollection.Tests
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

        [Fact]
        //public void Get_Returns_All_Shoe_Types()
        {
            var testList = new List<ShoeType>() { new ShoeType(), new ShoeType() };
            repo.GetAll().Returns(List);

            var result = underTest.Get();

            Assert.Equal(testList, result.Value);
        }

        private List<Shoe> List(CallInfo arg)
        {
            throw new NotImplementedException();
        }
    }
}