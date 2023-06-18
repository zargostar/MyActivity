using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Contracts.Persistence;
using Domain;

namespace Persistence.Repositories
{
    public class ActivityRepository : RepositoryBase<Activity>, IActivityRepository

    {
        public ActivityRepository(ActivityDbContext dbContext) : base(dbContext)
        {
        }
    }
}