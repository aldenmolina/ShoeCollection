using shoeCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shoeCollection.Repositories
{
    public class ShoeTypeRepository
    {
        private ShoeContext db;

        public ShoeTypeRepository(ShoeContext db)
        {
            this.db = db;
        }


        public List<ShoeType> GetAll()
        {
            return db.ShoeTypes.ToList();
        }
    }
}
