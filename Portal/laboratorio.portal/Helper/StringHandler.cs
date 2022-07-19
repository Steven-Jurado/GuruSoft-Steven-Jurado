using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace laboratorio.portal.Helper
{
    public class StringHandler
    {
        public const string HOSTNAME = "localhost";
        public const int PORT = 44382;
        public const string OPERATOR = "api";

        protected internal string Command { get; set; }

        public string IntanceOperador(string controller, string method)
        {

            Command = $"https://{HOSTNAME}:{PORT}/{OPERATOR}/{controller}/{method}";

            return Command;
        }
    }
}
