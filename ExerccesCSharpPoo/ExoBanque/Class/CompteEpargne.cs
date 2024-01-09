namespace ExoBanque.Class
{
    internal class CompteEpargne : CompteBancaire
    {
        private float _tauxInterets;

        public float TauxInterets { get => _tauxInterets; set => _tauxInterets = value; }

        public CompteEpargne(Client client, float tauxInterets, decimal solde = 0) : base(client, solde)
            {
            _tauxInterets = tauxInterets;
            }

        public override bool Depot(decimal value)
        {
            throw new NotImplementedException();
        }

        public override bool Retrait(decimal value)
        {
            throw new NotImplementedException();
        }

        public void Epargner()
        {
            _solde += (decimal)_solde * (decimal)_tauxInterets;
        }
    }
}