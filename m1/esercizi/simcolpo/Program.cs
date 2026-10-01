

int hp = 100;
Random rng = new Random();
int Danno()
{
    return rng.Next(10, 31);
}
while (hp > 0)
{
    int colpo =  Danno();
    hp = hp - colpo;
    if (hp <= 0)
    {
        hp = 0;
        Console.WriteLine("Nemico Morto");
    }
    else
    {
        Console.WriteLine($"{hp}");
    }
    
}