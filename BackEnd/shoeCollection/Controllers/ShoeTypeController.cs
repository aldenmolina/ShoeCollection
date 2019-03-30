using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using shoeCollection.Models;
using shoeCollection.Repositories;

namespace shoeCollection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoeTypeController : ControllerBase
    {
        public ShoeTypeRepository shoeTypeRepo;

        public ShoeTypeController(ShoeTypeRepository shoeTypeRepo)
        {
            this.shoeTypeRepo = shoeTypeRepo;
        }

        [HttpGet]
        public ActionResult<List<ShoeType>> Get()
        {
            return shoeTypeRepo.GetAll(); ;
        }

        [HttpPost]
        public ActionResult<bool> Post([FromBody] ShoeType shoeType)
        {
            shoeTypeRepo.Create(shoeType);
            return true;
        }
    }
}