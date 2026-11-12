// // Il primo canale, già scritto prima
// MixerChannel channel1 = new MixerChannel("Kick", 0f, false);
// MixerChannel channel2 = new MixerChannel("Snare", -3f, false);
// MixerChannel channel3 = new MixerChannel("Basso", -8f, true);

// channel1.Stampa();
// channel2.Stampa();
// channel3.Stampa();

// Console.WriteLine(channel1.GetOutputGain());
// Console.WriteLine(channel2.GetOutputGain());
// Console.WriteLine(channel3.GetOutputGain());


// Sound passi = new Sound("Passi", 0.4f);
// Console.WriteLine(passi.DurataInCampioni(48000));
// passi.ImpostaDurata(-5f);
// Console.WriteLine(passi.LeggiDurata());
// passi.ImpostaDurata(0.8f);
// Console.WriteLine(passi.LeggiDurata());


// Oscillator Sine = new Oscillator("Sine", 440f);
// Console.WriteLine(Sine.PeriodoOnda());

// List<MixerChannel> rack = new List<MixerChannel>();
// rack.Add(new MixerChannel("Kick", 0f, false));
// rack.Add(new MixerChannel("Snare", 0f, true));
// rack.Add(new MixerChannel("Bass", 10f, false));

// foreach (MixerChannel canale in rack)
// {
//     Console.WriteLine($"{canale.Nome}, {canale.GetOutputGain()}");
// }

using System.Diagnostics;

Mixer banco = new Mixer();
banco.AggiungiCanale("Kick", 0f, false);
banco.AggiungiCanale("Snare", 0f, false);
banco.AggiungiCanale("Bass", 0f, false);

banco.StampaLivelli();

banco.ImpostaSolo("Snare", true);
banco.StampaLivelli();


class Mixer
{
    // Il rack: una lista di canali. È privato, quindi dal Main non si tocca.
    private List<MixerChannel> _canali = new List<MixerChannel>();

    // Il comando "nuova traccia": l'unica porta d'ingresso al rack.
    public void AggiungiCanale(string nome, float volumeDb, bool mute)
    {
        // Crea un canale vero con il costruttore che conosci già
        MixerChannel nuovo = new MixerChannel(nome, volumeDb, mute);
        // Lo mette nel rack. _canali è un campo del Mixer, quindi niente punto davanti
        _canali.Add(nuovo);
    }
    public void StampaLivelli()
    {
        bool solo = SoloOther();
        foreach (MixerChannel canale in _canali)
        {
            Console.WriteLine($"{canale.Nome}, {canale.GetOutputGain(solo)}");
        }
    }
    public bool SoloOther() // un metodo con foreach appena trova un valore che sta nell'if subito restitusce il return.
                            // Per poter scandagliare tutto dobbiamo inserire il return false fuori il foreach (come fosse l'else). 
                            // Se scriviamo l'else dopo l'if si ferma al primo giro perche o l'if o l'else saranno sicuramente veri.
    {
        foreach (MixerChannel canale in _canali)
        {
            if (canale.Solo == true)
            {
                return true;
            }
        }
    return false;
    }
    public void ImpostaSolo(string nome, bool solo)
    {
        foreach (MixerChannel canale in _canali)
        {
            if (canale.Nome == nome)
            {
                canale.Solo = solo;
            }
        }
    }
}


// Il "preset" di un canale: dice quali dati ha, ma non contiene ancora valori
class MixerChannel
{
    public string Nome;
    private float _volumeDb;     // un testo: il nome del canale
    public float VolumeDb
    {
        get { return _volumeDb; }
        set
        {
            _volumeDb = Math.Clamp(value, -80, 6);
        }
    } 
    public bool Mute;       // vero o falso: mute acceso o spento
    public bool Solo;
    private List<AudioEffect> _insert = new List<AudioEffect>();

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
    public float GetOutputGain(bool soloOther)
    {
        if (Mute == true)
        {
            return 0;
        }
        else if (soloOther == true && Solo == false)
        {
            return 0;
        }
        else
        {
            return (float)Math.Pow(10, VolumeDb / 20);
        }
    }
    public void AggiungiInsert(AudioEffect insert)
    {
        _insert.Add(insert);
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


class Oscillator
{
    public string Nome;
    private float _frequenza;
    public float Frequenza
    {
        get { return _frequenza; }
        set
        {
            if (value > 0)
            {
                _frequenza = value;
            }
        }
    }
    public Oscillator (string nome, float frequenza)
    {
        Nome = nome;
        Frequenza = frequenza;
    }
public float PeriodoOnda()
    {
        return 1000f / Frequenza;
    }
}

class AudioEffect
{
    public bool Bypass;

    public virtual float Process(float sample)
    {
        return sample;
    }
}

class Trim : AudioEffect
{
    public float GuadagnoDb;
    public Trim (float guadagnodb)
    {
        GuadagnoDb = guadagnodb;
    }
    public override float Process(float sample)
    {
        return (float)Math.Pow(10, GuadagnoDb / 20) * sample;
    }
}

class Gate : AudioEffect
{
    public float SogliaDb;
    public Gate (float soglia)
    {
        SogliaDb = soglia;
    }
    public override float Process(float sample)
    {
        float linear = (float)Math.Pow(10, SogliaDb / 20);
        if (sample < linear && sample > -linear) // è il gate che se sta tra i valori di soglia non suona. non pensarlo come un gate che non suona solo sotto il valore di db
                                                // impostato. in lineare stiamo tra -1 e +1, (fase e controfase), quindi se imposto linear = 0.5,
                                                // non deve suonare se sta fra -0.5 e 0.5. è la distanza dallo 0 che dobbiamo vedere.
        {
            return 0;
        }
        else
        {
            return sample;
        }
    }
}