=== AGGIORNAMENTO REGISTRO ===
[STATO ATTUALE]
Modulo corrente: 1 — Basi di C#
Lezione corrente: switch + enum; blocco A del recupero (double e cast, Math.Pow/Log10, Math.Clamp, lerp); const spiegato ma non ancora verificato
Prossimo argomento: ripartire dal messaggio su const (leggere e rispondere alle 2 domande), poi blocco B (scope, formattazione stringhe, overload), blocco C (List, Dictionary, debugging con breakpoint); richiamo a freddo float.TryParse + range dB in contesto nuovo (es. convertitore dB ↔ lineare con input da tastiera); quiz di teoria M1; mini-progetto Console Drum Machine; esame modulo 1
Compiti in sospeso: lettura e risposte su const; push GitHub (switch comandi, LivelloSuperficie con enum, DbPerMixer, Lerp, IndiceValido, uscita con ToLower); rinomina parametri IndiceValido in indice/lunghezza e eventuale "a" in "traccia"; domanda array vuoto su CanalePiuForte (-1 contro 0); StampaTraccia con Write invece di WriteLine; richiamo float.TryParse + range dB; diario; facoltativi: DbPerMixer con const, conteggio attraversamenti di soglia, metronomo
Sessioni svolte: 12
Ore totali (stima): 36,5

[CHECKBOX DA SPUNTARE]
- Modulo 1 > Argomenti > switch + enum [x] — switch con string e con enum, SurfaceType, metodo con parametro enum e un solo return
- Modulo 1 > Argomenti > double e cast [x] — float contro double, f finale, cast (float); da consolidare in contesto nuovo
- Modulo 1 > Argomenti > Math.Pow e Math.Log10 [x] — dB ↔ lineare, cast da double a float
- Modulo 1 > Argomenti > Clamp [x] — Math.Clamp, tre modi di usare il risultato; DbPerMixer con due clamp nell'ordine giusto
- Modulo 1 > Argomenti > Lerp [x] — formula a + (b - a) * t, metodo Lerp con clamp su t
- Modulo 1 > Argomenti > const [ ] — spiegato, verifica non ancora fatta
- Modulo 1 > Argomenti > Scope, formattazione stringhe, overload [ ] — mai visti, blocco B
- Modulo 1 > Argomenti > List, Dictionary, debugging [ ] — da ripassare, blocco C
- Modulo 1 > Argomenti > TryParse + range [ ] — ancora da rifare in contesto nuovo
- Modulo 1 > Esercizi > Comandi con switch, LivelloSuperficie, DbPerMixer, Lerp [x]

[LACUNE — nuove o aggiornate]
| # | Lacuna | Prima volta | Occorrenze | Esercizi mirati | Risolta? |
|---|---|---|---|---|---|
| 3 | Confusione nome parametro / variabile esterna nei metodi | 24/09/2026 | 8 (oggi: variabile "tipo" in più nel metodo con enum, tolta da solo dopo la domanda) | Metodi con parametri su casi nuovi | Sì, da confermare |
| 5 | Dal problema alla logica: cosa dentro e cosa fuori il ciclo; stato tra i giri | 01/10/2026 | 12 (oggi: nel ripasso il motivo per cui il record sta fuori dal ciclo era "perché parto da -infinito") | Pseudocodice; prove a mano dei giri | Parzialmente |
| 9 | Compilazione vs runtime quando il dato è un valore | 04/10/2026 | 5 (oggi nessuna nuova: enum scritto male = compilazione, giusto; Math.Clamp con limiti invertiti = runtime, trovato da solo) | — | Quasi |
| 16 | Ruolo delle variabili; direzione dell'= | 22/10/2026 | 3 (oggi nessuna nuova: clamp riassegnato alla stessa variabile usato bene) | — | Quasi |
| 17 | Negazione di un "oppure" | 22/10/2026 | 1 (oggi risolta nel ripasso: != n && != s e motivo del || sempre vero spiegato bene) | Contesto nuovo con controllo di uscita | Quasi |
| 18 | Leggere la consegna | 22/10/2026 | 3 (oggi: array al posto della variabile singola nello switch; fade da -12 a 0 invece che da 0 a -12; per quest'ultimo nessun effetto sul concetto, quindi non va segnalato quando non cambia il ragionamento) | Rileggere la consegna prima di scrivere | Segnalata |
| 19 | Segno nelle sottrazioni con numeri negativi (b - a con dB) | 24/10/2026 | 1 (oggi: b - a con a = -60 e b = 0 scritto come -60; corretto con meno per meno) | Lerp e differenze tra livelli in dB negativi | No |

[LOG SESSIONE — riga da aggiungere in cima]
| # | Data | Modulo/Lezione | Cosa abbiamo fatto | Chiaro | Poco chiaro | Compiti |
|---|---|---|---|---|---|---|
| 12 | 24/10/2026 | M1 (switch + enum, blocco A: double, Pow/Log10, Clamp, Lerp) | Ripasso (while con && e !=, record fuori dal ciclo); switch con ReadLine e ToLower; enum SurfaceType e LivelloSuperficie; confronto elenco argomenti M1 con curriculum e piano in tre blocchi; double e cast; DbPerMixer; Math.Clamp; Lerp con clamp; const spiegato, non verificato | switch come alternative su una variabile; ToLower con case minuscoli; enum e errori a compilazione; cast float/double; clamp prima e dopo la conversione; ordine dei due clamp; formula del lerp | dove si sceglie il valore nello switch (equivoco nato dalla consegna); segno di b - a con dB negativi; RT del TryParse non ripreso (sospeso su richiesta) | lettura e verifica su const; push GitHub; compiti sessione 11; diario; facoltativo DbPerMixer con const |
=== FINE AGGIORNAMENTO ===