using System;

namespace Data.Domain
{
    public class Poi
    {
        public Guid Id {  set;  get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public double Latitude { set; get; }
        public double Longitude { set; get; }

        public Poi()
        {
            
        }
        
        public Poi(Guid id, string name, string description, double latitude, double longitude)
        {
            Id = id;
            Name = name;
            Description = description;
            Latitude = latitude;
            Longitude = longitude;
        }
        
    }
}
