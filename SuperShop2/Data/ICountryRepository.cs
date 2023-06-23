using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using SuperShop2.Data.Entities;
using SuperShop2.Models;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace SuperShop2.Data
{
    public interface ICountryRepository : IGenericRepository<Country>
    {
        IQueryable GetCountriesWithCities();


        Task<Country> GetCountryWithCitiesAsync(int id);


        Task<City> GetCityAsync(int id);


        Task AddCityAsync(CityViewModel model);


        Task<int> UpdateCityAsync(City city);


        Task<int> DeleteCityAsync(City city);

    }
}
