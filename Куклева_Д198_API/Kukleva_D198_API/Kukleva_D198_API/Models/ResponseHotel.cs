using Kukleva_D198_API.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kukleva_D198_API.Models
{
    public class ResponseHotel
    {
        public ResponseHotel(Hotel hotel)
        {
            id = hotel.id;
            Name = hotel.Name;
            CountOfStars = hotel.CountOfStars;
            CountryCode = hotel.Country.Name;
            Hotelimage = hotel.Hotelimage.ToList().FirstOrDefault()?.ImageSource;
        }
        public int id { get; set; }
        public string Name { get; set; }
        public int CountOfStars { get; set; }
        public string CountryCode { get; set; }
        public byte[] Hotelimage { get; set; }

    }
}