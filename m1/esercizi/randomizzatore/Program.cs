Random rng = new Random();
int db = randomDb();
int dbNuovo = randomDb();
int semitono = randomST();
int semitonoNuovo = randomST();

for (int i = 0; i < 10; i++)
{
    while (db == dbNuovo)
    {
        dbNuovo = randomDb();
    }
    db = dbNuovo;
    Console.WriteLine($"{i}. dB random");
    Console.WriteLine($"dB = {db}");
    while (semitono == semitonoNuovo)
    {
        semitonoNuovo = randomST();
    }
    semitono = semitonoNuovo;
    Console.WriteLine($"{i}. Semitono random");
    Console.WriteLine($"Semitono = {semitono}");
}

int randomDb()
{
    return rng.Next(-3 , 4);
}

int randomST()
{
    return rng.Next(-2, 3);
}

// come avrebbe scritto claude

// Random rng = new Random();

// int db = 100;        // valore fuori range: significa "nessun precedente"
// int semitono = 100;  // idem

// for (int i = 0; i < 10; i++)
// {
//     int dbNuovo = randomDb();
//     while (dbNuovo == db)
//     {
//         dbNuovo = randomDb();
//     }
//     db = dbNuovo;

//     int semitonoNuovo = randomST();
//     while (semitonoNuovo == semitono)
//     {
//         semitonoNuovo = randomST();
//     }
//     semitono = semitonoNuovo;

//     Console.WriteLine($"{i}. pitch {semitono} st, volume {db} dB");
// }

// int randomDb()
// {
//     return rng.Next(-3, 4);
// }

// int randomST()
// {
//     return rng.Next(-2, 3);
// }