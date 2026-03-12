   class Item
{
    private string name;
    private double price;
    private int quantity;
     
    public Item( string name,double price,int quantity)
    {
        this.name=name;
        this.price=price;
        this.quantity=quantity;
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public double Price
    {
        get { return price; }
        set { price = value; }
    }
    public int Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }
}