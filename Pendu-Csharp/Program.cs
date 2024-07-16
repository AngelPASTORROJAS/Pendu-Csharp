using Pendu_Csharp.Classes;

Console.ForegroundColor = ConsoleColor.White;
bool end = false;
while (!end)
{
    new Game();
    string modifyNbEssais = Utils.InputString("\nVoulez-vous rejouer ?Y/n\n", "Erreur de saisi!", true, ["y", "Y", "n", "N"]);
    if (modifyNbEssais.ToUpper() == "N")
    {
        end = true;
    }
    Console.ReadKey();
    Console.Clear();
}