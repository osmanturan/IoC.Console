using System;
using System.Collections.Generic;
using System.Text;

namespace IoC
{
    class newDbDAL : IDAL
    {
        public List<Product> GetProducts()
        {
            return new List<Product>()
          {
              new Product { ID = 1, Name = "new DB Milk", Price = 2, stockSize = 1000 },
              new Product { ID = 2, Name = "new DB Cheese", Price = 4, stockSize = 1000 },
              new Product { ID = 3, Name = "new DB Ball", Price = 1, stockSize = 1000 },
              new Product { ID = 4, Name = "new DB Basket", Price = 1, stockSize = 1000 },
              new Product { ID = 5, Name = "new DB Mouse", Price = 3, stockSize = 1000 }
            };
        }
    }
}
