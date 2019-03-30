using ShoeCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoeCollection.Repositories
{
    public interface IShoeTypeRepository
    {

        IEnumerable<ShoeType> GetAll();
    }
}
