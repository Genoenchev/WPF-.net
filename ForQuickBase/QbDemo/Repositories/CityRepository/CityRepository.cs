namespace Repositories.CityRepository
{
    using Data;
    using Microsoft.EntityFrameworkCore;
    using Models;
    using System.Collections.Generic;
    using System.Linq;
    public class CityRepository : ICityRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        public CityRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<City> GetAllCities => _appDbContext.Cities.Include(x => x.Country)
                                                                      .AsNoTracking().ToList();

        public City GetCityById(int id) => _appDbContext.Cities.Include(x => x.Country)
                                                               .AsNoTracking().SingleOrDefault(x=>x.Id == id);
        public City GetCityByName(string name) => _appDbContext.Cities
                                                    .Include(x => x.Country)
                                                    .AsNoTracking()
                                                    .SingleOrDefault(x => x.CityName == name);
        public void Add(City city)
        {
            _appDbContext.Cities.Add(city);
            _appDbContext.SaveChanges();
        }
        public void Update(City city)
        {
            City oldCity = _appDbContext.Cities.Single(x => x.Id == city.Id);
            oldCity.CityName = city.CityName;
            oldCity.Population = city.Population;
            oldCity.CountryId = city.CountryId;
            _appDbContext.Entry(oldCity).State = EntityState.Modified;
            //_appDbContext.Cities.Update(City);
            _appDbContext.SaveChanges();
        }
        
        public void Delete(int id)
        {
            City city = _appDbContext.Cities.Find(id);
            _appDbContext.Cities.Remove(city);
            _appDbContext.SaveChanges();
        }
    }
}
