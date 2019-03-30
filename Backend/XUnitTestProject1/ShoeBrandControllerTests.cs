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
        public ShoeBrandController underTest;
        public IShoeBrandRepository repo;

        public ShoeBrandControllerTests()
        {
            repo = Substitute.For<IShoeBrandRepository>();

            underTest = new ShoeBrandController(repo);
        }

        [Fact]
        public void Get_Returns_List_of_Shoe_Brands()
        {
            var expectedmodel = new List<ShoeBrand>() { new ShoeBrand() };
            testRepo.GetAll().Returns(expectedmodel);

            var result = underTest.Get();

            Assert.Single(result.Value);
        }

        [Fact]
        public void Get_Returns_A_Shoe_Brand()
        {
            var expectedId = 1;
            repo.GetById(expectedId).Returns(new ShoeBrand() { ShoeBrandId = expectedId });

            var result = underTest.Get(expectedId);

            Assert.Equal(expectedId, result.Value.ShoebrandId);
        }

        [Fact]
        public void Post_Creates_Shoe_Brand()
        {
            var result = underTest.Post(new ShoeBrand());

            Assert.True(result.Value);
        }

        [Fact]
        public void Post_Deletes_Shoe_Brand()
        {
            var result = underTest.Post(1, new ShoeBrand());

            Assert.True(result.Value);
        }

        [Fact]
        public void Post_Updates_Shoe_Brand()
        {
            var result = underTest.Post(1);

            Assert.True(result.Value);
        }
    }
}
