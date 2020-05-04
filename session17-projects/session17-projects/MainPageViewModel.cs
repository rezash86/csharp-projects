using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session17_projects
{
    class MainPageViewModel
    {
        public Customer Customer { get; set; }
        
        public List<DateTime> OrderDates { get; set; }

        public List<OrderItem> OrderItems { get; set; }
    }
}
