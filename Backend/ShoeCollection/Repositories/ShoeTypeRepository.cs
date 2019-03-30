using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoeCollection.Models;

namespace ShoeCollection.Repositories
{
    public class ShoeTypeRepository : IShoeTypeRepository
    {
        private ShoeContext db;

        public ShoeTypeRepository(ShoeContext db)
        {
            this.db = db;
        }

        public ShoeType GetById(int id)
        {
            return db.ShoesTypes.Single(shoeType => shoeType.ShoeTypeId == id);
        }

        public void Create(ShoeType newShoeType)
        {
            db.ShoesTypes.Add(newShoeType);
            db.SaveChanges();
        }

        public void Delete(ShoeType newShoeType)
        {
            db.ShoesTypes.Remove(newShoeType);
            db.SaveChanges();
        }

        public void Update(ShoeType newShoeType)
        {
            db.ShoesTypes.Update(newShoeType);
            db.SaveChanges();
        }

        public List<ShoeType> GetAll()
        {
            return db.ShoesTypes.ToList();
        }
    }
}

       

       