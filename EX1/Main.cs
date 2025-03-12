using System.Numerics;

namespace EX1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Produto produto = new Produto();
            produto.Produtos = new List<Produto>();

            Produto Xburger = new Produto();
            Xburger.NomeProduto = "1 - X-Burger";
            Xburger.Preco = 10.90;
            produto.Produtos.Add(Xburger);

            Produto Xsalada = new Produto();
            Xsalada.NomeProduto = "2 - X-Salada";
            Xsalada.Preco = 12.90;
            produto.Produtos.Add(Xsalada);

            Produto Hotdog = new Produto();
            Hotdog.NomeProduto = "3 - Hot Dog";
            Hotdog.Preco = 7.90;
            produto.Produtos.Add(Hotdog);

            Produto BatataFrita = new Produto();
            BatataFrita.NomeProduto = "4 - Batata Frita";
            BatataFrita.Preco = 6.90;
            produto.Produtos.Add(BatataFrita);

            Produto Refrigerante = new Produto();
            Refrigerante.NomeProduto = "5 - Refrigerante";
            Refrigerante.Preco = 5.00;
            produto.Produtos.Add(Refrigerante);

            Produto Milkshake = new Produto();
            Milkshake.NomeProduto = "6 - Milkshake";
            Milkshake.Preco = 15.00;
            produto.Produtos.Add(Milkshake);

            Produto Agua = new Produto();
            Agua.NomeProduto = "7 - Agua";
            Agua.Preco = 4.00;
            produto.Produtos.Add(Agua);

            int pedidoCount = 1;
            int auxNovoPedido = 1;
            List<Pedido> todosPedidos = new List<Pedido>();

            while (auxNovoPedido != 0)
            {
                Console.WriteLine("======= Cardápio =======\n");

                foreach (var item in produto.Produtos)
                {
                    Console.WriteLine($"{item.NomeProduto.PadRight(20)} |  R$ {item.Preco:0.00}");
                }
                Console.WriteLine("\n=========================");

                int auxEscolha = 1;
                Console.WriteLine("Deseja realizar um novo pedido?\n 1 - Sim \n 0 - Não");
                try
                {
                    auxNovoPedido = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Apenas valores numéricos são aceitos");
                    auxNovoPedido = 0;
                }
                if (auxNovoPedido != 0)
                {
                    Pedido pedido = new Pedido();
                    pedido.NumeroPedido = pedidoCount;
                    pedido.Pedidos = new List<Produto>();
                    pedidoCount++;

                    Console.WriteLine("Escolha o produto pelo número e aperte enter, após finalizar os pedidos, digite 0 e dê enter:");
                    while (auxEscolha != 0)
                    {
                        auxEscolha = int.Parse(Console.ReadLine());
                        switch (auxEscolha)
                        {
                            case 0:
                                Console.WriteLine("Pedido finalizado!");
                                break;

                            case 1:
                                pedido.Pedidos.Add(Xburger);
                                Console.WriteLine("X-Burger adicionado ao pedido!");
                                break;

                            case 2:
                                pedido.Pedidos.Add(Xsalada);
                                Console.WriteLine("X-Salada adicionado ao pedido!");
                                break;

                            case 3:
                                pedido.Pedidos.Add(Hotdog);
                                Console.WriteLine("Hot Dog adicionado ao pedido!");
                                break;

                            case 4:
                                pedido.Pedidos.Add(BatataFrita);
                                Console.WriteLine("Batata Frita adicionado ao pedido!");
                                break;

                            case 5:
                                pedido.Pedidos.Add(Refrigerante);
                                Console.WriteLine("Refrigerante adicionado ao pedido!");
                                break;

                            case 6:
                                pedido.Pedidos.Add(Milkshake);
                                Console.WriteLine("Milkshake adicionado ao pedido!");
                                break;

                            case 7:
                                pedido.Pedidos.Add(Agua);
                                Console.WriteLine("Água adicionado ao pedido!");
                                break;

                            default:
                                Console.WriteLine("Produto inválido!");
                                break;
                        }
                    }
                    todosPedidos.Add(pedido);
                }
                else
                {
                    Console.WriteLine("Pedido finalizado!");
                }   
                Console.ReadLine();
                Console.Clear();
            }

            foreach (var pedido in todosPedidos)
            {
                Console.WriteLine($"\nPedido #{pedido.NumeroPedido}\nItens:");
                foreach (var item in pedido.Pedidos)
                {
                    Console.WriteLine($"- {item.NomeProduto.Substring(4).PadRight(20)} - R$ {item.Preco:0.00}");
                }
                Console.WriteLine($"{"Total:".PadRight(25)}R$ {pedido.TotalPedido():0.00}");
            }
            Console.ReadLine();
        }
    }
}