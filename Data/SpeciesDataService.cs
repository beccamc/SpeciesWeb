using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SpeciesWeb.Data
{
    public class SpeciesDataService
    {
        private readonly SpeciesDbContext dbContext;
        public SpeciesDataService(SpeciesDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<SpeciesData>> GetDataAsync()
        {
            return await dbContext.Species.FromSqlRaw("SELECT TOP (5) \"Common Name\" AS CommonName, \"Taxonomy: 10\" AS Taxonomy, \"Taxonomy: Kingdom\" AS Kingdom, \"NS POP SIZE\" AS PopulationSize FROM [MasterSpecies];").ToListAsync();
        }
    }
}