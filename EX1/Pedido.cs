using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    public class Pedido
    {
        public double NumeroPedido;
        public List<Produto> Pedidos;
        public double TotalPedido()
        {
            double total = 0;
            foreach (var item in Pedidos)
            {
                total += item.Preco;
            }
            return total;
        }
    }
}
