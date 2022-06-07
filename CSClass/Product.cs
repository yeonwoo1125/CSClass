namespace CSClass
{
    class Product
    {
        public static int count = 0;
        public string name;
        public int price;
        public int id = -1;

        public Product()
        {
        }

        public Product(string name, int price)
        {
            this.id = count++;
            this.name = name;
            this.price = price;
        }

        public override string ToString()
        {
            return name + " : " + price;
        }
    }
}