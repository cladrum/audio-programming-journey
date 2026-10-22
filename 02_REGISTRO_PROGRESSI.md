=== AGGIORNAMENTO REGISTRO ===
[STATO ATTUALE]
Modulo corrente: 1 — Basi di C#
Lezione corrente: Stato tra i giri (massimo, indice, serie), operatori logici || e !, metodi bool generici (IndiceValido), ToLower()
Prossimo argomento: ripasso breve; switch + enum; elenco argomenti M1 contro curriculum per vedere cosa manca; quiz di teoria M1; mini-progetto Console Drum Machine; esame modulo 1
Compiti in sospeso: push GitHub (IndiceValido, uscita con ToLower); rinomina parametri IndiceValido in indice/lunghezza e eventuale "a" in "traccia"; domanda array vuoto su CanalePiuForte (-1 contro 0); StampaTraccia con Write invece di WriteLine; richiamo a freddo in contesto nuovo (float.TryParse + range dB, scritto in chat, segnare prima stesura); diario; facoltativi: conteggio attraversamenti di soglia, switch su VoceMenu, metronomo
Sessioni svolte: 11
Ore totali (stima): 32,5

[CHECKBOX DA SPUNTARE]
- Modulo 1 > Argomenti > Metodi con return [x] — int, bool e float verificati (ContaStepAttivi, BpmValido, IndiceValido, CampioniPerSemicroma, DurataStepInMs, PiuForte, CanalePiuForte, PiuLungaSerie, ContaSerie)
- Modulo 1 > Argomenti > Operatori logici (&&, ||, !) [x] — || verificato su StepConAccento e riscritto dopo un errore sul while di uscita; ! usato correttamente nel menu; da consolidare: negazione di un "oppure"
- Modulo 1 > Argomenti > Stringhe e formattazione [ ] — iniziato: ToLower() per confronti senza distinzione maiuscole/minuscole
- Modulo 1 > Argomenti > Pattern "ricordo il migliore finora" [x] — massimo e indice (float.NegativeInfinity, for con indice); da consolidare in contesto nuovo
- Modulo 1 > Argomenti > TryParse + range [ ] — il richiamo a freddo non è passato (usato come int senza out); da rifare in contesto nuovo

[LACUNE — nuove o aggiornate]
| # | Lacuna | Prima volta | Occorrenze | Esercizi mirati | Risolta? |
|---|---|---|---|---|---|
| 3 | Confusione nome parametro / variabile esterna nei metodi | 24/09/2026 | 7 (oggi nessuna nuova: IndiceValido usato con due argomenti diversi e provenienza dei valori spiegata bene) | Metodi con due parametri su casi nuovi | Quasi |
| 5 | Dal problema alla logica: cosa dentro e cosa fuori il ciclo; stato tra i giri | 01/10/2026 | 11 (oggi: contatore per impaginare il foreach non venuto da solo; livelloPiuForte dichiarato dentro il for su CC; in chat "la metto dentro il foreach"; ContaSerie non gestiva la fine dell'array, trovato con prova a mano; return dentro il foreach ammesso come svista, motivo spiegato bene dopo) | Pseudocodice; prove a mano dei giri; domanda "cosa succede alla fine?" | Parzialmente — in miglioramento |
| 6 | Bordi e indici (ordinale contro indice, verso dei confronti) | 01/10/2026 | 12 (oggi: nel 241 confronto letto al contrario; LivelloFuoriRange con >= e <= invece di > e <) | Su richiesta dell'utente niente più verifiche sistematiche: correggere solo se sbaglia | Quasi |
| 9 | Compilazione vs runtime quando il dato è un valore | 04/10/2026 | 5 (nessuna nuova) | — | Quasi |
| 12 | Richiamo dei pattern a memoria | 08/10/2026 | 4 (oggi: int.TryParse scritto come se restituisse un int, senza out; WriteLine al posto di Write; StampaTraccia non trovato) | Richiamo in contesti nuovi, non riscrittura | No |
| 14 | Cosa porta un parametro: dati contro selezione | 17/10/2026 | 1 (nessuna nuova) | — | Quasi |
| 15 | Una condizione è già un valore bool | 18/10/2026 | 2 (oggi: == true tolto dopo domanda; if (stepAttivo) e return con || da verificare in autonomia) | Altri metodi bool su casi nuovi | Quasi |
| 16 | Ruolo delle variabili: valore del ciclo (sola lettura) contro variabile che aggiorno io; direzione dell'= | 22/10/2026 | 3 (oggi su CC: nuovoValore = valoreBpm al contrario; piuAlto = livello con variabile del foreach; out int ridichiarato a ogni giro; in chat spiegato correttamente che la variabile del foreach è sola lettura) | Esercizi con una variabile "record" dichiarata fuori e il valore del ciclo solo letto | Parzialmente |
| 17 | Negazione di un "oppure" (diverso da A oppure da B = diverso da A e da B) | 22/10/2026 | 1 (oggi: while con || sempre vero; risolto con && e poi ToLower) | Contesto nuovo con controllo di uscita o di range | No |
| 18 | Leggere la consegna (valore contro indice) | 22/10/2026 | 1 (oggi: CanalePiuForte fatto prima come valore, poi come indice) | Rileggere la consegna prima di scrivere | Segnalata |

[LOG SESSIONE — riga da aggiungere in cima]
| # | Data | Modulo/Lezione | Cosa abbiamo fatto | Chiaro | Poco chiaro | Compiti |
|---|---|---|---|---|---|---|
| 11 | 22/10/2026 | M1 (metodi bool generici, || e !, stato tra i giri) | Verifiche a mano di BpmValido; IndiceValido nel menu; CampioniPerSemicroma e DurataStepInMs; || e !; while di uscita con ToLower; PiuForte, CanalePiuForte, PiuLungaSerie, ContaSerie; lavoro fino alle 18:05 circa svolto in parte con Claude Code in VS Code e incollato dopo; da lì in poi tutto scritto in diretta in chat (PiuLungaSerie, ContaSerie) | IndiceValido generico; ToLower; return dopo il ciclo; seriepiulunga = serie; ContaSerie con controllo dopo il ciclo | negazione di un "oppure"; stato tra i giri nei contesti nuovi; ruolo delle variabili nel foreach; TryParse a freddo | push; rinomina parametri; array vuoto su CanalePiuForte; Write in StampaTraccia; float.TryParse + range dB in chat; diario |
=== FINE AGGIORNAMENTO ===