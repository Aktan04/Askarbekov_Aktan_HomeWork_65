using HomeWork65.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeWork65.Services;

public class CountryInitializer
{
    private readonly ModelBuilder _modelBuilder;

    public CountryInitializer(ModelBuilder modelBuilder)
    {
        _modelBuilder = modelBuilder;
    }
    public void Seed()
    {
        _modelBuilder.Entity<Country>().HasData(
            new Country(){Id = 1, Name = "Japan", OfficialName = "State of Japan", Region = "Asia", SubRegion = "Eastern Asia", Population = 126300000, Capital = "Tokyo"},
            new Country(){Id = 2, Name = "Brazil", OfficialName = "Federative Republic of Brazil", Region = "South America", SubRegion = "South America", Population = 213000000, Capital = "Brasília"},
            new Country(){Id = 3, Name = "Australia", OfficialName = "Commonwealth of Australia", Region = "Oceania", SubRegion = "Australia and New Zealand", Population = 25690000, Capital = "Canberra"},
            new Country(){Id = 4, Name = "India", OfficialName = "Republic of India", Region = "Asia", SubRegion = "Southern Asia", Population = 1380000000, Capital = "New Delhi"},
            new Country(){Id = 5, Name = "Mexico", OfficialName = "United Mexican States", Region = "North America", SubRegion = "Central America", Population = 128900000, Capital = "Mexico City"},
            new Country(){Id = 6, Name = "Italy", OfficialName = "Italian Republic", Region = "Europe", SubRegion = "Southern Europe", Population = 60000000, Capital = "Rome"},
            new Country(){Id = 7, Name = "Egypt", OfficialName = "Arab Republic of Egypt", Region = "Africa", SubRegion = "Northern Africa", Population = 104000000, Capital = "Cairo"},
            new Country(){Id = 8, Name = "South Korea", OfficialName = "Republic of Korea", Region = "Asia", SubRegion = "Eastern Asia", Population = 51700000, Capital = "Seoul"},
            new Country(){Id = 9, Name = "Argentina", OfficialName = "Argentine Republic", Region = "South America", SubRegion = "South America", Population = 45380000, Capital = "Buenos Aires"},
            new Country(){Id = 10, Name = "South Africa", OfficialName = "Republic of South Africa", Region = "Africa", SubRegion = "Southern Africa", Population = 59300000, Capital = "Pretoria (administrative), Bloemfontein (judicial), Cape Town (legislative)"}); 
    }
}