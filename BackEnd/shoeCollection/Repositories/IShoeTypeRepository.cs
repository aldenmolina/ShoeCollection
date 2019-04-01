using shoeCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shoeCollection.Repositories
{
    public interface IShoeTypeRepository 
    {
        List<ShoeType> GetAll();
    }
}
