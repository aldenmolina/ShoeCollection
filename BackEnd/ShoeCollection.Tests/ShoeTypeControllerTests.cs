using NSubstitute;
using shoeCollection.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ShowTracker.Tests
{
    public class ShoeTypeControllerTests
    {
        ShoeTypeController underTest;
        IGenreRepository repo;

        public GenreControllerTests()
        {
            repo = Substitute.For<IGenreRepository>();

            underTest = new GenreController(repo);
        }

        [Fact]
        public void Get_Returns_All_Genres()
        {
            var testList = new List<Genre>() { new Genre(), new Genre() };
            repo.GetAll().Returns(testList);

            var result = underTest.Get();

            Assert.Equal(testList, result.Value);
        }
    }
}