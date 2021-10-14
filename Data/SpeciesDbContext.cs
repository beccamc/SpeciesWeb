using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SpeciesWeb.Data
{
    public class SpeciesDbContext: DbContext
    {
        public SpeciesDbContext(DbContextOptions<SpeciesDbContext> options): base(options)
        {
        }
        public DbSet<SpeciesData> Species { get; set; }
    }
}
