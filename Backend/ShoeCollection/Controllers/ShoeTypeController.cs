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
        public ShoeTypeRepository shoesTypeRepo;

        public ShoeTypeController(ShoeTypeRepository shoesTypeRepo)
        {
            this.shoesTypeRepo = shoesTypeRepo;
        }

        [HttpGet]
        public ActionResult<List<ShoeType>> Get()
        {
            return shoesTypeRepo.GetAll(); ;
        }

        [HttpPost]
        public ActionResult<bool> Post([FromBody] ShoeType newShoeType)
        {
            shoesTypeRepo.Create(newShoeType);
            return true;
        }
    }
}