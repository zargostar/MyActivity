using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Application.Features.Activities.Queries.GetActivities
{
    public class GetActivitiesQuery:IRequest<List<ActivityDto>>
    {
        
    }
}