class Monstro
{
    public string Nome { get; set; }
    public int Vida { get; set; }
    public int Ataque { get; set; }
    public int Defesa { get; set; }

    public void Atacar(Heroi heroi)
    {
        Console.WriteLine($"O monstro {Nome} irá atacar o herói {heroi.Nome} e seu ataque causará {Ataque} de dano!");
        if(Ataque > heroi.Defesa)
        {
            heroi.ReceberDano(Ataque);
        }
        else if (Ataque < heroi.Defesa)
        {
            heroi.ReceberDano(heroi.Defesa - Ataque);
        }
        else
        {
            heroi.ReceberDano(0);
            Console.WriteLine($"O ataque não surtiu nenhum efeito!");
        }
        Thread.Sleep(2);
    }

    public void ReceberDano(int ataque)
    {
        Vida -= ataque;
        Console.WriteLine($"Pts de vida atuais do monstro {Nome}: {Vida}");
        Thread.Sleep(2);

        if(Vida <= 0)
        {
            Console.WriteLine($"O monstro {Nome} caiu!");
        }
    }
}