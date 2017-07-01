using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using WebSuiteDDD.Loadtesting.Domain;
using WebSuiteDDD.Loadtesting.Domain.Repository;
using System.Linq;

namespace WebSuiteDDD.Loadtesting.Repository.EF.Repositories
{
    public class TimetableRepository : ITimetableRepository
    {
        private DbContextOptions<LoadTestingContext> _options; // TODO: Outsource this options

        public TimetableRepository(DbContextOptions<LoadTestingContext> options)
        {
            _options = options;
        }

        public IList<Loadtest> GetLoadtestsForTimePeriod(DateTime searchStartDateUtc, DateTime searchEndDateUtc)
        {
            LoadTestingContext context = new LoadTestingContext(_options);
            IList<Loadtest> loadtestsInSearchPeriod = (from l in context.Loadtests
                                                       where (l.Parameters.StartDateUtc <= searchStartDateUtc)
                                                                   //&& EF.Functions SqlFunctions.DateAdd("s", l.Parameters.DurationSec, l.Parameters.StartDateUtc) >= searchStartDateUtc)
                                                               ||
                                                               (l.Parameters.StartDateUtc <= searchEndDateUtc)
                                                                   //&& SqlFunctions.DateAdd("s", l.Parameters.DurationSec, l.Parameters.StartDateUtc) >= searchEndDateUtc)
                                                               ||
                                                               (l.Parameters.StartDateUtc <= searchStartDateUtc)
                                                                   //&& SqlFunctions.DateAdd("s", l.Parameters.DurationSec, l.Parameters.StartDateUtc) >= searchEndDateUtc)
                                                               ||
                                                               (l.Parameters.StartDateUtc >= searchStartDateUtc)
                                                                   //&& SqlFunctions.DateAdd("s", l.Parameters.DurationSec, l.Parameters.StartDateUtc) <= searchEndDateUtc)
                                                       select l).ToList();
            return loadtestsInSearchPeriod;
        }


        public void AddOrUpdateLoadtests(AddOrUpdateLoadtestsValidationResult addOrUpdateLoadtestsValidationResult)
        {
            LoadTestingContext context = new LoadTestingContext(_options);
            if (addOrUpdateLoadtestsValidationResult.ValidationComplete)
            {
                if (addOrUpdateLoadtestsValidationResult.ToBeInserted.Any())
                {
                    foreach (Loadtest toBeInserted in addOrUpdateLoadtestsValidationResult.ToBeInserted)
                    {
                        context.Entry<Loadtest>(toBeInserted).State = EntityState.Added;
                    }
                }

                if (addOrUpdateLoadtestsValidationResult.ToBeUpdated.Any())
                {
                    foreach (Loadtest toBeUpdated in addOrUpdateLoadtestsValidationResult.ToBeUpdated)
                    {
                        context.Entry<Loadtest>(toBeUpdated).State = EntityState.Modified;
                    }
                }
            }
            else
            {
                throw new InvalidOperationException("Validation is not complete. You have to call the AddOrUpdateLoadtests method of the Timetable class first.");
            }
            context.SaveChanges();
        }


        public void DeleteById(Guid guid)
        {
            LoadTestingContext context = new LoadTestingContext(_options);
            Loadtest loadtest = (from l in context.Loadtests where l.Id == guid select l).FirstOrDefault();
            if (loadtest == null) throw new ArgumentException(string.Format("There's no load test by ID {0}", guid));
            context.Entry<Loadtest>(loadtest).State = EntityState.Deleted;
            context.SaveChanges();
        }
    }
}
