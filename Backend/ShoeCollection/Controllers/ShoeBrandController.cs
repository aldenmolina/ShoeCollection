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
        public IShoeBrandRepository shoesRepo;

        public ShoeBrandController(IShoeBrandRepository shoesRepo)
        {
            this.shoesRepo = shoesRepo;
        }

        [HttpGet]
        public ActionResult<List<ShoeBrand>> Get()
        {
            return shoesRepo.GetAll();
        }

        [HttpPost]
        public ActionResult<bool> Post([FromBody] ShoeBrand newShoeBrands)
        {
            shoesRepo.Create(newShoeBrands);
            return true;
        }

        //[HttpGet]
        //public ShoeBrand Delete(int id)
        //{
        //    var model = shoesRepo.GetById(id);
        //    return model;
        //}

        //[HttpPost]
        //public ActionResult<bool> Delete([FromBody] ShoeBrand shoeBrand)
        //{

        //    shoesRepo.Delete(shoeBrand);
        //    return true;
        //}

        //[HttpGet]
        //public ShoeBrand Update(int id)
        //{
        //    var model = shoesRepo.GetById(id);
        //    return model;
        //}

        //[HttpPost]
        //public ActionResult<bool> Update(ShoeBrand shoeBrand)
        //{
        //    shoesRepo.Update(shoeBrand);
        //    return true;
        //}

    }
}