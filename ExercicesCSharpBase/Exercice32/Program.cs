double valeur = 64;
char[] t1 = new char[26];
char caractere;

for (int i = 0; i <= 25; i++)
{
    valeur++;
    caractere = (char)valeur;
    t1[i] = caractere;
    string espace = string.Concat(Enumerable.Repeat(" ", i));
    Console.WriteLine($"{espace} {t1[i]}");
}
