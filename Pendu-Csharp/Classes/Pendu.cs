namespace Pendu_Csharp.Classes
{
    internal class Pendu
    {
        private string _masque;
        private int _nbEssais;
        private string _motATrouver;

        public Pendu(string motATrouver, string masque, int nbEssais=10)
        {
            _motATrouver = motATrouver;
            _masque = masque;
            _nbEssais = nbEssais;
        }

        public void TestChar(char lettre) { }
        public void TestWin() { }
        public void GenererMasque() { }
    }
}
