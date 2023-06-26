using Domain.Commen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Person:EntityBase
    {
        public string NationalCode { get; set; }
        public string PersonCode { get; set; }
        public ICollection<Activity> activities { get; set; }

    }
}
