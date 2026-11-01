string[] righe = File.ReadAllLines("pattern.txt");
bool[,] griglia = new bool[righe.Length, 16];
string[] nomi = new string[righe.Length];
int bpm = 30;

for (int t = 0; t < righe.Length; t++)
{
    string[] parti = righe[t].Split(' ', StringSplitOptions.RemoveEmptyEntries);
    nomi[t] = parti[0];
    for (int i = 0; i < parti[1].Length; i++) // Nell’indice parti[1][i], la prima coppia di [] sceglie la stringa tra le parti, la seconda sceglie il carattere dentro quella stringa.
{
    if (parti[1][i] == 'x')
    {
        griglia[t,i] = true;
    }
    else
    {
        griglia[t,i] = false;
    }
}
}
StampaStep(griglia, nomi);
Riproduci(griglia, nomi, bpm);

static void StampaStep(bool[,] griglia, string[] nomi)
{
    for (int t = 0; t < griglia.GetLength(0); t++)
    {
        Console.Write($"{nomi[t]} ");
        for (int i = 0; i < griglia.GetLength(1); i++)
        {
            if (griglia[t,i])
            {
                Console.Write("x");
            }
            else
            {
                Console.Write("-");
            }
        }
    Console.WriteLine();
    }
}

static void Riproduci(bool[,] griglia, string[] nomi, int bpm)
{
    int durata = DurataStepinMS(bpm);
    for (int i = 0; i < griglia.GetLength(1); i++)
    {
        Console.Write($"Step {i}: ");
        for (int t = 0; t < griglia.GetLength(0); t++)
        {
            if (griglia[t,i])
            {
                Console.Write($"{nomi[t]} ");
            }
        }
        Console.WriteLine();
        Thread.Sleep(durata);
    }
}

static int DurataStepinMS (int bpm)
{
    return 60000 / bpm / 4;
}