using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace shoeCollection.Models
{
    public class Shoe
    {
        [Key]
        public int ShoeId { get; set; }

        public int ShoeTypeId { get; set; }

        public string ShoeName { get; set; }
        public string Description { get; set; }
    }
}
