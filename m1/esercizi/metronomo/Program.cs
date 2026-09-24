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