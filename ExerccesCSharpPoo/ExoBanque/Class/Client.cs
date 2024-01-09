namespace ExoBanque.Class
{
    internal class Client
    {
        private static int _counter = 0;

        private int _id;
        private string _nom;
        private string _prenom;
        private string _numTelephone;
        private List<CompteBancaire> _compte;

        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public string NumTelephone { get => _numTelephone; set => _numTelephone = value; }
        public List<CompteBancaire> Compte { get => _compte; set => _compte = value; }
        public Client(string nom, string prenom, string numTelephone)
        {
            _id = ++_counter;
            _compte = new List<CompteBancaire>();

            _nom = nom;
            _prenom = prenom;
            _numTelephone = numTelephone;
        }
    }
}