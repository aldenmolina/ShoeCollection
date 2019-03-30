using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoeCollection.Models;

namespace ShoeCollection.Repositories
{
    public class ShoeTypeRepository : IShoeTypeRepository
    {
        ShoeContext db;

        public ShoeTypeRepository(ShoeContext db)
        {
            this.db = db;
        }

        public IEnumerable<ShoeType> GetAll()
        {
            return db.ShoesTypes.ToList();
        }
    }
}

       

       