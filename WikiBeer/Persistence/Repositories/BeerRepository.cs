﻿using System.Threading.Tasks;
using WikiBeer.Core.Models;
using WikiBeer.Core.Models.BreweryDbResults;
using WikiBeer.Core.Repositories;
using WikiBeer.Persistence.Repositories.Base;

namespace WikiBeer.Persistence.Repositories
{
    public class BeerRepository : BreweryDbBaseRepository<Beer, string>, IBeerRepository
    {
        public BeerRepository() : base("beer", "beers")
        {
        }

        public async Task<BreweryDbCollectionResult<Brewery>> GetBreweries(string beerId)
        {
            return await GetDetailCollectionAsync<Brewery>(beerId, "breweries");
        }
    }
}