using System;

namespace SomarDigitosInteiros
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, digito, soma = 0;

            Console.WriteLine("Digite o número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            while (numero > 0)
            {
                digito = numero % 10;
                soma = soma + digito;
                numero = numero / 10;
            }

            Console.WriteLine("Soma: " + soma);
            Console.ReadKey();
        }
    }
}
