﻿namespace Laboratorio.Helpers
{
    public class MapperResponse
    {
        public int StatusCode { get; set; }
        public bool Error { get; set; } = false;
        public string Message { get; set; }
    }
}
