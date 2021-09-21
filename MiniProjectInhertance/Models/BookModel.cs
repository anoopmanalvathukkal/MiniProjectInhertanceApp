using System;

namespace MiniProjectInhertance
{
    public class BookModel : InventoryItemModel, IPurchase
    {
        public int NumberOfPages { get; set; }

        public void Purchase()
        {
            QuantityInStock -= 1;
            Console.WriteLine("This book has been purchaed");
        }
    }

}
