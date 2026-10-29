Dictionary<string, float> lista = new Dictionary<string, float>();

Console.WriteLine("1. Aggiungi suono | 2. Rimuovi suono | 3. Cerca suono | 4. Modifica volume | 5. Mostra suoni | 6. Esci");
int.TryParse(Console.ReadLine(), out int scelta);

while (scelta != 6)
{
    switch (scelta)
    {
        case 1:
        Console.WriteLine("Scrivi il suono da aggiungere");
        string chiaveDaAggiungere = Console.ReadLine().ToLower();
        if (!lista.ContainsKey(chiaveDaAggiungere))
        {
            Console.WriteLine("Scrivi db");
            if (float.TryParse(Console.ReadLine(), out float valoreDaAggiungere) && valoreDaAggiungere >= -80 && valoreDaAggiungere <= 12)
            {
                    lista.Add(chiaveDaAggiungere, valoreDaAggiungere);
            }
            else
            {
                Console.WriteLine("Valore non valido");
            }
        }
        else
        {
            Console.WriteLine("Suono già presente");
        }
        break;
        case 2:
        Console.WriteLine("Scrivi il suono da rimuovere");
        string suonoDaRimuovere = Console.ReadLine().ToLower();
        if (lista.Remove(suonoDaRimuovere))
        {
            Console.WriteLine("Rimosso");
        }
        else
        {
            Console.WriteLine("Suono non presente");
        }
        // come l'avevo scritto io con l'if che cerca non avendo capito che lista.remove già fa lo stesso lavoro in una riga sola
        // if (lista.ContainsKey(suonoDaRimuovere))
        // {
        //     lista.Remove(suonoDaRimuovere);
        // }
        // else
        // {
        //     Console.WriteLine("Suono non presente");
        // }
        break;
        case 3:
        Console.WriteLine("Scrivi il suono da cercare");
        string suonoDaCercare = Console.ReadLine().ToLower();
        if (lista.TryGetValue(suonoDaCercare, out float dbTrovato))
        {
            Console.WriteLine($"{suonoDaCercare}: {dbTrovato:F1} dB");
        }
        else
        {
        Console.WriteLine("Suono non presente");
        }
        // come l'avevo scritto io come sopra basta una riga
        // if (lista.ContainsKey(suonoDaCercare))
        // {
        //     Console.WriteLine($"{lista[suonoDaCercare]} dB");
        // }
        // else
        // {
        //     Console.WriteLine("Suono non presente");
        // }
        break;
        case 4:
        Console.WriteLine("Scrivi il suono da modificare");
        string suonoDaModificare = Console.ReadLine().ToLower();
        if (lista.ContainsKey(suonoDaModificare))
        {
            float nuovoVolume = 0;
            Console.WriteLine("Scrivi il nuovo volume");
            if (float.TryParse(Console.ReadLine(), out nuovoVolume) && nuovoVolume >= -80 && nuovoVolume <= 12)
            {
                lista[suonoDaModificare] = nuovoVolume;
            }
            else
            {
                Console.WriteLine("Valore non valido");
            }
        }
        else
        {
            Console.WriteLine("Suono non presente");
        }
        break;
        case 5:
        if (lista.Count > 0)
        {
            foreach (KeyValuePair<string, float> coppia in lista)
        {
            Console.WriteLine($"{coppia.Key}: {coppia.Value:F1} dB");
        }
        }
        else
        {
            Console.WriteLine("Nessun suono");
        }
        break;
        default:
        Console.WriteLine("Valore non valido");
        break;
    }

Console.WriteLine("1. Aggiungi suono | 2. Rimuovi suono | 3. Cerca suono | 4. Modifica volume | 5. Mostra suoni | 6. Esci");
int.TryParse(Console.ReadLine(), out scelta);
}
Console.WriteLine("Ciao");