 class Product
    {
        private string name;
        private double price;

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public string GetName()
        {
            return name;
         }
         public void SetName(string name)
         {
            this.name = name;
         }

          public double GetPrice()
        {
            return price;
        }
          public void SetPrice(double price)
        {
            this.price = price;
        }

 }