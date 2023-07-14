using PokemonReviewApp.Models;
using System.Reflection;

namespace PokemonReviewApp.Interfaces
{
    public interface ICountryRepository
    {
        ICollection<Country> GetCountries();
        Country GetCountry(int id);
        Country GetCountryByOwner(int OwnerId);
        ICollection<Owner> GetOwnersFromACountry(int CountryId);
        bool CountryExists(int id);
        bool CreateCountry(Country country);
        bool Save();
    }
}
