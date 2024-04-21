
using System;

class Program
{
    static void Main(string[] args)
    {
        ShoppingCart cart = new ShoppingCart(new NoDiscountStrategy());

        // Customer with membership card
        Console.WriteLine("Total amount for membership card holder: $100");
        cart.SetDiscountStrategy(new LowDiscountStrategy());
        Console.WriteLine("Discounted amount: $" + cart.CalculateDiscountedAmount(100));

        // Employee
        Console.WriteLine("\nTotal amount for employee: $100");
        cart.SetDiscountStrategy(new HighDiscountStrategy());
        Console.WriteLine("Discounted amount: $" + cart.CalculateDiscountedAmount(100));

        // Customer with no card
        Console.WriteLine("\nTotal amount for non-member: $100");
        cart.SetDiscountStrategy(new NoDiscountStrategy());
        Console.WriteLine("Discounted amount: $" + cart.CalculateDiscountedAmount(100));
    }
}
