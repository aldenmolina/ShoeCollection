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
    public class ShoeBrandModelTests
    {
        [Fact]
        public void Model_Has_Name()
        {
            var undertest = new ShoeBrand() { ShoeBrandName = "Adidas A.R. Trainer" };

            var result = undertest.ShoeBrandName;

            Assert.Equal("Adidas A.R. Trainer", result);
        }

        [Fact]
        public void Model_Has_Info()
        {
            var undertest = new ShoeBrand() { ShoeBrandInfo = "From deep in the adidas archives comes this vintage-inspired sneaker - the adidas A.R. Trainer. Complete with a muted silhouette and heavily influenced by the adidas classics, these are sure to please any old-school sneaker aficionado. The new design has reimagined the classic 1988 ASC Trainer, a throwback to the 1980s tennis sneakers, but it doesn’t stop there. The sneaker also features an ’80s-style multi-purpose sole unit and trefoil logo. In the 1980s these sneakers took the lead on grass, clay, and concrete and the upgraded versions take their cues from the 1988 classics. With a mix of textures, these streetwear shoes come with chunky accents and bright colors that echo the fashion trends of decades past." };

            var result = undertest.ShoeBrandInfo;

            Assert.Equal("Restaurant cartoon", result);
        }

        [Fact]
        public void Model_Has_ID()
        {
            var undertest = new ShoeBrand() { ShoeBrandId = 8 };

            var result = undertest.ShoeBrandId;

            Assert.Equal(5, result);
        }
    }
}


