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
        IShoeTypeRepository repo;

        public ShoeTypeController(IShoeTypeRepository repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public ActionResult<List<ShoeType>> Get()
        {
            var shoeTypeList = repo.GetAll().ToList();

            return shoeTypeList ;
        }

        [HttpPost]
        public ActionResult<bool> Post([FromBody] ShoeType shoeType)
        {
            shoeTypeRepo.Create(shoeType);
            return true;
        }
    }
}