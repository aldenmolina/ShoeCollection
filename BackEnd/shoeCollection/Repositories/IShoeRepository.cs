using shoeCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shoeCollection.Repositories
{
    public interface IShoeRepository
    {
        Shoe GetById(int id);
        void Create(Shoe shoe);
        void Update(Shoe shoe);
        void Delete(Shoe shoe);
    }
}
