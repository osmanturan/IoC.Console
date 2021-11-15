using System;

namespace IoC
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessL bl = new BusinessL(new DAL());

            //It can be used for new DB
            //BusinessL bl = new BusinessL(new newDbDAL());

            var products = bl.GetProducts();

            foreach (var item in products)
            {
                Console.WriteLine(item.ID.ToString()+ " "+ item.Name+ " "+ item.Price.ToString()+ " "+ item.stockSize);
            }
            
            Console.ReadLine();
        }
    }
}
