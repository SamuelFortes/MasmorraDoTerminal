class Heroi
{
    public string Nome { get; set; }
    public int Vida { get; set; }
    public int Ataque { get; set; }
    public int Defesa { get; set; }

    public void Atacar(Monstro monstro)
    {
        Console.WriteLine($"O herói {Nome} irá atacar o monstro {monstro.Nome} e seu ataque causará {Ataque} de dano!");
        monstro.ReceberDano(Ataque);
        Thread.Sleep(2);
    }

    public void ReceberDano(int ataque)
    {
        Vida -= ataque;
        Console.WriteLine($"Pts de vida atuais do herói {Nome}: {Vida}");
        Thread.Sleep(2);

        if(Vida <= 0)
        {
            Console.WriteLine($"O herói {Nome} caiu!");
        }
        
    }

    public void ExibirFichaHeroi()
    {
        Console.WriteLine($"Ficha técnica do herói:\nNome do herói: {Nome}\nPontos de vida: {Vida}\nPontos de ataque: {Ataque}\nPontos de defesa: {Defesa}");
    }
}