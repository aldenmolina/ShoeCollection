using ShoeCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoeCollection.Repositories
{
    public interface IShoeTypeRepository
    {
        List<ShoeType> GetAll();
        ShoeType GetById(int id);
        void Create(ShoeType newShoeType);
        void Delete(ShoeType newShoeType);
        void Update(ShoeType newShoeType);
    }
}
