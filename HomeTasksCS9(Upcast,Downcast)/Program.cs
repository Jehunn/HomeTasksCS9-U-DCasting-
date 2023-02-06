using HomeTasksCS9_Upcast_Downcast_.Classes;
using System;

namespace HomeTasksCS9_Upcast_Downcast_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Store store = new Store();

            Product pr1 = new Product()
            {
                Name = "Sirab",
                No = 7,
                Price = 1.5
            };

            Dairy dairy = new Dairy()
            {
                Name = "Pendir",
                No = 3,
                Price = 9
            };

            Drink drink = new Drink()
            {
                Name = "Cappy",
                No = 23,
                Price = 2
            };

            Product pr3 = drink;

            //Console.WriteLine(pr3.Price);

            Product product = new Product();
            Product[] product2 = new Product[0];
            string opr;
            do
            {
                Console.WriteLine("               MENU               ");
                Console.WriteLine("\n1: Drink product elave etmek");
                Console.WriteLine("2: Dairy product elave etmek");
                Console.WriteLine("3: Butun productlara baxmaq");
                Console.WriteLine("4: Product-i nomre ile axtarmaq");
                Console.WriteLine("5: Drink productlara baxmaq");
                Console.WriteLine("6: Dairy productlara baxmaq");
                Console.WriteLine("7: Ada göre axtarıs etmek");
                Console.WriteLine("8: Qiymet araligina gore axtaris et");
                Console.WriteLine("9: Siyahidan mehsulu silmek");
                Console.WriteLine("0: Menyudan cix");
                Console.WriteLine("Zehmet olmasa emeliyyat secin.");
                opr = Console.ReadLine();

                switch (opr)
                {
                    case "1":
                        var dr = AddDrinkProduct();
                        store.AddProduct(dr);
                        break;
                    case "2":
                        var dy = AddDairyProduct();
                        store.AddProduct(dy);
                        break;
                    case "3":
                        foreach (Product item in store.products)
                        {
                            item.ShowInfo();
                        }
                        break;
                    case "4":
                        Console.WriteLine("No daxil edin");
                        string intString = Console.ReadLine();
                        int no = Convert.ToInt32(intString);
                        try
                        {
                            var wantedProduct = store.GetProductByNo(no);
                            wantedProduct.ShowInfo();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"-{no} bir nomreli product tapilmadi-");
                        }
                        break;
                    case "5":
                        foreach (Drink item in store.products)
                        {
                            item.DrinkProductsInfo();
                        }
                        break;
                    case "6":
                        foreach (Dairy item in store.products)
                        {
                            item.DairyProductsInfo();
                        }
                        break;
                    case "7":
                        Console.WriteLine("Axtardiginiz mehsulun adini daxil edin: ");
                        string name = Console.ReadLine();
                        try
                        {
                            foreach (var item in store.products)
                            {
                                if (item.Name == name)
                                {
                                    item.ShowInfo();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            throw new ProductNotFoundException("-Bele bir product tapila bilmedi-");
                        }
                        break;
                    case "8":
                        Console.WriteLine("Min qiymet:");
                        string minPrice = Console.ReadLine();
                        double minprice = Convert.ToDouble(minPrice);

                        Console.WriteLine("Max qiymet:");
                        string maxPrice = Console.ReadLine();
                        double maxprice = Convert.ToDouble(maxPrice);

                        try
                        {
                            foreach (var item in store.products)
                            {
                                if (item.Price < maxprice && item.Price > minprice)
                                {
                                    item.ShowInfo();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            throw new ProductNotFoundException($"-Bele bir product tapila bilmedi-");
                        }
                        break;
                    case "9":
                        Console.WriteLine("Silmek istediyiniz mehsulun No-sini daxil edin:");
                        int no1 = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            foreach (var item in store.products)
                            {
                                if (item.No != no1)
                                {
                                    Array.Resize(ref product2, product2.Length + 1);
                                    product2[product2.Length - 1] = item;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            throw new ProductNotFoundException($"-Olmayan product-i silmek mumkun deyil-");
                        }
                        break;


                    case "0":
                        Console.WriteLine("Ugurlar !");
                        break;
                    default:
                        Console.WriteLine("-Seciminiz yanlisdi.Zehmet olmasa,yeniden secim edin-");
                        break;
                }
            } while (opr != "0");
        }



        static Product AddDairyProduct()
        {
            Console.WriteLine("Mehsul nomresi elave edin");
            string Num = Console.ReadLine();
            int num = Convert.ToInt32(Num);

            Console.Write("\nName: ");
            string Name1 = Console.ReadLine();

            string fatpercent;
            double FatPercent;
            do
            {
                Console.Write("\nFatPercent: ");
                fatpercent = Console.ReadLine();
            } while (!double.TryParse(fatpercent, out FatPercent));

            string priceStr;
            double Price;
            do
            {
                Console.Write("\nPrice: ");
                priceStr = Console.ReadLine();
            } while (!double.TryParse(priceStr, out Price));


            Dairy dairy = new Dairy
            {
                No = num,
                Name = Name1,
                Price = Price,
                FatPercent = FatPercent
            };

            return dairy;
        }




        static Product AddDrinkProduct()
        {
            Console.WriteLine("Mehsul nomresi elave edin");
            string Num = Console.ReadLine();
            int num = Convert.ToInt32(Num);

            Console.Write("\nName: ");
            string Name1 = Console.ReadLine();

            string alcoholpercent;
            double AlcoholPercent;
            do
            {
                Console.Write("\nAlcoholPercent: ");
                alcoholpercent = Console.ReadLine();
            } while (!double.TryParse(alcoholpercent, out AlcoholPercent));

            string priceStr;
            double Price;
            do
            {
                Console.Write("\nPrice: ");
                priceStr = Console.ReadLine();
            } while (!double.TryParse(priceStr, out Price));


            Drink drink = new Drink
            {
                No = num,
                Name = Name1,
                Price = Price,
                AlcoholPercent = AlcoholPercent
            };

            return drink;
        }
    }
}
