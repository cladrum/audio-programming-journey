// Il primo canale, già scritto prima
using System.Runtime.CompilerServices;

MixerChannel channel1 = new MixerChannel("Kick", 0f, false);
MixerChannel channel2 = new MixerChannel("Snare", -3f, false);
MixerChannel channel3 = new MixerChannel("Basso", -8f, true);

channel1.Stampa();
channel2.Stampa();
channel3.Stampa();

Console.WriteLine(channel1.DbToLinear());
Console.WriteLine(channel2.DbToLinear());
Console.WriteLine(channel3.DbToLinear());


Sound passi = new Sound("Passi", 0.4f);
Console.WriteLine(passi.DurataInCampioni(48000));
passi.ImpostaDurata(-5f);
Console.WriteLine(passi.LeggiDurata());
passi.ImpostaDurata(0.8f);
Console.WriteLine(passi.LeggiDurata());

// Il "preset" di un canale: dice quali dati ha, ma non contiene ancora valori
class MixerChannel
{
    public string Nome;     // un testo: il nome del canale
    public float VolumeDb;  // un numero decimale: il livello del fader in dB
    public bool Mute;       // vero o falso: mute acceso o spento
    public MixerChannel(string nome, float volumeDb, bool mute)
    {
        Nome = nome;
        VolumeDb = volumeDb;
        Mute = mute;
    }
    public void Stampa()
    {
    Console.WriteLine($"{Nome} {VolumeDb} {Mute}");
    }
    public float DbToLinear()
    {
        if (Mute == true)
        {
            return 0;
        }
        else
        {
            return (float)Math.Pow(10, VolumeDb / 20);
        }
    }
}



class Sound
{
    public string Nome;
    public float DurataSec
    {
        get { return _durataSec; }
        set
        {
            if (value >= 0)
            {
                _durataSec = value;
            }
        }
    }

    private float _durataSec;
    public Sound (string nome, float durata)
    {
        Nome = nome;
        DurataSec = durata;
    }
public int DurataInCampioni(int SampleRate)
    {
        return (int)(SampleRate * DurataSec);
    }  
}

