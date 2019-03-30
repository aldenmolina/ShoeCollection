using ShoeCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoeCollection.Repositories
{
    public class ShoeBrandRepository : IShoeBrandRepository
    {
        private ShoeContext db;
        private int shoeBrandId;

        public ShoeBrandRepository(ShoeContext db)
        {
            this.db = db;
        }

       

        public void Create(ShoeBrand newShoeBrand)
        {
            db.Add(newShoeBrand);
            db.SaveChanges();
        }

        public ShoeBrand GetById(int shoeBrandId)
        {
            return db.ShoeBrands.Single(shoeBrand => shoeBrand.ShoeBrandId == shoeBrandId);
        }

        //public List<ShoeBrand> GetAll()
        //{
        //    return db.ShoeBrands.ToList();
        //}

        public void Update(ShoeBrand newShoeBrand)
        {
            db.Update(newShoeBrand);
            db.SaveChanges();
        }

        public void Delete(ShoeBrand newShoeBrand)
        {
            db.Remove(newShoeBrand);
            db.SaveChanges();
        }
    }
}
