using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace SpeciesWeb.Data
{
    public class SpeciesData
    {
        [Key]
        public string CommonName { get; set; }
        public string Kingdom { get; set; }

        public string Taxonomy { get; set; }

        public string PopulationSize { get; set; }
    }
}
