=== AGGIORNAMENTO REGISTRO ===
[STATO ATTUALE]
Modulo corrente: 1 — Basi di C#
Lezione corrente: Progettazione della logica (ricetta in italiano → codice); while con condizione su valore; metodi senza parametri con return; clamp con if/else
Prossimo argomento: Array e List<T> (sintassi data per intero prima dell'uso), poi esercizi 4/6 del modulo 1
Compiti in sospeso: Esercizio 3 (nota MIDI → frequenza, ricetta prima del codice); esercizio autonomo ciclo + condizione con ricetta scritta prima; verifica repository GitHub (404) e push dei programmi pitch e nemico
Sessioni svolte: 4
Ore totali (stima): 9,5

[CHECKBOX DA SPUNTARE]
- Modulo 1 > Esercizi > 5. Randomizzatore pitch senza ripetizioni consecutive [x] — completato con l'aiuto di Copilot, struttura capita a posteriori
- Modulo 1 > Argomenti > Operatori di confronto (<, <=, >, >=) [x]
- Modulo 1 > Argomenti > Metodi: valore di ritorno (return), metodo senza parametri [x]
- Modulo 1 > Esercizi > Programma "nemico con HP" (while + metodo Danno + clamp) [x] — scritto autonomamente a partire dalla ricetta

[LACUNE — nuove o aggiornate]
| # | Lacuna | Prima volta | Occorrenze | Esercizi mirati | Risolta? |
|---|---|---|---|---|---|
| 2 | Richiami di matematica base e calcolo a mente | 19/09/2026 | 4 (oggi: `5 % 4` risposto 0 invece di 1; ma stime 100÷30 → 4 colpi e 100÷10 → 10 colpi corrette) | Esercizio 3 MIDI→frequenza; calcoli rapidi collegati ad audio | Parzialmente — i calcoli applicati ad audio/giochi reggono meglio |
| 3 | Confusione nome parametro / variabile esterna nei metodi | 24/09/2026 | 4 (oggi: metodo `Danno()` scritto correttamente senza parametro dopo indizi) | Altri metodi con parametri su casi nuovi, senza guida | Quasi — da riverificare con un metodo con parametri |
| 4 | Creare vs aggiornare una variabile (`int hp = ...` vs `hp = ...`) e chiamare un metodo con `()` senza tipo davanti | 01/10/2026 | 3 (oggi: `int hp = hp - Danno;`, `int colpo = int Danno();`) | Esercizio autonomo: tracciare quali variabili sono create e quali aggiornate | No — capito il principio dopo analogia traccia/fader, da consolidare |
| 5 | Dal problema alla logica del programma: cosa fare una volta (fuori dal ciclo) e cosa a ogni giro (dentro) | 01/10/2026 | 3 (oggi: `new Random()` dentro il ciclo, chiamata al metodo fuori dal ciclo, assenza di "ripeti finché" nella ricetta) | Esercizio autonomo con ricetta scritta prima; regola delle tre domande | No — è il tema centrale; migliorato a fine sessione |
| 6 | Condizioni sui bordi (`<` vs `<=`, `>` vs `>=`) e `while` come "continua finché" invece di "fermati quando" | 01/10/2026 | 4 (oggi: `hp <= 0` e poi `hp >= 0` per il while; `<` invece di `<=` per l'annuncio di morte) | Testare sempre il valore sul bordo a mano, scrivere la condizione come "continuo finché..." | Parzialmente — alla fine ha trovato `<=` e `>` da solo con il test del bordo |

[LOG SESSIONE — riga da aggiungere in cima]
| # | Data | Modulo/Lezione | Cosa abbiamo fatto | Chiaro | Poco chiaro | Compiti |
|---|---|---|---|---|---|---|
| 4 | 01/10/2026 | M1 (progettazione logica, while con condizione, metodo con return, clamp) | Ricetta in italiano prima del codice; revisione del programma pitch; esercizio "nemico con HP" da ricetta a codice completo (while, metodo Danno, if/else con clamp a 0); simulazione a mano dei casi limite | Perché la memoria va aggiornata dentro il ciclo; while come "finché"; `rng.Next(10, 31)`; un metodo si chiama con `()`; test del bordo per scegliere `<` o `<=`; `hp = hp - colpo` senza `int` | Dove metto cosa (dentro/fuori ciclo) al primo tentativo; creare vs aggiornare variabili; calcolo veloce con `%` | Esercizio 3 (ricetta prima); esercizio autonomo con ricetta; verifica GitHub (404); diario |
=== FINE AGGIORNAMENTO ===