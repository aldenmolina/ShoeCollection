using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ShoeCollection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ShoeCollection.Repositories;


namespace ShoeCollection.Models
{
    public class ShoeBrand
    {
        [Key]
        public int ShoeBrandId { get; set; }

        public int ShoeTypeId { get; set; }

        public virtual ShoeType ShoeType { get; set; }

        public string ShoeBrandName { get; set; }

        public string BrandImagePath { get; set; }

        public string ShoeBrandInfo { get; set; }
    }
}
