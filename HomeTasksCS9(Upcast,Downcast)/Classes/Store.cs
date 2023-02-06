using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTasksCS9_Upcast_Downcast_.Classes
{
    internal class Store
    {
       
        public Product[] products =new Product[0];



        private int DairyProductCountLimit;
        private double AlcoholPercentLimit;

      



        public void AddProduct(Product product)
        {
            if(DairyProductCountLimit<=40 || AlcoholPercentLimit <= 25)
            {
               Array.Resize(ref products, products.Length + 1);
               products[products.Length - 1] = product;
            }
           
        }
        
        public bool HasProductByNo(int no)
        {
            foreach(var item in products)
            {
                if (item.No == no) return true;
            }
            return false;
        }

        public Drink[] GetDrinkProducts(Product[] dr)
        {

            Drink[] arr=new Drink[0];
            foreach(var drink in dr)
            {
                if(drink is Drink)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[arr.Length - 1] = (Drink)drink;
                }
            }
            return arr;
        }

        public Dairy[] GetDairyProducts(Product[] dy)
        {
            Dairy[] arr=new Dairy[0];
            foreach(var dairy in dy)
            {
                if(dairy is Dairy)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[arr.Length - 1] = (Dairy)dairy;
                }
            }
            return arr;
        }

        public Product GetProductByNo(int no)
        {
            foreach(var item in products)
            {
                if(item.No== no)
                {
                    return item;
                }
            }
            throw new ProductNotFoundException("-Bele bir product taila bilmedi-");
        }

        public Product[] RemoveProduct(Product[] product,int No)
        {
            Console.WriteLine("No daxil edin : ");
            int no = Convert.ToInt32(Console.ReadLine());
            Product[] product2= new Product[0];
            foreach(var item in products)
            {
                if(item.No != no)
                {
                    Array.Resize(ref product2,product2.Length+ 1);
                    product2[product2.Length-1] = item;
                }
            }
            return product2;
        }

    }
}
