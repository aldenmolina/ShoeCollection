using ShoeCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoeCollection.Repositories
{
    public class ShoeBrandRepository
    {
        private ShoeContext db;

        public ShoeBrandRepository(ShoeContext db)
        {
            this.db = db;
        }

        public ShoeBrand GetById(int id)
        {
            return db.Shoes.Single(shoeBrand => shoeBrand.ShoeBrandId == id);
        }

        public void Create(ShoeBrand newShoeBrand)
        {
            db.shoeBrands.Add(newShoeBrand);
            db.SaveChanges();
        }

        public List<ShoeBrand> GetAll()
        {
            return db.ShoeBrands.ToList();
        }
    }
}
