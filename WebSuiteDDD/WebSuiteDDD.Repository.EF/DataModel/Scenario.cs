﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WebSuiteDDD.Repository.EF.DataModel
{
    public class Scenario
    {
        public Guid Id { get; set; }
        public string UriOne { get; set; }
        public string UriTwo { get; set; }
        public string UriThree { get; set; }
    }
}
