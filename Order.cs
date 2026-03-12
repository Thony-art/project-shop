   class Order
{
    private int orderNumber;
    private double totalAmount;
    private bool isPaid;

    public Order(int orderNumber, double totalAmount, bool isPaid)
    {
        this.orderNumber = orderNumber;
        this.totalAmount = totalAmount;
        this.isPaid = isPaid;
    }
    public int GetOrderNumber()
    {
        return orderNumber;
    }
    public void SetOrderNumber(int orderNumber)
    {
        this.orderNumber = orderNumber;
    }
    public double GetTotalAmount()
    {
        return totalAmount;
    }
    public void SetTotalAmount(double totalAmount)
    {
        this.totalAmount = totalAmount;
    }
    public bool IsPaid()
    {
        return isPaid;
    }
    public void SetIsPaid(bool isPaid)
    {
        this.isPaid = isPaid;
    }
}