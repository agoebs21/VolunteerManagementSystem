using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchFunctionality.Models
{
    public class VolunteersListViewModel
    {
            public IEnumerable<Volunteer> Volunteers { get; set; }
        public string SearchTerm { get; set; }
    }
}