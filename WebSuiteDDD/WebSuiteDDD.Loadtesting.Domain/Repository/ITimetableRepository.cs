using System;
using System.Collections.Generic;
using System.Text;

namespace WebSuiteDDD.Loadtesting.Domain.Repository
{
    public interface ITimetableRepository
    {
        IList<Loadtest> GetLoadtestsForTimePeriod(DateTime searchStartDateUtc, DateTime searchEndDateUtc);
        void AddOrUpdateLoadtests(AddOrUpdateLoadtestsValidationResult addOrUpdateLoadtestsValidationResult);
        void DeleteById(Guid guid);
    }
}
