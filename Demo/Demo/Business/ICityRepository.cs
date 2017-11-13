using System;
using System.Collections.Generic;
using System.Text;
using Data;

namespace Business
{
    public interface ICityRepository
    {
        void Add(City city);
        IReadOnlyList<City> GetAll();
    }

}
