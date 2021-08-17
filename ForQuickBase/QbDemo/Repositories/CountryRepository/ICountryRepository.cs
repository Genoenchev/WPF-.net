using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.CountryRepository
{
    public interface ICountryRepository
    {
        Country GetCountryById(int id);
        IEnumerable<Country> GetAllCountries { get; }
    }
}
