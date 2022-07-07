using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2.Asp.net_Core_L1.Models
{
    public class PagedResult<T> : PagedResultBase where T : class
    {
        public IList<T> Results { get; set; }

        public PagedResult()
        {
            Results = new List<T>();
        }
    }
}