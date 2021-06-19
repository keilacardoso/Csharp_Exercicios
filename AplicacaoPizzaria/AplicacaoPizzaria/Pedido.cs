using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacaoPizzaria
{
    public class Pedido
    {
        private int NumeroPedido;
        private int Quantidade;
        private string Sabor;
        private string Tamanho;
        private string Divisão;
        private string Observacao;
        private double PrecoItem;
        private double TaxaEntrega;
        

        public Pedido()
        {
            PrecoItem = 12;
            TaxaEntrega = 5;
        }
        
        public double ValorTotal()
        {
            double valorTotal = PrecoItem + TaxaEntrega;
            return valorTotal;
        }

        public String getObservacao(string obs)
        {
            obs = Observacao;
           return obs;
        }

    }
}
