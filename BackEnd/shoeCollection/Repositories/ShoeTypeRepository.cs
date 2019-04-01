using shoeCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shoeCollection.Repositories
{
    public class ShoeTypeRepository : IShoeTypeRepository
    {
        ShoeContext db;

        public ShoeTypeRepository (ShoeContext db)
        {
            this.db = db;
        }

        public ShoeType GetById(int id)
        {
            return db.ShoeTypes.Single(shoeType => shoeType.ShoeTypeId == id);
        }

        public void Create(ShoeType newShoeType)
        {
            db.ShoeTypes.Add(newShoeType);
            db.SaveChanges();
        }

        public List<ShoeType> GetAll()
        {
            return db.ShoeTypes.ToList();
        }

       
    }
}
