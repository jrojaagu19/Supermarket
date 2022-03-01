namespace Supermarket
{
    public class FixedPriceProduct : Product
    {
        

        public override decimal ValueToPay()
        {
            decimal value = 0;
             value=(Price*(decimal)Tax)+Price;

            return value;  
        }
 

        public override string ToString()
        {
            return base.ToString()  + 
                $" \n\t Price......:{$"{Price:C2}",14}" +
                $" \n\t Tax........:{$"{Tax:P2}",14}"+
                $" \n\t Value......:{$"{ValueToPay():C2}",14}";
        }
    }
}
