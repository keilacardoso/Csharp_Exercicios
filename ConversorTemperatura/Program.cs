using System;

namespace ConversorTemperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            double celcius, fahrenheit;
            string celciusDigitado, fahrenheitDigitado;

            Console.WriteLine(" 1 - Conversão de Celcius para Fahrenheit \n" +
                              " 2 - Conversão Fahrenheit para Celcius");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Digite a temperatura em Celcius: ");
                    celciusDigitado = Console.ReadLine();
                    celcius = Convert.ToDouble(celciusDigitado);

                    fahrenheit = ((celcius / 5) * 9) + 32;

                    Console.WriteLine("A temperatura convertida é: " + Math.Round(fahrenheit, 2) + "F");
                    break;

                case "2":
                    Console.WriteLine("Digite a temperatura em Fahrenheit: ");
                    fahrenheitDigitado = Console.ReadLine();
                    fahrenheit = Convert.ToDouble(fahrenheitDigitado);

                    celcius = ((fahrenheit - 32) / 9) * 5;

                    Console.WriteLine("A temperatura convertida é: " + Math.Round(celcius, 2) + "C");
                    break;
                default:
                    Console.WriteLine("Ops! Something is wrong...");
                    break;
            }




        }
    }
}
