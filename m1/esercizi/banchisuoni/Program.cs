List<string> suoni = new List<string>();
int scelta = 0;

while (scelta != 4)
{
    Console.WriteLine("Scegli: 1 aggiungi, 2 rimuovi, 3 mostra, 4 esci");
    scelta = int.Parse(Console.ReadLine());

    if (scelta == 1)
    {
        Console.WriteLine("Hai scelto: aggiungi");
        Console.WriteLine("Scrivi il nome dello strumento da aggiungere");
        suoni.Add(Console.ReadLine());
    }
    else if (scelta == 2)
    {
        Console.WriteLine("Hai scelto: rimuovi");
        Console.WriteLine("Scrivi il nome dello strumento da rimuovere");
        string rimozione = Console.ReadLine();
        if (suoni.Remove(rimozione))
        {
            Console.WriteLine("Rimosso");
        }
        else
        {
            Console.WriteLine($"{rimozione} non trovato");
        }
    }
    else if (scelta == 3)
    {
        Console.WriteLine("Hai scelto: mostra");
        if (suoni.Count == 0)
        {
            Console.WriteLine("Nessun suono trovato");
        }
        else
        {
        foreach (string suono in suoni)
        {
            Console.WriteLine(suono);    
        }
        }
    }
    else if (scelta != 4)
    {
        Console.WriteLine("Scelta non valida");
    }
}

Console.WriteLine("Ciao!");