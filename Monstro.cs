class Monstro
{
    public string Nome { get; set; }
    public int Vida { get; set; }
    public int Ataque { get; set; }
    public int Defesa { get; set; }

    public void Atacar(Heroi heroi)
    {
        if(Ataque > heroi.Defesa)
        {
            Console.WriteLine($"O monstro {Nome} irá atacar o herói {heroi.Nome} e seu ataque causará {Ataque - heroi.Defesa} de dano!");
            heroi.ReceberDano(Ataque - heroi.Defesa);
        }
        else if (Ataque < heroi.Defesa)
        {
            Console.WriteLine($"O monstro {Nome} irá atacar o herói {heroi.Nome} e seu ataque causará 0 de dano!, o {heroi.Nome} defendeu");
            heroi.ReceberDano(0);
        }
        else
        {
            Console.WriteLine($"O ataque do monstro {Nome} não surtiu nenhum efeito! ambos possuem a mesma força");
            heroi.ReceberDano(0);
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