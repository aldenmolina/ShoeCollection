using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace shoeCollection.Models
{
    public class ShoeType
    {
        [Key]
        public int ShoeTypeId { get; set; }
        public string ShoeTypeName { get; set; }

        public virtual List<Shoe> ShoeBrands { get; set; }
    }
}
