using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTasksCS9_Upcast_Downcast_
{
    internal class ProductNotFoundException:Exception
    {
        public ProductNotFoundException(string message) : base(message)
        {
            Console.WriteLine("-Bele bir mehsul tapila bilmedi-");
        }
    }
}