//using Xunit;
//using shoeCollection.Models;
//using shoeCollection.Controllers;
//using NSubstitute;
//using shoeCollection.Repositories;

//namespace ShoeCollection.Tests
//{
//    public class ShoeControllerTests
//    {
//        ShoeController underTest;
//        IShoeRepository repo;
//        public ShoeControllerTests()
//        {
//            repo = Substitute.For<IShoeRepository>();

//            underTest = new ShoeController(repo);
//        }

//        [Fact]
//        public void Get_Returns_A_Shoe()
//        {
//            var expectedId = 1;
//            repo.GetById(expectedId).Returns(new Shoe() { ShoeId = expectedId });

//            var result = underTest.Get(expectedId);

//            Assert.Equal(expectedId, result.Value.ShoeId);
//        }

//        [Fact]
//        public void Post_Creates_A_Shoe()
//        {
//            var result = underTest.Post(new Shoe());

//            Assert.True(result.Value);
//        }

//        [Fact]
//        public void Post_Updates_Shoe_Info()
//        {
//            var result = underTest.Post(1, new Shoe());

//            Assert.True(result.Value);
//        }
//    }
//}

