using NSubstitute;
using shoeCollection.Controllers;
using shoeCollection.Models;
using shoeCollection.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace shoeCollection.Tests
{
    public class ShoeControllerTests
    {
        ShoeController underTest;
        IShoeRepository repo;
        public ShoeControllerTests()
        {
            repo = Substitute.For<IShoeRepository>();

            underTest = new ShoeController(repo);
        }

        [Fact]
        public void Get_Returns_A_Shoe()
        {
            var expectedId = 1;
            repo.GetById(expectedId).Returns(new Shoe() { ShoeId = expectedId });

            var result = underTest.Get(expectedId);

            Assert.Equal(expectedId, result.Value.ShoeId);
        }

        [Fact]
        public void Post_Creates_Shoe()
        {
            var result = underTest.Post(new Shoe());

            Assert.True(result.Value);
        }

        [Fact]
        public void Post_Updates_Shoe()
        {
            var result = underTest.Post(1, new Shoe());

            Assert.True(result.Value);
        }

        [Fact]
        public void Post_Deletes_Shoe()
        {
            var result = underTest.Delete(1);

            Assert.True(result.Value);
        }
}
}
