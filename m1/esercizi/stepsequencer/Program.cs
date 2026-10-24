// using System.Data.Common;
// using System.Runtime.CompilerServices;

// bool[,] griglia = new bool[4, 16];
// string[] nomi = { "kick", "snare", "hihat", "crash" };
// for (int i = 0; i < nomi.Length ; i++)
// {
//     Console.WriteLine(i + " - " + nomi[i]);
// }
// Console.WriteLine("Scrivi quale traccia vuoi modificare o digita esci per uscire");

// string menu = Console.ReadLine();

// while (menu.ToLower() != "esci")
// {
//     if (int.TryParse(menu, out int sceltatraccia) && IndiceValido(sceltatraccia, griglia.GetLength(0)))
//     {
//         Console.WriteLine("Scrivi quale step vuoi modificare");
//         string sceltastep = Console.ReadLine();
//         if (int.TryParse(sceltastep, out int step) && IndiceValido(step, griglia.GetLength(1)))
//         {
//             griglia[sceltatraccia, step] = !griglia[sceltatraccia, step];
//         }
//         else
//         {
//             Console.WriteLine("Valore non valido");
//         }
//     }
//     else
//     {
//         Console.WriteLine("Valore non valido");
//     }
//     Stampa(griglia, nomi);
//                 for (int traccia = 0; traccia < nomi.Length; traccia++)
// {
//     Console.WriteLine(nomi[traccia] + ": " + ContaStepAttivi(griglia,traccia) + " step attivi");
// }
//     Console.WriteLine("Scrivi quale traccia vuoi modificare o digita esci per uscire");
//     for (int i = 0; i < nomi.Length ; i++)
// {
//     Console.Write(i + " - " + nomi[i] + " ");
//     Console.WriteLine();
// }
//     menu = Console.ReadLine();
// }


// Console.WriteLine("Ciao");

// static void Stampa(bool[,] griglia, string[] nomi)
// {
//     for (int t = 0; t < griglia.GetLength(0); t++)
//     {
//         Console.Write (t + " - " + nomi[t] + " ");
//         for (int s = 0; s < griglia.GetLength(1); s++)
//         {
//             if (griglia[t, s])
//             {
//                 Console.Write("o");
//             }
//             else
//             {
//                 Console.Write("-");
//             }
//         }
//         Console.WriteLine();
//     }
// }


// static int ContaStepAttivi(bool[,] griglia, int traccia)
// {
//     int contatore = 0;
//     for (int stepp = 0; stepp < griglia.GetLength(1); stepp++)
//     {
//         if (griglia[traccia, stepp])
//         {
//             contatore++;
//         }
//     }
//     return contatore;
// }

// static bool BpmValido(int bpm)
// {
//     return bpm >= 40 && bpm <= 240;
// }

// static bool IndiceValido(int valoreDaVerificare, int valoreCorretto)
// {
//     return valoreDaVerificare >= 0 && valoreDaVerificare < valoreCorretto;
// }

// static float CampioniPerSemicroma(int bpm, int sampleRate)
// {
//     float campioni = 60f * sampleRate / bpm;
//     return campioni / 4f;
// }

// static float DurataStepinMS (int bpm)
// {
//     return 60000f / bpm / 4f;
// }













// static void StampaTraccia (bool[] traccia)
// {
// foreach (bool vero in traccia)
// {
//     if (vero)
//     {
//         Console.WriteLine("o");
//     }
//     else
//     {
//         Console.WriteLine("-");
//     }
// }    
// }




// Console.WriteLine("Scrivi i bpm");

// int.TryParse(Console.ReadLine(), out int valoreBpm);

// while (!BpmValido(valoreBpm))
// {
//     Console.WriteLine("Valore non valido. Riprova");
//     int.TryParse(Console.ReadLine(), out valoreBpm);
// }

// Console.WriteLine("Valore valido");







// float[] livelli = { -18f, -6.5f, -24f, -3f };

// static float PiuForte(float[] livelli)
// {
//     float piuAlto = float.NegativeInfinity;
//     foreach (float livello in livelli)
//     {
//         if (livello > piuAlto)
//         {
//             piuAlto = livello;
//         }
//     }
//     return piuAlto;
// }

// static bool LivelloFuoriRange(float db)
// {
//     return db >= 0 || db <= -60f;
// }

// static int CanalePiuForte(float[] livelli)
// {
//     int numeroIndice = -1;
//     float livelloPiuForte = float.NegativeInfinity;
//     for (int i = 0; i < livelli.Length; i++)
//     {
//         if (livelloPiuForte < livelli[i])
//         {
//             livelloPiuForte = livelli[i];
//             numeroIndice = i;
//         }
//     }
//     return numeroIndice;
// }



// bool[] traccia = { true, true, false, true, true, true, false, true };


// static int PiuLungaSerie(bool[] traccia)
// {
//     int serie = 0;
//     int seriepiulunga = 0;
//     foreach (bool valore in traccia)
//     {
//         if (valore)
//         {
//             serie++;
//             if (serie > seriepiulunga)
//             {
//                 seriepiulunga = serie;
//             }
//         }
//         else
//         {
//             serie = 0;
//         }

//     }
//     return seriepiulunga;
// }

// static int ContaSerie(bool[] traccia)
// {
//     int serie = 0;
//     int quantitaserie = 0;
//     foreach (bool valore in traccia)
//     {
//         if (valore)
//         {
//             serie++;
//         }
//         else
//         {
//             if (serie > 0)
//             {
//                 quantitaserie++;
//             }
//             serie = 0;
//         }

//     }
//     if (serie > 0)
//     {
//         quantitaserie++;
//     }
//     return quantitaserie;
// }


// Console.WriteLine ("scrivi il comando");
// string comandi = Console.ReadLine();

// switch (comandi.ToLower())
// {
//     case "play":
//         Console.WriteLine("Avvio");
//     break;
//     case "stop":
//         Console.WriteLine("Fermo");
//     break;
//     case "rec":
//         Console.WriteLine("Registro");
//     break;
//     default:
//         Console.WriteLine("Comando Sconosciuto");
//     break;
// }

// static float LivelloSuperficie(SurfaceType surface)
// {
//     float db = float.NegativeInfinity;
//     switch (surface)
//     {
//         case SurfaceType.Grass:
//         db = -12;
//         break;
//         case SurfaceType.Gravel:
//         db = -6;
//         break;
//         case SurfaceType.Wood:
//         db = -8;
//         break;
//         case SurfaceType.Metal:
//         db = -3;
//         break;
//     }
//     return db;
// }


// Console.WriteLine(LivelloSuperficie(SurfaceType.Grass));

// Console.WriteLine(LivelloSuperficie(SurfaceType.Metal));

// enum SurfaceType
// {
//     Grass,
//     Gravel,
//     Wood,
//     Metal
// }



// static float DbPerMixer(float slider)
// {
//     slider = Math.Clamp(slider, 0f, 1f);
//     float sliderclamplog = (float)(20 * Math.Log10(slider));
//     sliderclamplog = Math.Clamp(sliderclamplog, -80f, 0f);
//     return sliderclamplog;
// }


// Console.WriteLine(DbPerMixer(0f));
// Console.WriteLine(DbPerMixer(0.5f));
// Console.WriteLine(DbPerMixer(1f));
// Console.WriteLine(DbPerMixer(-0.3f));


static float Lerp(float a, float b, float t)
{
    t = Math.Clamp(t , 0f, 1f);
    float doveSto = a + (b - a) * t;
    return doveSto;
}

Console.WriteLine(Lerp(-12f, 0f, 0f));
Console.WriteLine(Lerp(-12f, 0f, 0.25f));
Console.WriteLine(Lerp(-12f, 0f, 0.5f));
Console.WriteLine(Lerp(-12f, 0f, 1f));
Console.WriteLine(Lerp(-12f, 0f, 1.5f));