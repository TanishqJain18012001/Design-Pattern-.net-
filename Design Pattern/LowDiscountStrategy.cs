
public class LowDiscountStrategy : IDiscountStrategy
{
    public double ApplyDiscount(double amount)
    {
        return amount * 0.9; // 10% discount
    }
}
