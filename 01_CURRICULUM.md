# CURRICULUM — Da fonico ad Audio Programmer / Technical Sound Designer

Versione 1.0 — settembre 2026
Ipotesi di studio: 1 giorno pieno a settimana (+ ore extra quando possibile). Durata totale: circa 22 mesi.

---

## Panoramica

Il percorso segue la "catena del segnale" di un gioco. Prima si impara il linguaggio con cui il gioco pensa (C#), poi a organizzarlo in sistemi (OOP), poi a collegarlo a un motore reale (Unity) e a un middleware professionale (FMOD/Wwise). Poi si scende sotto il cofano con DSP e C++, e si chiude con portfolio e preparazione ai colloqui.

L'esperienza da fonico è un vantaggio: molti programmatori sanno scrivere un sistema di footstep, pochi sanno se suona bene, se è mixato bene e se regge 200 ore di gioco senza stancare.

**Premessa realistica.** Con 1 giorno a settimana, in 18–24 mesi il ruolo più raggiungibile è **Technical Sound Designer / Audio Implementer** (scripting, middleware, integrazione, tool). Il ruolo di **Audio Programmer** puro, soprattutto AAA, richiede di solito C++ solido e anni di codice: il curriculum porta alle basi di quel mondo e rende credibili per ruoli junior o ibridi in studi indie e AA. Per l'AAA puro servirà probabilmente un altro anno di C++ con più ore. Aggiungere 3–5 ore extra a settimana accorcia molto i tempi.

## Tabella riassuntiva

| Modulo | Durata | Focus principale | Output concreto |
|---|---|---|---|
| 1. Basi di C# | 3 mesi | Variabili, logica, funzioni, collezioni | Programma console: drum machine testuale / calcolatore dB |
| 2. OOP in C# | 2,5 mesi | Classi, ereditarietà, interfacce, eventi | "Mixer virtuale" a oggetti in console |
| 3. Unity + Game Audio | 3 mesi | AudioSource, Mixer, audio 3D, scripting | Primo sistema audio interattivo in Unity |
| 4. FMOD / Wwise | 3,5 mesi | Eventi, parametri, integrazione, profiling | Scena Unity con musica adattiva via middleware |
| 5. Audio digitale e DSP | 3 mesi | Campionamento, buffer, filtri, sintesi | Filtro e synth procedurale scritti a mano |
| 6. C++ per audio (JUCE) | 4 mesi | C++ moderno, memoria, real-time, plugin | Primo plugin VST3/AU funzionante |
| 7. Portfolio & Job prep | 3 mesi (+ in parallelo dal M3) | Progetti rifiniti, reel, colloqui | Portfolio online e candidature |

---

## MODULO 1 — Basi di C#
**Durata:** 3 mesi (circa 12 giornate)

### Obiettivi
- Scrivere, compilare ed eseguire programmi C# semplici in console.
- Usare variabili, tipi, operatori e controllo di flusso.
- Scomporre un problema in funzioni riutilizzabili.
- Gestire collezioni di dati (array, List, Dictionary).
- Leggere un errore del compilatore e fare debugging di base.

### Argomenti
- Setup: .NET SDK, Visual Studio o JetBrains Rider, "Hello World".
- Tipi: `int`, `float`, `double`, `bool`, `string`. Perché nell'audio `float` è ovunque.
- Operatori e matematica: dB ↔ lineare (`Math.Pow`, `Math.Log10`), clamp, lerp (= crossfade).
- Controllo di flusso: `if/else`, `switch`, `for`, `while`, `foreach`.
- Metodi: parametri, valori di ritorno, overload.
- Array, `List<T>`, `Dictionary<TKey,TValue>`.
- Stringhe e formattazione output.
- Scope, `const`, `enum` (es. `SurfaceType.Grass`).
- Debugging: breakpoint, step-by-step, stack trace.
- Git e GitHub di base.

### Risorse consigliate
- Microsoft Learn – "Get started with C#" / "C# for Beginners".
- "C# Yellow Book" di Rob Miles (gratuito).
- Unity Learn – "Junior Programmer" (parte iniziale).
- YouTube: Brackeys, serie C# base.
- GitHub Skills / guida GitHub Desktop.

### Esercizi
1. Convertitore dB ↔ lineare, gestendo −∞ dB.
2. Metronomo testuale: da BPM a durata di semiminima/croma/semicroma, 4 battute di "tick".
3. Nota MIDI → frequenza (A4 = 440 Hz) e nome della nota.
4. Libreria di suoni: `Dictionary<string, float>` con menu per aggiungere/rimuovere/cercare.
5. Randomizzatore pitch (±2 semitoni) e volume (±3 dB) senza ripetizioni consecutive.
6. Step sequencer testuale 16 step × 4 tracce, modificabile da input.

### Mini-progetto: "Console Drum Machine"
Carica un pattern da file di testo, lo mostra a griglia, permette di modificarlo, cambiare BPM e swing, lo "riproduce" a tempo (`Stopwatch`). Pubblicato su GitHub con README.
*Mostrabilità:* bassa, ma dimostra metodo e uso di Git.

### Rilevanza job description
"Scripting experience (C#, Lua, Python)".

### Esame di fine modulo
**Teoria**
1. Differenza tra `int` e `float`; perché i campioni audio sono `float`?
2. Cosa stampa `7 / 2`? E `7f / 2f`? Perché?
3. Formula dB → guadagno lineare.
4. Quando `for` e quando `foreach`?
5. Cosa succede accedendo all'indice 16 di un array di 16 elementi?
6. A cosa serve il valore di ritorno di un metodo? Esempio audio.
7. Una `List<T>`: (a) dimensione fissa; (b) cresce dinamicamente; (c) solo stringhe.
8. Cos'è un `enum` e perché è meglio di una stringa per il tipo di superficie?
9. Quando un `Dictionary` è meglio di una `List`?
10. Cos'è lo scope di una variabile?
11. Errore di compilazione vs errore a runtime.
12. Cos'è un breakpoint?
13. A cosa serve un commit?

**Pratica**
1. `DbToLinear(float db)` e `LinearToDb`, gestendo il silenzio.
2. Metodo che restituisce un file di passo casuale diverso dall'ultimo.
3. Da BPM e battute in 4/4: durata in secondi e numero di campioni a 48 kHz.

---

## MODULO 2 — Programmazione a oggetti in C#
**Durata:** 2,5 mesi

### Obiettivi
- Progettare classi e oggetti pensando in sistemi.
- Usare incapsulamento, ereditarietà, polimorfismo e interfacce.
- Usare eventi e delegate (cuore dei sistemi reattivi).
- Distinguere tipi valore e riferimento (`struct` vs `class`).
- Scrivere codice leggibile e manutenibile.

### Argomenti
- Classi, oggetti, costruttori, campi, proprietà (classe = preset di canale, oggetto = canale istanziato).
- Incapsulamento: `public`/`private`; il fader si muove solo tramite metodi controllati.
- Ereditarietà: `AudioEffect` base, `Delay`/`Reverb` derivate.
- Polimorfismo: `virtual`/`override`/`abstract`, catena di insert.
- Interfacce: `IAudioProcessor`, `IPlayable`.
- Delegate, `Action`, `event`: send e trigger.
- `static`: utility sì, stato globale con cautela.
- `struct` vs `class`.
- Pattern: Observer, Singleton (con cautela), Object Pool.
- Responsabilità singola (SOLID semplificato).
- Collezioni di oggetti, LINQ di base.

### Risorse consigliate
- Microsoft Learn – "Object-oriented programming (C#)", docs su eventi e delegate.
- Unity Learn – "Junior Programmer", unità OOP.
- "Game Programming Patterns" di Robert Nystrom (gratuito online): Observer, Object Pool, Singleton, Event Queue.
- YouTube: git-amend, Infallible Code (verso fine modulo).

### Esercizi
1. Classe `Sound` con proprietà che impediscono valori fuori range.
2. Classe `MixerChannel` con fader, mute, solo, pan e `GetOutputGain()`.
3. `AudioEffect` astratta con `Process(float sample)`; derivate `Gain`, `HardClipper`, `Inverter` in catena.
4. Interfaccia `IAudioProcessor` implementata da effetto e da bus.
5. `GameEvents` con `event Action<string> OnSurfaceStep`, ascoltato da `FootstepPlayer` e `DebugLogger`.
6. Voice Pool da 8 voci con voice stealing per priorità/età.

### Mini-progetto: "Virtual Mixing Console"
Canali con insert polimorfici, bus di gruppo, master, mute/solo corretti, sistema di eventi che simula il gioco (esplosione → ducking musica −6 dB per 2 s calcolato nel tempo). Output testuale dei livelli a ogni tick.
*Mostrabilità:* media; dimostra architettura audio.

### Rilevanza job description
"Strong understanding of OOP", "event-driven systems", "voice management".

### Esame di fine modulo
**Teoria**
1. Classe vs oggetto, con esempio audio.
2. Cos'è l'incapsulamento?
3. Classe astratta vs interfaccia.
4. Cosa fa `override`?
5. Cos'è un `event` e come si collega a un sistema reattivo?
6. Passando una `struct` a un metodo si riceve: (a) copia; (b) riferimento; (c) dipende.
7. Cos'è il voice stealing? Due criteri.
8. Pro e contro di un Singleton `AudioManager`.
9. Cos'è un Object Pool e perché serve per suoni ripetuti?
10. Responsabilità singola: una classe che carica, mixa e salva la rispetta?
11. Perché disiscriversi da un evento (`-=`)?
12. Polimorfismo a parole tue.

**Pratica**
1. `IAudioProcessor` con `Process(float[] buffer)`, Gain e Clipper, e `EffectChain`.
2. `DuckingController` su `OnDialogueStart/End`, musica a −8 dB con attack/release.
3. `VoicePool` con capienza N e stealing per priorità poi età.

---

## MODULO 3 — Unity + Game Audio basics
**Durata:** 3 mesi

### Obiettivi
- Orientarsi in Unity: scene, GameObject, Component, Prefab, ciclo di vita.
- Usare `AudioSource`, `AudioListener`, `AudioClip`, `AudioMixer`.
- Scrivere script audio legati al gameplay.
- Gestire audio 3D: attenuazione, spatial blend, zone ambientali.
- Usare snapshot e parametri esposti da codice.
- Profilare in modo base.

### Argomenti
- Editor Unity (LTS), Git con `.gitignore` per Unity.
- Ciclo di vita: `Awake`, `Start`, `Update`, `FixedUpdate`, `OnEnable/OnDisable`.
- `AudioSource`: `Play`, `PlayOneShot`, `PlayScheduled`, loop, pitch, rolloff.
- Import settings: Decompress On Load / Compressed in Memory / Streaming; Vorbis/ADPCM/PCM.
- `AudioMixer`: gruppi, send/return, effetti, snapshot, `SetFloat` in dB.
- Audio 3D: spatial blend, min/max distance, curve custom, reverb zone.
- Fisica e animazione: `OnCollisionEnter`, Animation Events.
- Raycast per la superficie.
- ScriptableObject come sound bank.
- Coroutine per fade e sequenze.
- `AudioSettings.dspTime` e scheduling sample-accurate.
- Accenno a `OnAudioFilterRead`.

### Risorse consigliate
- Unity Learn – "Junior Programmer" (completo) e "Creative Core" (Audio).
- Documentazione Unity: Audio Overview, AudioMixer, AudioSource.
- "Game Programming Patterns": Update Method, Component.
- "The Game Audio Tutorial" (Stevens & Raybould): concetti universali di implementazione.
- YouTube: canale GDC (talk audio).
- Game Audio Learning Roadmap come checklist concettuale (verificare aggiornamento).

### Esercizi
1. Trigger zone con loop ambientale e fade-in/out (coroutine).
2. Impatti fisici: volume/pitch da velocità, soglia e cooldown.
3. Footstep via Animation Events con randomizzazione senza ripetizioni.
4. Rilevamento superficie con raycast → banco suoni diverso.
5. Snapshot Esplorazione/Combattimento/Pausa + slider opzioni salvati in `PlayerPrefs`.
6. Due layer musicali con `PlayScheduled`, ingresso quantizzato alla battuta.

### Mini-progetto: "Sound of a Room"
Livello con passi per superficie, ambience a zone con crossfade, 3–4 oggetti interattivi (porta, leva, radio diegetica 3D), snapshot "grotta", menu opzioni audio. Architettura pulita: `AudioManager`, ScriptableObject, nessun clip hard-coded.
*Mostrabilità:* **alta** — video 60–90 s con overlay tecnico. Primo pezzo di portfolio.

### Rilevanza job description
"Experience implementing audio in Unity", "optimization and memory budgets".

### Esame di fine modulo
**Teoria**
1. `Play()` vs `PlayOneShot()`.
2. Load type per musica lunga, passi, dialogo.
3. Cosa fa lo spatial blend?
4. Perché non chiamare `Play()` in `Update()` senza condizione?
5. Cos'è uno snapshot e come si attiva da script?
6. `SetFloat` sul volume: lineare o dB?
7. `Time.time` vs `AudioSettings.dspTime`.
8. Animation Events nell'audio.
9. ScriptableObject: vantaggio per il sound designer.
10. Quanti `AudioListener` attivi? (a) uno per sorgente; (b) uno; (c) nessuno.
11. Come evitare il machine-gun effect?
12. Cosa guardare nel Profiler?
13. Cos'è una coroutine?
14. Slider 0–1 → volume percettivamente corretto per il mixer.

**Pratica**
1. `SurfaceFootsteps` chiamato da Animation Event con raycast e clip non ripetuto.
2. `MusicLayerController` con ingresso/uscita quantizzati alla battuta.
3. `ImpactAudio` con `AnimationCurve` velocità → volume, soglia e cooldown.

---

## MODULO 4 — Middleware: FMOD e/o Wwise
**Durata:** 3,5 mesi
**Scelta:** prima FMOD (curva più dolce, diffuso nell'indie), poi certificazioni Wwise (dominante in AA/AAA).

### Obiettivi
- Progettare eventi complessi: container, parametri, multi-instrument, blend.
- Integrare il middleware in Unity via API.
- Costruire musica adattiva: transizioni, marker, stinger, layering verticale e orizzontale.
- Gestire mix dinamico: bus, snapshot/state, side-chain, ducking.
- Profilare e ottimizzare: voci, memoria, CPU, virtualizzazione.
- Capire il flusso di lavoro in team.

### Argomenti
- FMOD Studio: eventi, timeline/action sheet, istanze, parametri local/global, automazioni, modulazioni, loop region, marker, quantizzazione.
- Mixer FMOD: bus, return, VCA, snapshot, side-chain.
- FMOD Unity: `RuntimeManager.PlayOneShot`, `EventInstance` (create/start/stop/release), `setParameterByName`, 3D attributes, `StudioEventEmitter`, bank loading, callback.
- Programmer instruments per il dialogo.
- Wwise: Actor-Mixer Hierarchy, container, Game Syncs (States, Switches, RTPC, Triggers), Interactive Music, SoundBank.
- Wwise Unity: `AkSoundEngine.PostEvent`, `SetRTPCValue`, `SetSwitch`, `SetState`, AkGameObj, callback.
- Profiler di FMOD e Wwise.
- Occlusion/obstruction via raycast.
- Loading/unloading bank per livello.
- Naming convention, cartelle, merge in team.

### Risorse consigliate
- FMOD: documentazione ufficiale (Studio Manual, Unity Integration), progetti di esempio, canale YouTube FMOD.
- Audiokinetic Wwise Certification: Wwise-101, 201, 251, 301 (gratuite, da mettere nel CV).
- "Game Audio Implementation" (Stevens & Raybould).
- GDC Vault / YouTube GDC: musica adattiva e mix dinamico.
- Epic Developer Community: corsi su audio/MetaSounds/Quartz (cercare per argomento; i titoli cambiano).

### Esercizi
1. Passi FMOD con multi-instrument e parametro labeled "Surface", suonato da Unity.
2. Motore veicolo con parametri RPM e Load collegati alla velocità.
3. Musica orizzontale (explore/tension/combat) con transition marker e stinger.
4. Ducking del dialogo via side-chain o snapshot; VCA per le opzioni.
5. Occlusione: raycast → parametro con low-pass e smoothing.
6. Rifare gli esercizi 1 e 3 in Wwise + mezza pagina di confronto.

### Mini-progetto: "Adaptive Night Run"
Scena con musica adattiva a stati, vento/ambience reattivi a meteo e altezza, occlusione, veicolo o arma con parametri continui, dialogo con ducking. Tutto via FMOD, nessuna stringa hard-coded, overlay di debug con parametri in tempo reale.
*Mostrabilità:* **molto alta** — probabile pezzo centrale del portfolio.

### Rilevanza job description
"Proficient in Wwise and/or FMOD", "adaptive music systems", "dynamic mixing", "profiling".

### Esame di fine modulo
**Teoria**
1. `PlayOneShot` vs `EventInstance`; cosa succede senza `release()`?
2. Parametro locale vs globale in FMOD.
3. Switch vs State in Wwise.
4. Cos'è un RTPC? Due esempi.
5. Transition marker quantizzato: perché migliora la musica?
6. Layering verticale vs riarrangiamento orizzontale.
7. Cos'è una virtual voice?
8. Quando dividere i suoni in più bank?
9. VCA vs bus.
10. Evento in movimento: (a) ricrearlo ogni frame; (b) aggiornare i 3D attributes; (c) nulla.
11. Occlusione senza sfarfallio.
12. Programmer instrument e dialogo localizzato.
13. Cosa controllare nel profiler con glitch in scena affollata.
14. Perché le naming convention contano.
15. Callback sul beat della musica in Unity.

**Pratica**
1. `EngineAudio`: istanza FMOD, RPM/Load da Rigidbody con smoothing, 3D attributes, release.
2. `MusicStateController`: parametro globale da nemici nel raggio, con isteresi.
3. Occlusione con 3 raycast, media e interpolazione.

---

## MODULO 5 — Fondamenti di audio digitale e DSP
**Durata:** 3 mesi

### Obiettivi
- Capire campionamento, quantizzazione, aliasing, buffer e latenza.
- Pensare in blocchi di campioni e capire il vincolo real-time.
- Implementare oscillatori, inviluppi, smoothing, delay, filtri.
- Leggere la matematica di base del DSP.
- Collegare il DSP ai giochi: sintesi procedurale, pitch, spazializzazione.

### Argomenti
- Nyquist, aliasing, bit depth, dither.
- `float[]` interleaved vs non-interleaved, canali, frame, buffer size.
- Callback e thread audio: niente allocazioni, lock, I/O.
- Oscillatori: fase, incremento di fase, forme d'onda, cenni PolyBLEP.
- ADSR e smoothing (zipper noise, click).
- Delay line e buffer circolare: echo, chorus, flanger, comb.
- Filtri: one-pole, biquad (RBJ Cookbook).
- Envelope follower, compressore semplice.
- Interpolazione lineare/cubica per resampling.
- Panning lineare/equal-power; cenni HRTF, ambisonics.
- Cenni FFT.
- Sintesi procedurale: vento, pioggia, motori, UI.
- Unity: `OnAudioFilterRead`, `AudioClip.Create`.

### Risorse consigliate
- Hack Audio (Eric Tarr) – libro per ingegneri del suono.
- "The Scientist and Engineer's Guide to DSP" (Steven W. Smith, gratuito).
- "Designing Audio Effect Plugins in C++" (Will Pirkle).
- RBJ Audio EQ Cookbook.
- "Musimathics" (Gareth Loy).
- YouTube: Valerio Velardo "The Sound of AI" (Audio Signal Processing), 3Blue1Brown (Fourier).

### Esercizi
1. Oscillatore sinusoidale con `OnAudioFilterRead`, controlli senza click.
2. Saw/square naive: ascoltare e descrivere l'aliasing.
3. Classe ADSR con trigger da tastiera.
4. Delay con buffer circolare + LFO → chorus.
5. Biquad LPF/HPF/BPF, cutoff legato alla distanza.
6. Vento procedurale: rumore → passa-banda modulato.

### Mini-progetto: "Procedural Weather Synth"
Vento, pioggia e tuono generati in tempo reale e controllati da un sistema meteo, con pannello di debug (forma d'onda e spettro) e confronto CPU con i sample.
*Mostrabilità:* **alta** per ruoli con componente programmer.

### Rilevanza job description
"DSP fundamentals", "real-time constraints", "procedural audio".

### Esame di fine modulo
**Teoria**
1. Nyquist; valore a 48 kHz.
2. Perché una square naive suona aspra in alto?
3. Buffer circolare e delay.
4. Allocazioni o lock nel callback: conseguenze.
5. Buffer size, sample rate, latenza: 512 campioni a 48 kHz.
6. Perché lo smoothing?
7. Panning lineare vs equal-power.
8. Cos'è un biquad e quanti coefficienti ha?
9. Cosa rappresenta un bin FFT?
10. Lettura a velocità doppia: (a) +1 ottava metà durata; (b) +1 ottava stessa durata; (c) nessun cambio.
11. Envelope follower: cos'è e dove si usa.
12. Interleaved vs non-interleaved.
13. Due casi in cui la sintesi procedurale conviene.

**Pratica**
1. `DelayLine` con buffer circolare, lettura frazionaria, feedback, zero allocazioni.
2. `Biquad` low-pass RBJ con ricalcolo solo al cambio parametri.
3. Compressore feed-forward con envelope follower.

---

## MODULO 6 — Introduzione a C++ per audio (JUCE)
**Durata:** 4 mesi

### Obiettivi
- Tradurre in C++ i concetti di C#.
- Capire memoria, puntatori, riferimenti, RAII, smart pointer.
- Usare C++ moderno (17/20) e la STL.
- Compilare con CMake e fare debug.
- Costruire un plugin JUCE rispettando le regole real-time.
- Capire a livello introduttivo i plugin per FMOD/Wwise.

### Argomenti
- C# → C++: compilazione, header/source, linker, niente garbage collector.
- Stack vs heap, puntatori, riferimenti, `const`.
- RAII, `unique_ptr`, `shared_ptr`.
- `std::vector`, `std::array`, `std::string`, algoritmi STL.
- Costruttori, distruttori, regola 0/3/5, `virtual`.
- Template di base.
- CMake, toolchain, debugger.
- Real-time: lock-free, `std::atomic`, denormal.
- JUCE: `AudioProcessor`, `processBlock`, `AudioProcessorValueTreeState`, GUI, `SmoothedValue`, modulo `juce::dsp`.
- Porting dei DSP del modulo 5.
- Cenni FMOD DSP Plugin API, Wwise SDK, audio di Unreal.

### Risorse consigliate
- learncpp.com.
- "The Audio Programmer" (Joshua Hodge): YouTube + Discord.
- Tutorial ufficiali JUCE.
- "Designing Audio Effect Plugins in C++" (Pirkle).
- "Game Audio Programming: Principles and Practices" (ed. Guy Somberg).
- YouTube ADC: talk sul real-time audio (Dave Rowland, Fabian Renn-Giles, Timur Doumler).
- Documentazione FMOD Core/DSP Plugin API, Wwise SDK.

### Esercizi
1. Convertitore dB e nota → frequenza in C++.
2. `DelayLine` con `std::vector` preallocato, test su WAV (`dr_wav`).
3. `EffectChain` con `std::vector<std::unique_ptr<AudioEffect>>`.
4. Primo plugin JUCE: gain con smoothing e automazione.
5. Plugin filtro con biquad, knob e display di risposta.
6. Meter di livello audio → GUI via `std::atomic`.

### Mini-progetto: "Game-Ready Plugin"
Es. "Distance & Occlusion Simulator" (filtro, attenuazione, early reflections, preset) o "Footstep Variation Generator". VST3/AU, repo pulito, README, video demo. Bonus: porting del DSP in plugin FMOD.
*Mostrabilità:* **alta** per ruoli audio programmer.

### Rilevanza job description
"C++ proficiency", "real-time and multithreaded programming", "plugin development".

### Esame di fine modulo
**Teoria**
1. Stack vs heap.
2. Puntatore vs riferimento.
3. RAII.
4. `unique_ptr` vs `shared_ptr`.
5. Perché distruttore `virtual` in una base polimorfica?
6. `processBlock`: cosa fa e in che thread?
7. Perché niente allocazioni in `processBlock`?
8. `std::atomic` vs mutex.
9. Denormal: cosa sono e come evitarli.
10. `AudioProcessorValueTreeState`.
11. Un header contiene: (a) implementazioni; (b) dichiarazioni; (c) binari.
12. Cos'è CMake?
13. Come si integra un effetto custom in FMOD o Wwise.

**Pratica**
1. `OnePoleLowPass` con `prepare`, `setCutoff`, `processBlock`, zero allocazioni.
2. Parametro "Drive" smoothed con saturazione `tanh` e compensazione gain.
3. Ring buffer lock-free SPSC per RMS verso la GUI.

---

## MODULO 7 — Portfolio & job preparation
**Durata:** 3 mesi dedicati, iniziato in parallelo dal modulo 3

### Obiettivi
- Rifinire 2–3 progetti forti.
- Costruire presenza online coerente (sito, GitHub, LinkedIn, video).
- Leggere job description e mappare le competenze.
- Prepararsi a test tecnici e colloqui.
- Entrare nella community del game audio.

### Argomenti
- Meglio 3 lavori curati che 10 abbozzati.
- Video: gameplay + middleware + overlay tecnico, 1–3 min.
- Case study: problema, soluzione, scelte, cosa rifaresti.
- GitHub: README, screenshot, build, commenti.
- Game jam per esperienza in team.
- Must have vs nice to have.
- Test tecnici tipici (implementazione in 48–72 h, codice, profiling).
- Raccontare il passato da fonico come punto di forza.
- Piccolo progetto Unreal (MetaSounds, Quartz).
- Networking e mentoring.

### Risorse consigliate
- Audio Mentoring Project (AMP).
- Discord "The Audio Programmer" e community game audio attive.
- GameSoundCon, GDC Audio Track, Develop:Brighton, ADC.
- Global Game Jam, jam su itch.io.
- "The Game Audio Strategy Guide" (Zdanowicz & Bambrick).

### Esercizi
1. Analisi di 5 job description: requisiti → competenze → gap.
2. Case study del progetto del modulo 4 (max 800 parole, diagrammi).
3. Video portfolio con feedback da almeno 2 professionisti.
4. Game jam come audio implementer, con documentazione.
5. Test simulato: progetto Unity muto, audio completo con FMOD in 48 h.
6. Mock interview: 30 domande tecniche e comportamentali.

### Capstone: "Vertical Slice Audio"
Livello di 3–5 minuti con musica adattiva, mix dinamico, sistemi procedurali, un tool per sound designer (editor custom Unity per banchi o validator di naming/riferimenti) e documento tecnico di audio design.
*Mostrabilità:* **massima**.

### I 3 progetti portfolio
1. "Adaptive Night Run" (M4, rifinito).
2. "Procedural Weather Synth" (M5) oppure "Game-Ready Plugin" (M6).
3. "Vertical Slice Audio" con tool (M7).

### Esame di fine modulo
**Teoria / colloquio**
1. Racconta in 2 minuti un tuo sistema audio.
2. Budget di 32 voci con 80 sorgenti potenziali.
3. Calo di framerate con molte esplosioni: come indaghi?
4. Organizzazione dei bank in un open world.
5. Tool per un designer che cambia spesso suoni senza toccare codice.
6. Spiegare a un programmatore gameplay l'evento "anticipato" di 100 ms.
7. Localizzazione dei dialoghi in FMOD/Wwise.
8. Technical Sound Designer vs Audio Programmer.
9. Naming convention per 5 sound designer.
10. Mix finale di un gioco vs mix lineare.
11. Un errore tecnico e come l'hai risolto.
12. Perché l'esperienza da fonico è un vantaggio.

**Pratica**
1. Test simulato da 48 ore con build, video e documento.
2. Editor tool Unity che segnala eventi FMOD inesistenti e clip non usate.
3. Code review di uno script audio con bug e cattive pratiche.

---

## ROADMAP TEMPORALE (circa 22 mesi)

| Periodo | Attività | Momento chiave |
|---|---|---|
| Mesi 1–3 | M1: C# base, Git | Drum machine console su GitHub |
| Mesi 4–6 | M2: OOP, eventi, pattern | "Virtual Mixing Console" |
| Mesi 6–9 | M3: Unity + audio nativo | **Primo prototipo audio in Unity** |
| Mesi 9–13 | M4: FMOD, poi Wwise 101/201 | **Scena con FMOD e musica adattiva** |
| Mesi 13–16 | M5: DSP | Synth procedurale in Unity |
| Mesi 16–20 | M6: C++ e JUCE | **Primo plugin VST3/AU** |
| Mesi 19–22 | M7: capstone, portfolio | **Portfolio completo e candidature** |

### Pubblicazione e networking
- **Dal mese 1:** tutto su GitHub, anche il codice piccolo.
- **Dal mese 6–9:** LinkedIn orientato al game audio, video brevi dei sistemi, community Discord.
- **Dal mese 10–13:** prima game jam, certificazioni Wwise, candidatura all'Audio Mentoring Project.
- **Dal mese 14:** candidature junior Technical Sound Designer / audio implementer, anche freelance indie.
- **Mesi 18–22:** portfolio finale, analisi job description, candidature mirate anche AA.
- **Ogni anno:** talk audio GDC; se possibile una conferenza in presenza.
