Console.WriteLine("Scrivi un numero di nota MIDI:");
int nota = int.Parse(Console.ReadLine());
if (nota >= 0 && nota <= 127)
{
    Console.WriteLine("Hai scelto la nota " + nota);

    float esponente = (nota - 69) / 12f;
    float potenza = MathF.Pow(2f , esponente);
    float risultato = 440f * potenza;

    string[] nomi = { "Do", "Do#", "Re", "Re#", "Mi", "Fa", "Fa#", "Sol", "Sol#", "La", "La#", "Si" };

    int indiceNota = nota % 12;

    Console.WriteLine($"La frequenza è {risultato}hz");
    Console.WriteLine($"La nota è un {nomi[indiceNota]}");
}
else
{
    Console.WriteLine("Numero nota MIDI non valido");
}