using System;
using System.Collections.Generic;
using System.Text;

namespace IoC
{
    class DALFactory
    {
        public static IDAL getDAL()
        {
            return new DAL();
        }
    }
}
