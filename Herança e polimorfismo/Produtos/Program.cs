using Produtos__herança_e_polimorfismo_.Entities;
using System;

namespace Produtos__herança_e_polimorfismo_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.WriteLine("Entre com o número de produtos: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Produto #" + i + ":");
                Console.Write("Comum, usado ou importado (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());

                Console.Write("Digite o nome do produto:");
                string name = Console.ReadLine();

                Console.Write("Digite o preço do produto:");
                double price = double.Parse(Console.ReadLine());

                if(type == 'u' || type == 'U')
                {
                    Console.Write("Data de fabricação (DD/MM/YYYY):");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    list.Add(new UsedProduct(name, price, manufactureDate));
                }
                else if(type == 'i' || type == 'I')
                {
                    Console.Write("Taxa alfandegária:");
                    double customsFee = double.Parse(Console.ReadLine());

                    list.Add(new ImportedProduct(customsFee, name, price));
                }
                else
                {
                    list.Add(new Product(name, price));
                }

            }
            Console.WriteLine();
            foreach(Product product in list)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
