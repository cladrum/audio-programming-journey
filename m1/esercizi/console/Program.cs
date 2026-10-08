SoundCategory categoria = SoundCategory.Dialogue;

switch (categoria)
{
    case SoundCategory.Music:
    Console.WriteLine("Music");
    break;

    case SoundCategory.Footstep:
    Console.WriteLine("Passi");
    break;

    case SoundCategory.UI:
    Console.WriteLine("UI");
    break;

    case SoundCategory.Ambience:
    Console.WriteLine("ambiente");
    break;

    default:
    Console.WriteLine("sconosciuto");
    break;
}

enum SoundCategory { Footstep, Ambience, Music, UI, Dialogue }
