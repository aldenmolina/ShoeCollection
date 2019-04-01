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
    public class ShoeController : ControllerBase
    {
        IShoeRepository shoeRepo;
        public ShoeController(IShoeRepository shoeRepo)
        {
            this.shoeRepo = shoeRepo;
        }

        [HttpGet("{id}")]
        public ActionResult<Shoe> Get(int id)
        {
            var shoe = shoeRepo.GetById(id);

            return shoe;
        }

        [HttpPost]
        public ActionResult<bool> Post([FromBody] Shoe shoe)
        {
            shoeRepo.Create(shoe);
            return true;
        }

        [HttpPost("{id}")]
        public ActionResult<bool> Post(int id, [FromBody] Shoe shoe)
        {
            shoeRepo.Update(shoe);
            return true;
        }

        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            var show = shoeRepo.GetById(id);
            shoeRepo.Delete(show);

            return true;
        }
    }
}