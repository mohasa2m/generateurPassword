using System;

namespace essaye_de_moha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int NB_MOT_DE_PASSE = 10;
            int longueurMotDePasse = outils.DemanderNombrePositifNonNul("Longueur du mot de passe: ");

            Console.WriteLine();

            int choixAlphabet = outils.DemanderNombreEntre("Vous voulez un mot de passe avec:\n" +
                "1- Uniquement avec des caractères en minuscules\n" +
                "2- Des caractères en majuscules et minuscules\n" +
                "3- Des caractères et des chiffres\n" +
                "4- Caractères, chiffres et caractères spéciaux\n" +
                "Votre choix : ", 1, 4);

            string minuscule = "abcdefghijklmnopqrstuvwxyz";
            string majuscule = minuscule.ToUpper();
            string chiffres = "123456789";
            string caracteresSpeciaux = "#&+-";
            string alphabet;
            string motDePasse = "";
            Random rand = new Random();



            if (choixAlphabet == 1)
                alphabet = minuscule;
            else if (choixAlphabet == 2)
                alphabet = minuscule + majuscule;
            else if (choixAlphabet == 3)
                alphabet = minuscule + majuscule + chiffres;
            else
                alphabet = minuscule + majuscule + chiffres + caracteresSpeciaux;

            int longueurAlphabet = alphabet.Length;

            for (int j= 0; j < NB_MOT_DE_PASSE; j++)
            {
                motDePasse = "";
                for (int i = 0; i < longueurMotDePasse; i++)
                {
                    int index = rand.Next(0, longueurAlphabet);
                    motDePasse += alphabet[index];
                }

                Console.WriteLine("Mot de passe: " + motDePasse);
            }
            

  
        }
    }
}