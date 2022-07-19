using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace laboratorio.portal.Helper
{
    public class MapperResponse
    {
        public int StatusCode { get; set; }
        public bool Error { get; set; } = false;
        public string Message { get; set; }
    }
}
