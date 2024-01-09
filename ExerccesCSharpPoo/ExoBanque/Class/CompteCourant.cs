namespace ExoBanque.Class
{
    internal class CompteCourant : CompteBancaire
    {
        public CompteCourant(Client client, decimal solde = 0m) : base(client, solde)
        {

        }

        public override bool Depot(decimal value)
        {
            _operation.Add(new Operation(value, TypeOperation.DEPOT));
            return true;
        }
        public override bool Retrait(decimal value)
        {
            if (_solde - value < 0) return false;

            _operation.Add(new Operation(value, TypeOperation.RETRAIT));
            return true; 
        }
    }
}