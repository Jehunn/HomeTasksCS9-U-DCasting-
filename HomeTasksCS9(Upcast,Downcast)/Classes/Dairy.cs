using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTasksCS9_Upcast_Downcast_.Classes
{
    internal class Dairy:Product
    {
        public double FatPercent;



        public void DairyProductsInfo()
        {
            Console.WriteLine($"No: {No}Name: {Name} - Price: {Price} - Fat Percent: {FatPercent}");
        }

    }
}
