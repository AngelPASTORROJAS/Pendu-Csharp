namespace Pendu_Csharp.Classes
{
    internal class Game
    {
        public Game()
        {
            Console.WriteLine("=== Paramètres de partie ===\n");

            // Choix du mot et du masque
            char[] motATrouver = Utils.RandomWord();
            char masque = Utils.RandomMask();


            Pendu pendu = new Pendu(motATrouver, masque);

            string modifyNbEssais = Utils.InputString("Voulez-vous un nombre d'essais spécifique (10 par défaut) ? Y/n\n", "Erreur de saisi, vueillez", true, ["y", "Y", "n", "N"]);
            if (modifyNbEssais.ToUpper() == "Y")
            {
                int nbEssais = Utils.InputInt("Choisissez le nombre d'essais : ", "Votre saisie n'est pas un nombre!", true);
                pendu.NbEssais = nbEssais;
            }

            while (!pendu.TestWin() && pendu.NbEssais > 0)
            {
                char lettre = Utils.InputChar("Vueilliez saisir une lettre : ", "Votre saisie n'est pas une lettre!");
                pendu.TestChar(lettre);
            }

            if (pendu.TestWin())
            {
                Console.WriteLine("Bravo vous avez trouvez!");
            }
            else
            {
                Console.WriteLine("Belle partie!");
            }
        }
    }
}
