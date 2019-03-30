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
    public class ShoeController : ControllerBase
    {
        public ShoeBrandRepository shoesRepo;

        public ShoeController(ShoeBrandRepository shoesRepo)
        {
            this.shoesRepo = shoesRepo;
        }

        [HttpGet]
        public ActionResult<List<ShoeBrand>> Get()
        {
            return shoesRepo.GetAll(); ;
        }

        [HttpPost]
        public ActionResult<bool> Post([FromBody] ShoeBrand shoeBrands)
        {
            shoesRepo.Create(ShoeBrand);
            return true;
        }
    }
}