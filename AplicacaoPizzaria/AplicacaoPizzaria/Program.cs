using System;

namespace AplicacaoPizzaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido01 = new Pedido();
            pedido01.ValorTotal();
            

            Cliente cliente01 = new Cliente();

            Console.WriteLine("Olá " + cliente01.getNome("Keila") + ", seu pedido com observação: " + pedido01.getObservacao("sem cebola") + "será entregue em torno de 40 minutos no endereço: " + "\n" +
               cliente01.getEndereco("Jair Salvarani 1371") + ", obrigado!");

        }
    }
}
