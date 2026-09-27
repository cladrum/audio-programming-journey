int bpm = 120;
float secondiPerBattito = 60f / bpm;
float secondiPerCroma = secondiPerBattito/2;
float secondiPerSemicroma = secondiPerBattito/4;

Console.WriteLine   (secondiPerBattito);
Console.WriteLine(secondiPerCroma);
Console.WriteLine(secondiPerSemicroma);

Console.WriteLine($"La Croma è di {secondiPerCroma} secondi");
Console.WriteLine($"La Semicrome è di {secondiPerSemicroma} secondi");

float db = -20f;
float lineare = MathF.Pow(10, db / 20);

Console.WriteLine(lineare);

float LinearToDb(float ValoreLineare)
{
    return 20 * MathF.Log10(ValoreLineare);
}

float dbDiRitorno = LinearToDb(lineare);
Console.WriteLine(dbDiRitorno);

float DbToLinear(float ValoreDb)
{
   return MathF.Pow(10, db / ValoreDb);
}

for (int i = 1; i < 5; i++)
{
    Console.WriteLine($"Battito {i} durata: {secondiPerBattito} secondi");
}

float durata = secondiPerBattito;
while (durata > 0.05)
{
    Console.WriteLine($"durata = {durata}");
    durata = durata /2;
}

float[] volumiTracce = { -6f, -9f, -14f };
foreach (float volumi in volumiTracce)
{
    Console.WriteLine($"{volumi}");
}

float tempo = bpm;
if (tempo >= 120)
{
    Console.WriteLine($"Tempo veloce");
}
else
{
    Console.WriteLine($"Tempo lento");
}

for (int i = 0; i < 16; i++)
{
    if (i % 4 == 0)
    {
        Console.WriteLine($"Step {i} Inizio Battuta");
    }
else
{
    Console.WriteLine($"Step {i}");
    
}
}