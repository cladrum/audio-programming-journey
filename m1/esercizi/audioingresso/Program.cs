Random rng = new Random();
float valoreIniziale = 1000;
    for (int i = 0; i < 10; i++)
        {
            float valoreCasuale = (rng.NextSingle() * 4) -2;
                while (valoreCasuale == valoreIniziale)
        {
        valoreCasuale = (rng.NextSingle() * 4) -2;
             }
                        Console.WriteLine(valoreCasuale);
            valoreIniziale = valoreCasuale;
        }





