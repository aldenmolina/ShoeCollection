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

        public ShoeBrand GetById(int id)
        {
            return db.ShoeBrands.Single(shoeBrand => shoeBrand.ShoeBrandId == id);
        }

        public List<ShoeBrand> GetAll()
        {
            return db.ShoeBrands.ToList();
        }

        List<ShoeType> IShoeTypeRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        ShoeType IShoeTypeRepository.GetById(int id)
        {
            throw new NotImplementedException();
        }

        void IShoeTypeRepository.Create(ShoeType newShoeType)
        {
            throw new NotImplementedException();
        }

        void IShoeTypeRepository.Delete(ShoeType newShoeType)
        {
            throw new NotImplementedException();
        }

        void IShoeTypeRepository.Update(ShoeType newShoeType)
        {
            throw new NotImplementedException();
        }
    }
}

       

       