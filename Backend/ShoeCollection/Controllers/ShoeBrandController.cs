using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoeCollection.Models;
using ShoeCollection.Repositories;

namespace ShoeCollection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoeBrandController : ControllerBase
    {
        IShoeBrandRepository shoesRepo;
        public ShoeBrandController(ShoeBrandRepository shoesRepo)
        {
            this.shoesRepo = shoesRepo;
        }

        [HttpGet("{id}")]
        public ActionResult<ShoeBrand> Get(int id)
        {
            var shoeBrand = shoesRepo.GetById(id);

            return shoeBrand;
        }

        [HttpPost]
        public ActionResult<bool> Post([FromBody] ShoeBrand newShoeBrands)
        {
            shoesRepo.Create(newShoeBrands);
            return true;
        }

        [HttpPost("{id}")]
        public ActionResult<bool> Post(int id, [FromBody] ShoeBrand shoeBrand)
        {
            shoesRepo.Update(shoeBrand);
            return true;
        }

        [HttpPost("{id}")]
        public ActionResult<bool> Post(int id)
        {
            var shoeBrand = shoesRepo.GetById(id);
            shoesRepo.Delete(shoeBrand);
            return true;
        }
    }
}