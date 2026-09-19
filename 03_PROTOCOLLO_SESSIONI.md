# PROTOCOLLO DELLE SESSIONI

Come si lavora in questo progetto, chat dopo chat.

---

## 1. Regola base: una chat per lezione

Ogni lezione è una **nuova chat** dentro il progetto. Le chat lunghe diventano lente e perdono precisione; i documenti del progetto garantiscono la continuità tra una chat e l'altra.

**Nome delle chat** (rinominale dal menu della chat):

```
M1-L01 · Setup e Hello World
M1-L02 · Tipi di dato
M1-ES04 · Esercizio libreria suoni
M1-MP · Console Drum Machine
M1-ESAME · Esame modulo 1
REVISIONE · Lacune dopo sessione 8
```

`M` = modulo · `L` = lezione · `ES` = esercizio · `MP` = mini-progetto.

---

## 2. Apertura della sessione

Incolla questo messaggio all'inizio di ogni nuova chat:

```
INIZIO SESSIONE
Data: __/__/____
Modulo: __  Lezione/attività: ______
Tempo a disposizione oggi: __ ore
Dall'ultima volta ho fatto: ______
Mi è chiaro: ______
Mi è poco chiaro: ______
Obiettivo di oggi: ______
```

Claude risponderà con: riassunto dello stato attuale dal registro, 2–3 domande di ripasso, piano della sessione.

---

## 3. Durante la sessione

Comandi utili da scrivere in chat:

| Comando | Cosa succede |
|---|---|
| `QUIZ` | 5 domande rapide sull'argomento corrente |
| `SPIEGO IO` | Spiego un concetto a parole mie, Claude valuta e corregge |
| `ANALOGIA AUDIO` | Rispiegazione del concetto con un paragone da studio/mix |
| `PIÙ PIANO` | Stesso concetto, passi più piccoli |
| `ESERCIZIO` | Un esercizio sul concetto appena visto |
| `REVIEW` + codice | Revisione del mio codice: prima indizi, poi soluzione commentata |
| `BLOCCATO` | Aiuto a sbloccarmi con domande guida, senza soluzione immediata |
| `SOLUZIONE` | Soluzione completa commentata (dopo aver provato) |
| `LACUNE` | Riepilogo delle mie lacune ricorrenti ed esercizi mirati |
| `CHIUDI SESSIONE` | Chiusura e aggiornamento del registro |

---

## 4. Chiusura della sessione

Scrivi `CHIUDI SESSIONE`. Claude produce:

1. Riassunto di cosa è stato fatto.
2. Compiti per la settimana.
3. Il blocco da copiare nel registro:

```
=== AGGIORNAMENTO REGISTRO ===
[STATO ATTUALE]
Modulo corrente: 
Lezione corrente: 
Prossimo argomento: 
Compiti in sospeso: 
Sessioni svolte: 
Ore totali (stima): 

[CHECKBOX DA SPUNTARE]
- Modulo X > Argomenti > ...
- Modulo X > Esercizi > ...

[LACUNE — nuove o aggiornate]
| # | Lacuna | Prima volta | Occorrenze | Esercizi mirati | Risolta? |

[LOG SESSIONE — riga da aggiungere in cima]
| # | Data | Modulo/Lezione | Cosa abbiamo fatto | Chiaro | Poco chiaro | Compiti |
=== FINE AGGIORNAMENTO ===
```

**Poi tu:**
1. Apri `02_REGISTRO_PROGRESSI.md` sul computer.
2. Applichi le modifiche (spunta le caselle `[x]`, aggiorni le tabelle).
3. Nel progetto Claude elimini il vecchio registro dalla conoscenza e carichi quello nuovo.

Questo passaggio è indispensabile: Claude legge i file del progetto ma non può modificarli da solo.

---

## 5. Diario di studio (tuo, facoltativo ma consigliato)

A fine giornata, 5 minuti. Tienilo sul computer in `diario/` oppure in un quaderno.

```
## __/__/____ — Sessione #__
Cosa ho capito oggi (a parole mie):
Cosa non mi è chiaro:
Un errore che ho fatto e perché:
Una connessione con il mio lavoro di fonico:
Domanda per la prossima sessione:
```

Porta in chat, all'inizio della sessione successiva, soprattutto la voce "Domanda per la prossima sessione".

---

## 6. Organizzazione delle cartelle sul computer

```
AudioProgramming/
├── 00_progetto_claude/          ← copie dei 4 file del progetto (il registro si aggiorna qui)
│   ├── 00_ISTRUZIONI_PROGETTO.md
│   ├── 01_CURRICULUM.md
│   ├── 02_REGISTRO_PROGRESSI.md
│   └── 03_PROTOCOLLO_SESSIONI.md
├── diario/                      ← diario di studio
├── M1_csharp_basi/              ← repository Git
│   ├── esercizi/
│   └── drum-machine/
├── M2_oop/
├── M3_unity/
├── M4_middleware/
├── M5_dsp/
├── M6_cpp_juce/
├── M7_portfolio/
│   ├── video/
│   ├── case-study/
│   └── job-descriptions/
└── risorse/                     ← PDF, libri, appunti da corsi esterni
```

Suggerimento: una cartella per modulo = un repository GitHub (oppure un unico repository `audio-programming-journey` con sottocartelle, più semplice all'inizio).

---

## 7. Checkpoint periodici

| Quando | Cosa fare |
|---|---|
| Ogni 4–5 sessioni | Chat `REVISIONE`: lacune ricorrenti ed esercizi mirati |
| Fine di ogni modulo | Chat `ESAME` (senza guardare appunti), poi aggiornamento registro |
| Ogni 3 mesi | Confronto con la roadmap del curriculum: siamo in ritardo o in anticipo? Si ricalibra |
| Da modulo 3 in poi | A ogni mini-progetto: video breve + README su GitHub |

---

## 8. Cosa caricare nel progetto oltre ai 4 file (quando serve)

- Codice su cui vuoi un parere ricorrente: meglio incollarlo in chat o allegarlo alla singola chat, non alla conoscenza del progetto, per non riempirla.
- Job description (modulo 7): puoi caricarle nella conoscenza del progetto quando le analizziamo.
- Case study e documenti di design dei progetti portfolio: nella conoscenza del progetto quando ci lavoriamo sopra.

Tieni la conoscenza del progetto **leggera**: i 4 file base più solo ciò che serve nel modulo corrente.
