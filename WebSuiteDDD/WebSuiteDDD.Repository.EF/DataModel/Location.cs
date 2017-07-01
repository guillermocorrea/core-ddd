﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WebSuiteDDD.Repository.EF.DataModel
{
    public class Location
    {
        public string City { get; set; }
        public string Country { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}
