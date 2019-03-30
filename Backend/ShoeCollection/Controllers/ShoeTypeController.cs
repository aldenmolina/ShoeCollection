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
    public class ShoeTypeController : ControllerBase
    {
        IShoeTypeRepository shoesTypeRepo;
        public ShoeTypeController(ShoeTypeRepository shoesTypeRepo)
        {
            this.shoesTypeRepo = shoesTypeRepo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ShoeType>> Get()
        {
            return shoesTypeRepo.GetAll().ToArray();
        }

        //[HttpPost]
        //public ActionResult<bool> Post([FromBody] ShoeType newShoeType)
        //{
        //    shoesTypeRepo.Create(newShoeType);
        //    return true;
        //}

        //[HttpGet]
        //public ShoeType Delete(int id)
        //{
        //    var model = shoesTypeRepo.GetById(id);
        //    return model;
        //}

        //[HttpPost]
        //public ActionResult<bool> Delete([FromBody] ShoeType shoeType)
        //{
        //    shoesTypeRepo.Delete(shoeType);
        //    return true;
        //}

        //[HttpGet]
        //public ShoeType Update(int id)
        //{
        //    var model = shoesTypeRepo.GetById(id);
        //    return model;
        //}

        //[HttpPost]
        //public ActionResult<bool> Update(ShoeType shoeType)
        //{
        //    shoesTypeRepo.Update(shoeType);
        //    return true;
        //}
    }
}