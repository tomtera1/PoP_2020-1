using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    public class Address
    {
        public string address = "13";
        public string Street = "Oborishte str.";
        public string City = "Varna";
        public string Country = "Bulgaria";

        public string FullAddress => $"{address} {Street} {City} {Country}";

    }
}
