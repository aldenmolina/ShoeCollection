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

        public ShoeBrandRepository(ShoeContext db)
        {
            this.db = db;
        }

        public ShoeBrand GetById(int id)
        {
            return db.ShoeBrands.Single(shoeBrand => shoeBrand.ShoeBrandId == id);
        }

        public void Create(ShoeBrand newShoeBrand)
        {
            db.ShoeBrands.Add(newShoeBrand);
            db.SaveChanges();
        }

        public void Delete(ShoeBrand newShoeBrand)
        {
            db.ShoeBrands.Remove(newShoeBrand);
            db.SaveChanges();
        }

        public void Update(ShoeBrand newShoeBrand)
        {
            db.ShoeBrands.Update(newShoeBrand);
            db.SaveChanges();
        }

        public List<ShoeBrand> GetAll()
        {
            return db.ShoeBrands.ToList();
        }
    }
}
