namespace Laboratorio.Services
{
    public interface IPatternMaper
    {
        string FindPattern(string pattern);
    }

    public class PatternOperation : IPatternMaper
    {

        /// <summary>
        /// Se  Calcular Patron Para Obtener la Mitad de Caracteres
        /// </summary>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public string FindPattern(string pattern)
        {

            //Calcularos Valores Primos 

            string auxPattern = pattern;
            int LenghtPattern = pattern.Length;

            int aux = LenghtPattern;

            var calcularprimo = LenghtPattern % 2;

            if (calcularprimo != 0)
            {
                var responseMitad = ((LenghtPattern + 1) / 2);

                var startSplid = auxPattern.Substring(0, responseMitad);

                return $"{startSplid[startSplid.Length - 1]}";
            }
            else
            {
                var responseMitad = (LenghtPattern / 2);

                var startSplid = auxPattern.Substring(0, (responseMitad));
                var endSplid = auxPattern.Substring(responseMitad, (LenghtPattern - responseMitad));

                var start = startSplid[startSplid.Length - 1];
                var end = endSplid[0];

                return $"{start}{end}";

            }

        }
    }
}
