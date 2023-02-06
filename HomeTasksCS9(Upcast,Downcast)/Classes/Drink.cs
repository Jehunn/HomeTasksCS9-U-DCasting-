using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTasksCS9_Upcast_Downcast_.Classes
{
    internal class Drink:Product
    {
        public double AlcoholPercent;




        public void DrinkProductsInfo()
        {
            Console.WriteLine($"No: {No}Name: {Name} - Price: {Price} - AlcoholPercent: {AlcoholPercent}");
        }
    }
}
