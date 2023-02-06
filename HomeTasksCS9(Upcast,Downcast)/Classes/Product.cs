using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTasksCS9_Upcast_Downcast_.Classes
{
    internal class Product
    {
        public int No;
        public string Name;
        public double Price;

        public void ShowInfo()
        {
            Console.WriteLine($"Name : {Name} - No : {No} - Price : {Price}");
        }
    }
}
