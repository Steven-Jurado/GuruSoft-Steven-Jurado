using System.Collections.Generic;

namespace Laboratorio.Services
{
    public interface ICalculatorMaper
    {

        List<int> NumberPrimoRange(int startNumber, int endNumber);

    }

    public class CalculatorOperation : ICalculatorMaper
    {
        public  List<int> NumberPrimoRange(int startNumber, int endNumber)
        {

            int aux = startNumber;
            List<int> listNumberPrimo = new();

            for (int i = startNumber; i < endNumber; i++)
            {
                int data = aux;
                int calculatorPrimo = aux % 2;
                aux++;

                if (calculatorPrimo != 0)
                    listNumberPrimo.Add(data);

            }

            return listNumberPrimo;
        }
    }
}
