namespace ExoBanque.Class
{
    internal class Operation
    {
        private static int _count = 0;

        private int _num;
        private decimal _montant;
        private TypeOperation _type;

        public int Num { get => _num; set => _num = value; }
        public decimal Montant { get => _montant; set => _montant = value; }
        internal TypeOperation Type { get => _type; set => _type = value; }

        public Operation(decimal montant, TypeOperation type)
        {
            _num = ++_count;
            _montant = montant;
            _type = type;
        }

        public override string ToString()
        {
            return $"{_num}.{Enum.GetName(_type)}";
        }
    }
}