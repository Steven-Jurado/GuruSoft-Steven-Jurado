using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio.Services
{
    public interface IPatternMaper
    {
        string FindPattern(string pattern);
    }

    public class PatternOperation : IPatternMaper
    {
        public string FindPattern(string pattern)
        {
            string auxPattern = pattern;
            int LenghtPattern = pattern.Length;

            int aux = LenghtPattern;

            var calcularprimo = LenghtPattern % 2;

            if (calcularprimo != 0)
            {
                return string.Empty;
            }
            else
            {
                /*var responseMitad = (LenghtPattern / 2) + 1*/;
               // var auxResponseMita = responseMitad - 2;

                var responseMitad = (LenghtPattern / 2);

                var startSplid = auxPattern.Substring(0, responseMitad);
                var endSplid = auxPattern.Substring(responseMitad-1, aux);


                return $"{endSplid}";

            }

        }
    }
}
