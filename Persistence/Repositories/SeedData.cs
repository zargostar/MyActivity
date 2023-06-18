using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence.Repositories
{
    public static class SeedData
    {
        public static async Task Craete(ActivityDbContext context){
            var activity=new List<Activity>(){
                 new Activity
                    {
                        Title = "Past Activity 1",
                        Date = DateTime.UtcNow.AddMonths(-2),
                        Description = "Activity 2 months ago",
                        Category = "drinks",
                        City = "London",
                        Venue = "Pub",
                       
                    },
                    new Activity
                    {
                        Title = "Past Activity 2",
                        Date = DateTime.UtcNow.AddMonths(-1),
                        Description = "Activity 1 month ago",
                        Category = "culture",
                        City = "Paris",
                        Venue = "The Louvre",
                       
                    },

            };
            
            await context.Activities.AddRangeAsync(activity);
            await context.SaveChangesAsync();

        }
    }
}