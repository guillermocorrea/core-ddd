using System;
using System.Collections.Generic;
using System.Text;

namespace WebSuiteDDD.Loadtesting.Domain
{
    public class LoadtestValidationSummary
    {
        public bool OkToAddOrModify { get; set; }
        public string ReasonForValidationFailure { get; set; }
    }
}
