using System;

namespace Data
{
    public class City

    {
        public Guid ID { get; private set; }
        public string Name { get; private set; }
        public string Region { get; private set; }
        public double Latitude { get; private set; }
        public double Longitude { get; private set; }
        public double Rating { get; set; }

        private City()
        {
        }

        public static City CreateCity(string name, string region, double latitude, double longitude, double rating)
        {
            var instance = new City
            {
                ID = Guid.NewGuid(),
                Name = name,
                Region = region,
                Latitude = latitude,
                Longitude = longitude,
                Rating = rating
            };
            return instance;
        }
    }
    }
