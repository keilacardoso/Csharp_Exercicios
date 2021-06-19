using System;

namespace CondicaoTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0;
            do
            {
                Console.WriteLine("Digite o valor de a: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o valor de b: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o valor de c: ");
                c = Convert.ToInt32(Console.ReadLine());
                int x = a + b;
                int y = a + c;
                int z = b + c;

                if ((a > b && a > c) && a < z)                
                    Console.WriteLine("Os pontos: " + a + ", " + b + " e " + c + " formam um triângulo e o maior lado é a = " + a + ".");
                else if ((b > a && b > c) && b < y)                
                    Console.WriteLine("Os pontos: " + a + ", " + b + " e " + c + " formam um triângulo e o maior lado é b = " + b + ".");
              
                else if ((c > a && c > b) && c < x)               
                    Console.WriteLine("Os pontos: " + a + ", " + b + " e " + c + " formam um triângulo e o maior lado é c = " + c + ".");               
                else              
                    Console.WriteLine("Os pontos: " + a + ", " + b + " e " + c + " não formam um triângulo.");
               

            } while (a != 0 || b != 0 || c != 0);
            Console.WriteLine("Programa finalizado");
        }
    }
}
