using System;

namespace RefReturn
{
    class Product
    {
        private int price = 100;
        public ref int Getprice()
        {
            return ref price;
        }
        public void printprice()
        {
            Console.WriteLine($"Price:{price}");
        }
    }
    class MainApp
    { 
        static void Main(string[] args)
        {
            Product carrot = new Product();
            ref int ref_local_price = ref carrot.Getprice();
            int normal_local_price = carrot.Getprice();

            carrot.printprice();
            Console.WriteLine($"Ref Local Price :{ref_local_price}");
            Console.WriteLine($"Normal Local Price :{normal_local_price}");

            ref_local_price = 200;

            carrot.printprice();
            Console.WriteLine($"Ref Local Price :{ref_local_price}");
            Console.WriteLine($"Normal Local Price :{normal_local_price}");

        }
    }
}
