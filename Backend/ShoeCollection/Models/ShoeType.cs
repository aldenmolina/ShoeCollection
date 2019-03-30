using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShoeCollection.Models
{
    public class ShoeType
    {
        [Key]
        public int ShoeTypeId { get; set; }
        public string ShoeTypeName { get; set; }
        public string TypeImagePath { get; set; }
        public string ShoeTypeInfo { get; set; }

        public virtual List<ShoeBrand> ShoeBrands { get; set; }
    }
}
