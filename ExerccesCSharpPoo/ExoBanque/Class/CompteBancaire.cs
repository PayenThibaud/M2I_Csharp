namespace ExoBanque.Class
{
    internal abstract class CompteBancaire
    {
        protected decimal _solde;
        protected Client _client;
        protected List<Operation> _operation;

        public decimal Solde { get => _solde; set => _solde = value; }
        public Client Client { get =>  _client; set => _client = value;}
        public List<Operation> Operation { get => _operation; set => _operation = value; }

        protected CompteBancaire(Client client)
        {
            _client = client;
            _solde = 0m;
            _operation = new ();
        }

        protected CompteBancaire(Client client, decimal SoldeInitial) : this(client)
        {
            _solde = SoldeInitial;
        }

        public abstract bool Depot(decimal value);
        public abstract bool Retrait(decimal value);
        public void AfficherOperationSolde()
        {
            if (_operation.Count > 0)
            {
                Console.WriteLine("\n=== Liste des opérations ===");
                foreach (var o in _operation)
                {
                    Console.WriteLine(o);
                }
                
            }
            else
            {
                Console.WriteLine("Il n'y a pas encore eu d'opération sur ce compte.");
            }
            Console.WriteLine($"Solde du compte: {_solde} euros");
        }
    }
}