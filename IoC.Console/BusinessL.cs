using System;
using System.Collections.Generic;
using System.Text;

namespace IoC
{
    class BusinessL
    {
        private IDAL _dal { get; set; }

        public BusinessL(IDAL dal)
        {
            _dal = dal; // DALFactory.getDAL();
        }

        public List<Product> GetProducts()
        {
           return _dal.GetProducts();
        }
    }
}
