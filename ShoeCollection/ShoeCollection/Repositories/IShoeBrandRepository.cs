using ShoeCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoeCollection.Repositories
{
    public interface IShoeBrandRepository
    {
        List<ShoeBrand> GetAll();
        ShoeBrand GetById(int id);
        void Create(ShoeBrand newShoeBrand);
        void Delete(ShoeBrand newShoeBrand);
        void Update(ShoeBrand newShoeBrand);
    }
}
