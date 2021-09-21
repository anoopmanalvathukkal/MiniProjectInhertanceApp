using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjectInhertance
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<InventoryItemModel> inventory = new List<InventoryItemModel>();
            List<IRentalable> rentable = new List<IRentalable>();
            List<IPurchase> purchasable = new List<IPurchase>();

            var vehicle = new VehicleModel { DealerFee = 25, ProductName = "Kia Optima" };
            var book = new BookModel { NumberOfPages = 100, ProductName = "A Tale of two cities" };
            var excavator = new ExcavatorModel { ProductName = "Bulldozer", QuantityInStock = 2 };


            rentable.Add(vehicle);
            rentable.Add(excavator);

            purchasable.Add(book);
            purchasable.Add(vehicle);

            //rentable
            Console.Write("Do you want to purchase or rent (purchase / rent ");
            string rentDesition = Console.ReadLine();

            if (rentDesition.ToLower() == "rent")
            {
                foreach (var item in rentable)
                {
                    Console.WriteLine($"Item: {item.ProductName}");

                    //rent
                    Console.Write("Do you want to rent this item (yes / no ");
                    string wantToRent = Console.ReadLine();

                    if (wantToRent.ToLower() == "yes")
                    {
                        item.Rent();
                    }

                    //return
                    Console.Write("Do you want to return this item (yes / no ");
                    string wantToReturn = Console.ReadLine();

                    if (wantToReturn.ToLower() == "yes")
                    {
                        item.ReturnRental();
                    }

                }
            }
            else
            {
                foreach (var item in purchasable)
                {
                    Console.WriteLine($"Item: {item.ProductName}");

                    //
                    Console.Write("Do you want to purchase or not (yes / no) ");
                    string wantToPurchase = Console.ReadLine();

                    if (wantToPurchase.ToLower() == "yes")
                    {
                        item.Purchase();
                    }

                }

            }

            Console.WriteLine("We are done!");
            //stay
            Console.ReadKey(true);
        }
    }

}
