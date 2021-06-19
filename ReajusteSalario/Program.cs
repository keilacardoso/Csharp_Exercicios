using System;

namespace ReajusteSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, reajuste, porcentagem;

            Console.WriteLine("Informe o salário: ");
            string salarioDigitado = Console.ReadLine();
            salario = Convert.ToDouble(salarioDigitado);
            Console.WriteLine("Informe o porcentual a ser reajustado: ");
            string porcentualDigitado = Console.ReadLine();
            porcentagem = Convert.ToDouble(porcentualDigitado);


            reajuste = salario + (salario * (porcentagem / 100));
          
;
            Console.WriteLine("Parabéns! Seu salário passará a ser : " +  reajuste);
        }
    }
}
