
public class HighDiscountStrategy : IDiscountStrategy
{
    public double ApplyDiscount(double amount)
    {
        return amount * 0.8; // 20% discount
    }
}
