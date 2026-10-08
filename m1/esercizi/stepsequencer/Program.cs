bool[] kick = new bool[16];



Console.WriteLine("Scrivi quale step vuoi modificare");

if (int.TryParse (Console.ReadLine(), out int scelta) && scelta >= 0 && scelta < 16)
{
    kick[scelta] = !kick[scelta];
}
else
{
    Console.WriteLine("Valore non valido");
}

for (int i = 0; i < 16; i++)
{
    if (kick[i] == true)
    {
        Console.Write("o");
    }
    else
    {
        Console.Write("-");
    }
}

Console.WriteLine();