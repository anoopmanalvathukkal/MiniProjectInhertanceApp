﻿namespace MiniProjectInhertance
{
    public interface IRentalable : IInventoryItem
    {
        void Rent();
        void ReturnRental();
    }

}
