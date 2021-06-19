using System;

namespace CalculoFormulaBhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x1, x2;
            String entradaA, entradaB, entradaC;

            Console.Write("Digite o valor de A: ");
            entradaA = Console.ReadLine();
            a = Convert.ToDouble(entradaA);
            Console.Write("Digite o valor de B: ");
            entradaB = Console.ReadLine();
            b = Convert.ToDouble(entradaB);
            Console.Write("Digite o valor de C: ");
            entradaC = Console.ReadLine();
            c = Convert.ToDouble(entradaC);

            while (a != 0 && b != 0 && c != 0)
            {
                delta = b * b - 4 * a * c;
                Console.WriteLine("Valor de Delta: " + delta);

                if (delta < 0)
                {
                    Console.WriteLine("Não existe raiz negativa no Conjuntos de Números Reais");
                    break;
                }

                x1 = (-b - Math.Round(Math.Sqrt(delta), 2)) / 2;
                x2 = (-b + Math.Round(Math.Sqrt(delta), 2)) / 2;

                Console.WriteLine("O valor de x é : " + Math.Round(x1, 2) + "\n" +
                    "O valor de x é: " + Math.Round(x2, 2));

            }
            Console.ReadKey();
        }
    }
}
