using System;

namespace MiniProjectInhertance
{
    public class ExcavatorModel : InventoryItemModel, IRentalable
    {
        public void Dig()
        {
            Console.WriteLine("I'm digging");
        }

        public void Rent()
        {
            QuantityInStock -= 1;
            Console.WriteLine( "This Excavator has been rented!");
        }

        public void ReturnRental()
        {
            QuantityInStock += 1;
            Console.WriteLine("This Excavator is returned!");
        }
    }

}
