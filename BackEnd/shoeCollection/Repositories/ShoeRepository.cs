using shoeCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shoeCollection.Repositories
{
    public class ShoeRepository
    {
        ShoeContext db;
        public ShoeRepository(ShoeContext db)
        {
            this.db = db;
        }

        public void Create(Shoe shoe)
        {
            db.Add(shoe);
            db.SaveChanges();
        }

        public Shoe GetById(int showId)
        {
            return db.Shoes.Single(show => show.ShoeId == showId);
        }

        public void Update(Shoe shoe)
        {
            db.Update(shoe);
            db.SaveChanges();
        }

        public void Delete(Shoe shoe)
        {
            db.Remove(shoe);
            db.SaveChanges();
        }
    }
}
