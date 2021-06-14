namespace Exercise2
{
    class Customer
    {
        public string Name { get; set; }
        public string City { get; set; }

        public int CustomerId { get; private set; }

        public Customer(int id)
        {
            CustomerId = id;
        }
        public override string ToString()
        {
            return "My name is " + Name + ", I live in " + City + ". My customer id is " + CustomerId;
        }
    }
}