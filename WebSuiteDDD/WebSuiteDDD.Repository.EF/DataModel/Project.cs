﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WebSuiteDDD.Repository.EF.DataModel
{
    public class Project : Description // work-around for complex types, ef core doesn't still supports it.
    {
        public Guid Id { get; set; }
        public DateTime DateInsertedUtc { get; set; }
    }
}
