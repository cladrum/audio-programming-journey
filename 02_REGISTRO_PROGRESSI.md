=== AGGIORNAMENTO REGISTRO ===
[STATO ATTUALE]
Modulo corrente: 1 — Basi di C#
Lezione corrente: Metodi con valore di ritorno (int): ContaStepAttivi(griglia, traccia) scritto e chiamato in un ciclo nel Main, chiamata dentro WriteLine
Prossimo argomento: metodi con return di tipo bool (TracciaValida per il menu); richiamo a freddo; poi esame del modulo 1; mini-progetto Console Drum Machine
Compiti in sospeso: push + rinominare "a" in "traccia"; CampioniPerSemicroma(bpm, sampleRate) su caso nuovo; richiamo a freddo (StampaTraccia con foreach, TryParse + range); diario; TracciaValida (facoltativo); esercizio switch su VoceMenu (facoltativo); metronomo (facoltativo, riprendibile)
Sessioni svolte: 9
Ore totali (stima): 27,3

[CHECKBOX DA SPUNTARE]
- Modulo 1 > Argomenti > Metodi con return [x] — return di int verificato (DurataSemiminimaMs come esempio, ContaStepAttivi scritto); return di bool ancora da fare
- Modulo 1 > Argomenti > Metodi con parametri [x] — aggiornato: collegamento argomenti/parametri per posizione e tipo spiegato e verificato (variabile "a" fuori, "traccia" dentro)
- Modulo 1 > Esercizi > 6. Step sequencer [x] — aggiunto ContaStepAttivi con conteggio per traccia; GetLength nel menu sistemato

[LACUNE — nuove o aggiornate]
| # | Lacuna | Prima volta | Occorrenze | Esercizi mirati | Risolta? |
|---|---|---|---|---|---|
| 3 | Confusione nome parametro / variabile esterna nei metodi | 24/09/2026 | 6 (oggi: non capito perché la chiamata è (griglia, 1); poi usato "a" fuori / "traccia" dentro correttamente) | Metodo con due parametri su casi nuovi, senza guida (CampioniPerSemicroma) | Quasi |
| 5 | Dal problema alla logica: cosa dentro e cosa fuori | 01/10/2026 | 7 (oggi: primo ContaStepAttivi con due cicli contava tutta la griglia; motivo del ciclo unico attribuito a "quando lo chiamo"; contatore e return fuori dai cicli invece giusti) | Pseudocodice prima del C# quando si blocca | Parzialmente |
| 6 | Bordi e indici (ordinale contro indice) | 01/10/2026 | 9 (oggi: GetLength risposto 3 e 15 invece di 4 e 16; poi "terzo giro = indice 2" corretto) | "Quanti elementi vengono prima?" | Quasi |
| 9 | Compilazione vs runtime quando il dato è un valore | 04/10/2026 | 5 (oggi: argomenti in ordine invertito pensati come eseguibili, invece errore di compilazione per tipi) | Casi con indice max contro lunghezza; chiamate con tipi sbagliati | Quasi |
| 12 | Richiamo dei pattern a memoria | 08/10/2026 | 2 (richiamo a freddo ancora non svolto) | Richiamo a freddo: StampaTraccia, TryParse + range | No |
| 14 | Cosa porta un parametro: dati contro selezione | 17/10/2026 | 1 (pensava che passare la griglia indicasse già la traccia o desse la somma) | Metodi con un parametro "dati" e uno "quale" su casi nuovi | Quasi — oggi chiarito |

[LOG SESSIONE — riga da aggiungere in cima]
| # | Data | Modulo/Lezione | Cosa abbiamo fatto | Chiaro | Poco chiaro | Compiti |
|---|---|---|---|---|---|---|
| 9 | 17/10/2026 | M1 (metodi con return) | Ripasso GetLength/foreach/==; metodi con return (tipo al posto di void, return, chiamata come valore); ContaStepAttivi(griglia, traccia) corretto da due cicli a uno; ciclo nel Main con chiamata dentro WriteLine | int al posto di void; contatore e return fuori dal ciclo; chiamata usata come valore; void vs return; argomenti per posizione e tipo | perché un ciclo solo (motivo); griglia come dati vs selezione traccia; GetLength = quantità | push + rinomina; CampioniPerSemicroma; richiamo a freddo; diario; TracciaValida (facoltativo) |
=== FINE AGGIORNAMENTO ===