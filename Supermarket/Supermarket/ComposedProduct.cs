
using System.Collections;


namespace Supermarket
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }

        public IList Products { get; set; }

        
        
        public override decimal ValueToPay()
        {
            decimal accountant = 0,Discount1;
            decimal value = 0;
            foreach (Product product in Products)
            {

                accountant = product.ValueToPay();
                Discount1 = accountant * (decimal)Discount;
                value += accountant - Discount1;
            }
            return value ;
        }
        

        public override string ToString()
        {
            string nameProduct = null;
            foreach (Product product in Products)
            {
                nameProduct+= product.Description + ", " ;

            }
                 
                return base.ToString()  +
                $" \n\t Products...:{$"{nameProduct}",14}" +
                $" \n\t Discount...:{$"{Discount:P2}",14}" +
                $" \n\t Value......:{$"{ValueToPay():C2}",14}" ;
        }


    }
}
