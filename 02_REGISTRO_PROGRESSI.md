=== AGGIORNAMENTO REGISTRO ===
[STATO ATTUALE]
Modulo corrente: 1 — Basi di C#
Lezione corrente: Step sequencer (es. 6): tappe A e B fatte con una traccia e un solo giro; array 1D di bool; scope, const, debugger
Prossimo argomento: tappa C (ripetere il giro con while finché l'utente esce), tappa D (metodo per stampare la traccia, .Length al posto del 16, TryParse nel metodo); poi array 2D (4 tracce x 16 step) ripartendo da zero e con più calma; poi foreach e metodi con parametri su casi nuovi; esame del modulo 1
Compiti in sospeso: richiamo a freddo (contatore, TryParse + range, switch su enum, scritti senza guardare); tappa C step sequencer; commit/push dell'esercizio; diario di studio; esercizio switch su VoceMenu (facoltativo); metronomo (facoltativo, riprendibile)
Sessioni svolte: 7
Ore totali (stima): 20,5

[CHECKBOX DA SPUNTARE]
- Modulo 1 > Argomenti > switch / case / break / default [x] — verificato con esercizio SoundCategory e caso Dialogue
- Modulo 1 > Argomenti > Scope (blocco, regole dentro/fuori, variabile del for) [x]
- Modulo 1 > Argomenti > const [x]
- Modulo 1 > Argomenti > Debugging (breakpoint, F5, F10, riga gialla, pannello Variables) [x]
- Modulo 1 > Argomenti > Git e GitHub di base [x] — già in uso (commit e push; repo audio-programming-journey)
- Modulo 1 > Argomenti > Array monodimensionale (new bool[16], indici da 0, default, Length) [x] — verificato con la traccia kick
- Modulo 1 > Argomenti > Operatori && || ! >= <= [x]
- Modulo 1 > Argomenti > Top-level statements / Main / enum in fondo al file [x]
- Modulo 1 > Argomenti > Array 2D (bool[,], GetLength) [ ] — introdotto troppo in fretta, da riprendere da zero
- Modulo 1 > Argomenti > Metodi con parametri e return [ ] — da riverificare su casi nuovi
- Modulo 1 > Argomenti > foreach [ ] — da verificare
- Modulo 1 > Esercizi > Mini-esercizio switch su SoundCategory [x]
- Modulo 1 > Esercizi > 6. Step sequencer [ ] — tappe A e B fatte (una traccia, un giro); tappe C e D da fare

[LACUNE — nuove o aggiornate]
| # | Lacuna | Prima volta | Occorrenze | Esercizi mirati | Risolta? |
|---|---|---|---|---|---|
| 2 | Richiami di matematica base e calcolo a mente | 19/09/2026 | 5 (oggi nessun errore) | Prova quoziente × divisore prima di rispondere | Quasi |
| 3 | Confusione nome parametro / variabile esterna nei metodi | 24/09/2026 | 4 (oggi non emersa) | Metodi con parametri su casi nuovi, senza guida | Quasi — da riverificare con un metodo con parametri |
| 4 | Creare vs aggiornare una variabile; chiamare un metodo con () | 01/10/2026 | 5 (oggi 2: int contatore dentro il ciclo; Console.ReadLine senza parentesi, più ; dopo l'if) | Esercizio autonomo: tracciare variabili create e aggiornate; checklist errori del manuale cap. 11 | Parzialmente |
| 5 | Dal problema alla logica: cosa fuori dal ciclo e cosa dentro | 01/10/2026 | 5 (oggi: contatore previsto "1 e 2"; poi ricetta + traccia + tappa B scritte da solo, struttura corretta) | Ricetta 3 (menu con while), tappa C; 4 domande del manuale | Parzialmente — in miglioramento |
| 6 | Condizioni sui bordi e momento in cui il controllo avviene | 01/10/2026 | 7 (oggi: i vale 3 al termine del for, controllo dopo i++; range 0-15 corretto) | Test del bordo a mano; for: la condizione si controlla prima di ogni giro | Quasi |
| 7 | Metodo come azione che gira a ogni chiamata vs valore salvato in variabile | 03/10/2026 | 1 (oggi non emersa) | Esercizi con un metodo casuale usato in più punti | Quasi |
| 8 | TryParse/TryGetValue e out: due canali separati; con bool false la variabile contiene il default | 04/10/2026 | 4 (oggi: "n darà errore in compilazione"; valore di default non noto, poi capito con la prova bool/n) | Esercizio con TryParse su input diversi, stampando separatamente bool e variabile | Parzialmente |
| 9 | Errore di compilazione vs runtime quando il dato è un valore (indice, chiave, input) | 04/10/2026 | 2 (oggi: indice 16 su array risposto "compilazione"; corretto: runtime; i fuori dal for e break mancante risposti bene) | Domande compilazione/runtime su casi nuovi; criterio "nome/forma o valore?" | Parzialmente |
| 10 | Cast (Tipo)variabile e numerazione enum | 04/10/2026 | 1 (oggi corretto: (int)Surface.Metal = 2) | Cast su esempi diversi, con e senza "=" | Quasi — oggi corretto |
| 11 | Scope: il confine è il blocco, anche per variabili dichiarate nelle parentesi del for | 08/10/2026 | 1 (spiegazione iniziale incompleta; la i fuori dal for risposta correttamente dopo il chiarimento) | Prevedere dove una variabile è visibile in 3 casi nuovi | Quasi |
| 12 | Richiamo dei pattern a memoria: per risolvere un problema rilegge vecchi programmi invece di richiamare la struttura | 08/10/2026 | 1 (dichiarato dall'utente a fine sessione) | Richiamo a freddo: riscrivere da zero senza guardare; manuale cap. 14; domande "per fare X mi serve Y" | No — nuova |

[LOG SESSIONE — riga da aggiungere in cima]
| # | Data | Modulo/Lezione | Cosa abbiamo fatto | Chiaro | Poco chiaro | Compiti |
|---|---|---|---|---|---|---|
| 7 | 08/10/2026 | M1 (switch, scope, const, debugger, array, step sequencer) | Ripasso TryParse/out, enum, Dictionary; switch rispiegato e verificato (SoundCategory + default); top-level statements e Main; scope (blocco, for, contatore dentro/fuori); const; debugger (breakpoint, F5/F10); Git già in uso; array 1D di bool; &&, ||, !; step sequencer tappe A e B; manuale PDF del modulo 1 | switch con default; scope del blocco; contatore fuori dal ciclo; range con &&; TryParse nell'if con controllo del range; debugger (riga gialla non ancora eseguita) | valori di default dei tipi; indice fuori array = runtime; for e visibilità della i; array 2D (introdotto troppo in fretta); recupero dei pattern a memoria | richiamo a freddo (3 programmi); tappa C step sequencer; commit/push; diario di studio |
=== FINE AGGIORNAMENTO ===