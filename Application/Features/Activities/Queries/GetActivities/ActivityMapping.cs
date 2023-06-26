using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain;

namespace Application.Features.Activities.Queries.GetActivities
{
    public class ActivityMapping:Profile
    {
       public ActivityMapping()
       {
        CreateMap<Activity,ActivityDto>().ReverseMap();
       }
    }
}