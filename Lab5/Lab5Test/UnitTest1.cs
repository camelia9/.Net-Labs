using System;
using System.Collections.Generic;
using Business;
using Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data.Persistance;

namespace Lab5Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TesNullArguments()
        {
            City city = City.CreateCity("Iasi", "Moldavia", 1.2, 3.4, 5.6) ?? throw new ArgumentNullException("City.CreateCity(\"Iasi\", \"Moldavia\", 1.2, 3.4, 5.6)");

        }
    }
}
