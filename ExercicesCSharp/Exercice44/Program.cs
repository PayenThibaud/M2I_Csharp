using System.Security;
using System.Threading.Channels;

bool vérification_adn(string chaines)
{
    bool verif = true;
    for (int i=0; i < chaines.Length; i++)
    {
        char nucleotide = chaines[i];
        if (nucleotide != 'a' && nucleotide != 't' && nucleotide != 'c' && nucleotide != 'g')
        {
            verif = false;
            break;
        }
    }
    return verif;
}

Console.WriteLine(vérification_adn("atcg"));

string saisie_adn(string chaines)
{
    bool test = vérification_adn(chaines);
    if (test)
    {
        return chaines;
    }
    else
    {
        return "chaine d'ADN non valide";
    }
}

Console.WriteLine(saisie_adn("atcg"));

double proportion(string chaine, string sequence)
{
    int count = 0;
    for (int i = 0; i <= chaine.Length - sequence.Length; i++)
    {
        string subsequence = chaine.Substring(i, sequence.Length);

        if (subsequence == sequence)
        {
            count++;
        }
    }

    double percentage = (double)count / ((double)chaine.Length - (double)sequence.Length + 1) * 100;

    return percentage;
}

Console.WriteLine(proportion("aaabbbtbaabebeb", "aa"));