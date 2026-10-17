using System.Diagnostics.Contracts;

bool[,] griglia = new bool[4, 16];
string[] nomi = { "kick", "snare", "hihat", "crash" };
for (int i = 0; i < nomi.Length ; i++)
{
    Console.WriteLine(i + " - " + nomi[i]);
}
Console.WriteLine("Scrivi quale traccia vuoi modificare o digita esci per uscire");

string menu = Console.ReadLine();

while (menu != "esci")
{
    if (int.TryParse(menu, out int sceltatraccia) && sceltatraccia >= 0 && sceltatraccia < griglia.GetLength(0))
    {
        Console.WriteLine("Scrivi quale step vuoi modificare");
        string sceltastep = Console.ReadLine();
        if (int.TryParse(sceltastep, out int step) && step >= 0 && step < griglia.GetLength(1))
        {
            griglia[sceltatraccia, step] = !griglia[sceltatraccia, step];
        }
        else
        {
            Console.WriteLine("Valore non valido");
        }
    }
    else
    {
        Console.WriteLine("Valore non valido");
    }
    Stampa(griglia, nomi);
                for (int a = 0; a < nomi.Length; a++)
{
    Console.WriteLine(nomi[a] + ": " + ContaStepAttivi(griglia,a) + " step attivi");
}
    Console.WriteLine("Scrivi quale traccia vuoi modificare o digita esci per uscire");
    for (int i = 0; i < nomi.Length ; i++)
{
    Console.Write(i + " - " + nomi[i] + " ");
    Console.WriteLine();
}
    menu = Console.ReadLine();
}


Console.WriteLine("Ciao");

static void Stampa(bool[,] griglia, string[] nomi)
{
    for (int t = 0; t < griglia.GetLength(0); t++)
    {
        Console.Write (t + " - " + nomi[t] + " ");
        for (int s = 0; s < griglia.GetLength(1); s++)
        {
            if (griglia[t, s] == true)
            {
                Console.Write("o");
            }
            else
            {
                Console.Write("-");
            }
        }
        Console.WriteLine();
    }
}


static int ContaStepAttivi(bool[,] griglia, int traccia)
{
    int contatore = 0;
    for (int stepp = 0; stepp < griglia.GetLength(1); stepp++)
    {
        if (griglia[traccia, stepp])
        {
            contatore++;
        }
    }
    return contatore;
}