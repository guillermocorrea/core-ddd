﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WebSuiteDDD.Repository.EF.DataModel
{
    public class LoadtestParameters
    {
        public DateTime StartDateUtc { get; set; }
        public int UserCount { get; set; }
        public int DurationSec { get; set; }
    }
}
