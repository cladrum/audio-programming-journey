# Console Drum Machine

Una drum machine scritta in C# per studiare. Non produce suono: la riproduzione è simulata in console.

## Cosa fa

- Legge il pattern dal file `pattern.txt` (con `File.ReadAllLines` e `Split` con `RemoveEmptyEntries`)
- Mostra a schermo il pattern, anche dopo le modifiche
- Permette di modificare il pattern da input, ma non mentre è in riproduzione
- Applica lo swing; BPM e swing si impostano nel codice, non da input
- Riproduce il pattern a tempo, compensando con uno Stopwatch il ritardo che si accumula tra uno step e l'altro

## Come si avvia

Serve il .NET SDK (scritto con la versione 10). Dalla cartella del progetto, quella che contiene il file `.csproj`, scrivi nel terminale:

```
dotnet run
```

`pattern.txt` deve trovarsi nella stessa cartella.