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
    public class ShoeTypeModelTests
    {
        [Fact]
        public void Shoe_Type_Has_Name()
        {
            var undertest = new ShoeType() { ShoeTypeName = "Basketball Shoes" };

            var result = undertest.ShoeTypeName;

            Assert.Equal("Basketball Shoes", result);
        }

        [Fact]
        public void Shoe_Type_Has_Info()
        {
            var undertest = new ShoeType() { ShoeTypeInfo = "Basketball shoes are stiff, heavy, and flat. They come up higher on the ankle than running shoes, to provide support for the stresses incurred by the ankle joint in basketball." };

            var result = undertest.ShoeTypeInfo;

            Assert.Equal("Basketball shoes are stiff, heavy, and flat. They come up higher on the ankle than running shoes, to provide support for the stresses incurred by the ankle joint in basketball.", result);
        }
    }
}