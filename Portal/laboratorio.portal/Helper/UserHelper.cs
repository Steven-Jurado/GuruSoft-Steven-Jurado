using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace laboratorio.portal.Helper
{
    public class UserHelper
    {
        public string UserName { get; set; }

        public string LastName { get; set; }

        public DateTime DateRequest { get; set; } = DateTime.Now;

        public DateTime DateResponse { get; set; } = DateTime.Now;
    }
}
