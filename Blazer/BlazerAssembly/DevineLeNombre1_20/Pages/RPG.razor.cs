namespace DevineLeNombre1_20.Pages
{
    public partial class RPG
    {
        public int Pdv { get; set; } = 100;
        public int PdvMonstre { get; set; } = 100;
        public int Dommage { get; set; }
        public int DommageMonstre { get; set; }
        public int LevelUp { get; set; } = 0;
        public int Arme { get; set; } = 0;
        public int Armure { get; set; } = 0;
        public bool JoueurMort { get; set; } = false;

        public void AttaquerMonstre(int choixRecompense)
        {
            Dommage = CalculerDommage();
            PdvMonstre = PdvMonstre - (Dommage + Arme);
            AttaquerJoueur();

            if (PdvMonstre <= 0)
            {
                PdvMonstre = 100;
                LevelUpMethod(choixRecompense); 
            }
        }

        public void AttaquerJoueur()
        {
            if (CalculerDommageMonstre() - Armure < 0)
            {
                DommageMonstre = 0;
            }
            else
            {
                DommageMonstre = CalculerDommageMonstre() - Armure;
            }
            Pdv -= DommageMonstre;

            if (Pdv <= 0)
            {
                JoueurMort = true;
            }
        }

        public void LevelUpMethod(int choix)
        {
            if (LevelUp == 0)
            LevelUp = 2;

            switch (choix)
            {
                case 1:
                    Armure = Armure + 10;
                    break;
                case 2:
                    Pdv = 100;
                    break;
                case 3:
                    Arme = Arme + 10;
                    break;
            }
            LevelUp = LevelUp - 1;
        }

    

    private int CalculerDommage()
        {
            Random random = new Random();
            return random.Next(11, 21);
        }

        private int CalculerDommageMonstre()
        {
            Random random = new Random();
            return random.Next(1, 11);
        }

        private void Recommencer()
        {
            Pdv = 100;
            JoueurMort = false;
        }
    }
}


