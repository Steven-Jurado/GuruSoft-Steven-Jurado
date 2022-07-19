using System;

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
