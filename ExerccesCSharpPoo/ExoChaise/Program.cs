using ExoChaise.Class;

List<Chaise> list = new List<Chaise>()
{
    new Chaise(),
    new Chaise(),
    new Chaise(8, "Plastic", "noir"),
    new Chaise(12, "Plastoc", "Blanc"),
    new Chaise(1, "béton", "Rouge"),
};

foreach (Chaise a in list)
{
    a.Afficher();
}