using System;

namespace Caixa_Troco
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorProduto, valorPago, troco;
            string valorProdutoDigitado, valorPagoDigitado;
            do
            {
                Console.WriteLine("Digite o valor do produto: ");
                valorProdutoDigitado = Console.ReadLine();
                Console.WriteLine("Digite o valor de pagamento: ");
                valorPagoDigitado = Console.ReadLine();

                if (valorProdutoDigitado != string.Empty && valorPagoDigitado != string.Empty)
                {
                    valorProduto = Convert.ToDouble(valorProdutoDigitado);
                    valorPago = Convert.ToDouble(valorPagoDigitado);

                    if (valorProduto < valorPago)
                    {
                        troco = valorPago - valorProduto;
                        Console.WriteLine("Seu troco: " + Math.Round(troco, 2));
                    }
                    else if (valorProduto == valorPago)

                        Console.WriteLine("Não há troco");

                    else if (valorProduto > valorPago)

                        Console.WriteLine("O Produto a mais do valor informado como pago");
                }
            } while (valorProdutoDigitado != string.Empty && valorPagoDigitado != string.Empty);
            Console.WriteLine("Ops! Something is wrong...");
        }
    }
}
