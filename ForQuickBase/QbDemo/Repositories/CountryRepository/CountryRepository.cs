using Data;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.CountryRepository
{
    public class CountryRepository : ICountryRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public CountryRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Country> GetAllCountries => _appDbContext.Countries
                                                           .Include(x => x.Cities)
                                                           .ToList();
        public Country GetCountryById(int id) => _appDbContext.Countries
                                                            .AsNoTracking()
                                                            .SingleOrDefault(x => x.Id == id);

    }
}
