int scelta = 0;
const float minDb = -60f;
const float maxDb = 6f;
Console.WriteLine("Scegli l'azione || 1 - Da dB a Lineare || 2 - Da Lineare a dB || 3 - Esci");
bool ok = int.TryParse(Console.ReadLine(), out scelta);

while (scelta != 3)
{
    switch (scelta)
{
    case 1:
        bool ok2 = false;
        float db2 = 100f;
        while (!ok2 || db2 < minDb || db2 > maxDb)
            {
                Console.WriteLine("Scrivi il numero di dB");
                ok2 = float.TryParse(Console.ReadLine(), out db2);
                if (!ok2 || db2 < minDb || db2 > maxDb)
                {
                    Console.WriteLine("Valore non accettato. Riprova");
                }
            }
        float lineare = DbToLinear(db2);
        Console.WriteLine($"Il volume lineare è {lineare:F4}"); 
    break;
    case 2:
        bool ok3 = false;
        float linear2 = 100f;
        while (!ok3 || linear2 < 0)
        {
            Console.WriteLine("Scrivi il Valore Lineare");
            ok3 = float.TryParse(Console.ReadLine(), out linear2);
            if (!ok3 || linear2 < 0)
            {
                Console.WriteLine("Valore non accettato. Riprova");                
            }
        }
        float db = LinearToDb(linear2);
        Console.WriteLine($"I dB sono {db:F2}");
    break;
    default:
        Console.WriteLine("Valore non Valido");
    break;
}
Console.WriteLine("Scegli l'azione !! 1 - Da dB a Lineare || 2 - Da Lineare a dB || 3 - Esci");
bool ok4 = int.TryParse(Console.ReadLine(), out scelta);
}

Console.WriteLine("Ciao");


static float DbToLinear(float db)
{
    float linear = (float)Math.Pow(10, db / 20);
    return linear;
}

static float LinearToDb(float linear)
{
    float dbOk = (float)(20 * Math.Log10(linear));
    dbOk = Math.Max(dbOk, minDb);
    return dbOk;
}

