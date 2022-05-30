namespace CSClass
{
    class Product
    {
        public string name;
        public int price;

        public override string ToString()
        {
            return name + " : " + price;
        }
    }
}