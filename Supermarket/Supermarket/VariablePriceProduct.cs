namespace Supermarket
{
    public class VariablePriceProduct : Product
    {

        public string Measurement { get; set; }

        public float Quantity { get; set; }


        public override decimal ValueToPay()
        {
            decimal value = 0;
            value = (Price * (decimal)Quantity);
            return (value*(decimal)Tax)+ value;
        }

        public override string ToString()
        {
            return $" {base.ToString() }" +
                $" \n\t Measurerement:{$"{Measurement}"}" +
                $" \n\t Quantity...:{$"{Quantity:F2}",14}" +
                $" \n\t Price......:{$"{Price:C2}",14}" +
                $" \n\t Tax........:{$"{Tax:P2}",14}" +                
                $" \n\t Value......:{$"{ValueToPay():C2}",14}";
        }



    }
}
