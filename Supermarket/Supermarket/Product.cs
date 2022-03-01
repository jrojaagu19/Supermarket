namespace Supermarket
{
    public abstract class Product : IPay
    {


        public string Description { get; set; }

        public int Id { get; set; }

        public decimal Price { get; set; }

        public float Tax { get; set; }


        public abstract decimal ValueToPay();
        

        public override string ToString()
        {
            return $"{Id} - {Description}"; 
           
        }


    }
}
