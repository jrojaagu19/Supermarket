using System.Collections;

namespace Supermarket
{
    public class Invoice : IPay
    {

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public Invoice() { }

        private List<Product> _products = new List<Product>();

        public decimal ValueToPay()
        {
            decimal accountProducts = 0;
            foreach (Product product in _products)
            {
                accountProducts +=  product.ValueToPay();
            }

            return accountProducts;
        }



        public override string ToString()
        {
            Console.WriteLine("RECEIPT");
            Console.WriteLine("-------------------------------------------------");

            foreach (Product product in _products)
            {
                Console.WriteLine(product.ToString());
            }
            return $"                     ==============" +
                   "\n\t TOTAL:"+ $"{ $"{ValueToPay():C2}",20}";


        }
     }

 }

