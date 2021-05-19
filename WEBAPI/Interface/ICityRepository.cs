using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAPI.Model;

namespace WEBAPI.Interface
{
    public interface ICityRepository
    {
        Task<IEnumerable<City>> GetCitiesAsync();

        void AddCity(City city);

        void DeleteCity(int CityId);

        Task<City> FindCity(int id);
    }
}
