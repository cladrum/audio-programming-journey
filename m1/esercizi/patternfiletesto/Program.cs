using System.Diagnostics;

string[] righe = File.ReadAllLines("pattern.txt");
bool[,] griglia = new bool[righe.Length, 16];
string[] nomi = new string[righe.Length];
int bpm = 30;
int swing = 70;

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
string continua = "s";
while (continua == "s")
{
    int tracciaDaModificare = 1000;
Console.WriteLine("Scrivi la traccia da modificare");
while (!int.TryParse(Console.ReadLine(), out tracciaDaModificare) || tracciaDaModificare < 0 || tracciaDaModificare >= righe.Length)
{
    Console.WriteLine("traccia inesistente. riprova");
}
int stepDaModificare = 1000;
Console.WriteLine("Scrivi lo step da modificare");
while (!int.TryParse(Console.ReadLine(), out stepDaModificare) || stepDaModificare < 0 || stepDaModificare >= griglia.GetLength(1))
{
    Console.WriteLine("step inesistente. riprova");
}
CambiaStep(griglia, tracciaDaModificare, stepDaModificare);
StampaStep(griglia, nomi);
Console.WriteLine("Vuoi modificare ancora? (s/n)");
continua = Console.ReadLine().ToLower();
}
Riproduci(griglia, nomi, bpm, swing);

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

static void Riproduci(bool[,] griglia, string[] nomi, int bpm, int swing)
{
    int durata = DurataStepinMS(bpm);
    int coppia = durata * 2;
    double percSwing = (double)swing / 100;
    int stepPari = (int)(coppia * percSwing);
    int stepDispari = coppia - stepPari;
    Stopwatch cronometro = Stopwatch.StartNew();
    int istanteIdeale = 0;
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
        if (i % 2 == 0)
        {
            istanteIdeale = istanteIdeale + stepPari;
        }
        else
        {
            istanteIdeale = istanteIdeale + stepDispari;
        }
    int attesa = istanteIdeale - (int)cronometro.ElapsedMilliseconds;
    if (attesa > 0)
    {
        Thread.Sleep(attesa);
    }
    }
}

static int DurataStepinMS (int bpm)
{
    return 60000 / bpm / 4;
}

static void CambiaStep(bool[,] griglia, int traccia, int step)
{
    griglia[traccia, step] = !griglia[traccia, step];
}