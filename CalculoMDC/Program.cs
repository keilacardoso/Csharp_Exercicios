using System;

namespace CalculoMDC
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeirovalor, segundovalor, mdc, resto = 0;

            Console.WriteLine("Informe o primeiro valor: ");
            primeirovalor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor: ");
            segundovalor = Convert.ToInt32(Console.ReadLine());

            while (segundovalor != 0)
            {
                resto = primeirovalor % segundovalor;
                primeirovalor = segundovalor;
                segundovalor = resto;
            }
            mdc = primeirovalor;
            Console.WriteLine("MDC: " + mdc);
            Console.ReadKey();
        }

    }
}

