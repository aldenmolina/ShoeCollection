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
        void Add(Shoe shoe);
        void Edit(Shoe shoe);
        void Delete(Shoe shoe);
    }
}
