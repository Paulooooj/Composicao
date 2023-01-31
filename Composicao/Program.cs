using Composicao.Entities;
using Composicao.Entities.Enums;
using System.Globalization;

namespace Composicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Nome: ");
            string clientenome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDay = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter orde data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client cliente = new Client(clientenome, email, birthDay);
            Order od = new Order(DateTime.Now, status, cliente);

            Console.Write("How many items to this order? ");
            int numberOrder = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numberOrder; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Product product = new Product(productName, productPrice);

                Console.WriteLine("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrdemItem odItem = new OrdemItem(quantity, productPrice, product);

                od.AddItem(odItem);


            }
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine(od);




        }
    }
}