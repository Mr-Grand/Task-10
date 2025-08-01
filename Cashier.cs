﻿namespace Task_10;

public static class Cashier
{
    public static double CalculatePrice(IReadOnlyList<ProductTypes> buyerBasket)
    {
        double summ = 0;
        foreach (var item in buyerBasket)
        {
            summ += ProductsCatalog.GetProductPrice(item);
        }

        return Math.Round(summ, 2);
    }

    public static void ComparePriceAndMoney(Buyer buyer)
    {
        if (buyer.OwnedMoney < CalculatePrice(buyer.GetBuyerBasket()))
        {
            buyer.BalanceBusket();
        }
    }
}