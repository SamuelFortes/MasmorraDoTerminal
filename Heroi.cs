class Heroi
{
    public string Nome { get; set; }
    public int Vida { get; set; }
    public int Ataque { get; set; }
    public int Defesa { get; set; }

    public void Atacar(Monstro monstro)
    {
        if(Ataque > monstro.Defesa)
        {
            Console.WriteLine($"O herói {Nome} irá atacar o monstro {monstro.Nome} e seu ataque causará {Ataque - monstro.Defesa} de dano!");
            monstro.ReceberDano(Ataque - monstro.Defesa);
        }
        else if (Ataque < monstro.Defesa)
        {
            Console.WriteLine($"O herói {Nome} irá atacar o monstro {monstro.Nome} e seu ataque causará 0 de dano!, o {monstro.Nome} defendeu");
            monstro.ReceberDano(0);
        }
        else
        {
            Console.WriteLine($"O ataque do herói {Nome} não surtiu nenhum efeito! ambos possuem a mesma força");
            monstro.ReceberDano(0);
        }
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