using System;

namespace DiasMeses
{
    class Program
    {
        static void Main(string[] args)
        {
            int meses, totalDias;
            int dias = 30;

            Console.Write("Digite o mês: ");
            string mesDigitado = Console.ReadLine();
            meses = Convert.ToInt32(mesDigitado);

            totalDias = meses * dias;

            Console.WriteLine("Número de dias de " + meses + " é de: " + totalDias);
        }
    }
}
