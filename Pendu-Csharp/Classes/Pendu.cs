namespace Pendu_Csharp.Classes
{
    internal class Pendu
    {
        private char _masque;
        private int _nbEssais;
        private char[] _motATrouver;
        private char[] _motEssayer;
        private char[] _lettreEssai;

        public int NbEssais { get => _nbEssais; set => _nbEssais = value; }
        public char[] MotEssayer { get => _motEssayer; set => _motEssayer = value;  }

        public Pendu(char[] motATrouver, char masque, int nbEssais = 10)
        {
            _motATrouver = motATrouver;
            _masque = masque;
            _nbEssais = nbEssais;
            _motEssayer = GenererMasque(masque, motATrouver.Length);
            _lettreEssai = [];
        }

        public void TestChar(char lettre)
        {
            if (char.IsLetter(lettre) &&
                Utils.ArrayCharContainsToUpperChar(_motATrouver, lettre) &&
                !(Utils.ArrayCharContainsToUpperChar(_lettreEssai, lettre)))
            {
                //Console.WriteLine("La lettre est valide.");
                _lettreEssai.Append(lettre);
                // retirer le masque
                for (int i = 0; i < MotEssayer.Length; i++)
                {
                    if (Utils.IsSameToUpperChar(_motATrouver[i], lettre))
                    {
                        _motEssayer[i] = _motATrouver[i];
                    }
                }
            }
            else
            {
                // Console.WriteLine("La letrre est déjà découverte ou n'appartient pas au pendu.");
                _nbEssais--;
                _motEssayer.Append(lettre);
            }
            Console.WriteLine($"Le mot à trouver : {string.Join("",MotEssayer)}");
            Console.WriteLine($"Il vous reste {NbEssais} essais");
        }

        public bool TestWin()
        {
            return string.Join("",MotEssayer) == string.Join("",_motATrouver);
        }

        private static char[] GenererMasque(char lettre, int length)
        {
            return new string(lettre, length).ToCharArray();
        }
    }
}
