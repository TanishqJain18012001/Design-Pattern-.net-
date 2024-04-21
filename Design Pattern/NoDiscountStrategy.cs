
public class NoDiscountStrategy : IDiscountStrategy
{
    public double ApplyDiscount(double amount)
    {
        return amount; // No discount
    }
}
