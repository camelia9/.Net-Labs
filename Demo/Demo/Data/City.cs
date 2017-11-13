using System;

namespace Data
{
    public class City
    {
        private City()
        {
        }

        public Guid Id { get; private set; }

        public string Name { get; private set; }

        public string Region { get; private set; }

        public double Latitude { get; private set; }

        public double Longitude { get; private set; }

        public double Rating { get; private set; }

        public static City CreateCity(string name,string region, double latitude, double longitude, double rating)
        {
            // defensive coding
            var instance = new City
            {
                Id = Guid.NewGuid(),
                Name = name,
                Region = region,
                Latitude = latitude,
                Longitude = longitude,
                Rating = rating              
            };
            return instance;
        }
        /*
        public void EditCity(double rating)
        {
            this.Rating = rating;
        }

        public static void DeleteCity(City city)
        {
            city = null;
        }

        public City GetCityById(Guid id)
        {
            if (this.Id == id)
            {
                return this;
            }

            return null
        }
        d.GetCityById
            e. GetAllCities
        f. GetCitiesBySpecifiedRating*/
    }
}
