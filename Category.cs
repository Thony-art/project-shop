  class Category
{
    private string name;
    private string description;
    public Category(string name,string description)
    {
        this.name=name;
        this.description=description;
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string Description
    {
        get { return description; }
        set { description = value; }
    }
}