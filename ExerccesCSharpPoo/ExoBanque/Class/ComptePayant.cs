namespace ExoBanque.Class
{
    internal class ComptePayant : CompteBancaire
    {
        private decimal _coutOperation;

        public ComptePayant(Client client, decimal coutOperation, decimal solde = 0) : base(client, solde)
        {
            _coutOperation = coutOperation;
        }

        public override bool Depot(decimal value)
        {
            if (_solde - _coutOperation > 0)
            {
                _operation.Add(new Operation(value, TypeOperation.DEPOT));
                _solde += value - _coutOperation;

                return true;
            }
        }

        public override bool Retrait(decimal value)
        {
            if (_solde - _coutOperation - value < 0m) return false;

            _operation.Add(new Operation(value, TypeOperation.RETRAIT));
            _solde -= value - _coutOperation;

            return true;
        }
    }
}