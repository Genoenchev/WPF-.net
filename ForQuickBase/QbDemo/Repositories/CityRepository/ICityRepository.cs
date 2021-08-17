namespace Repositories.CityRepository
{
  using Models;
  using System.Collections.Generic;
  public interface ICityRepository
    {
        City GetCityById(int id);
        City GetCityByName(string name);
        IEnumerable<City> GetAllCities { get; }
        void Add(City city);
        void Update(City city);
        void Delete(int city);
    }
}
