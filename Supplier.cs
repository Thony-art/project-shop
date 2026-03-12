  class Supplier
{
    private string name;
    private string city;
    private string phone;
    public Supplier(string name,string city,string phone)
    {
        this.name=name;
        this.city=city;
        this.phone=phone;
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string City
    {
        get { return city; }
        set { city = value; }
    }
    public string Phone
    {
        get { return phone; }
        set { phone = value; }
    }
}