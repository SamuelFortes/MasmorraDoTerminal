class Heroi
{
    public string Nome { get; set; }
    public int Vida { get; set; }
    public int Ataque { get; set; }
    public int Defesa { get; set; }

    public void Atacar(Monstro monstro)
    {
        int ataqueDoHeroi = Ataque;
        string nomeDoHeroi = Nome;
        Console.WriteLine($"O herói {Nome} irá atacar agora!");
        monstro.ReceberDano(ataqueDoHeroi, nomeDoHeroi);
    }

    public void ReceberDano(int ataqueDoMonstro, string nomeDoMonstro)
    {

        if(ataqueDoMonstro > Defesa)
        {
            Console.WriteLine($"O monstro {nomeDoMonstro} irá atacar o herói {Nome} e seu ataque causará {ataqueDoMonstro} de dano!");
            Vida -= ataqueDoMonstro;
            if(Vida < 0)
            {
                Console.WriteLine($"Pts de vida atuais do herói {Nome}: 0");
            }
            else
            {
                Console.WriteLine($"Pts de vida atuais do herói {Nome}: {Vida}");
            }
            Thread.Sleep(2);
        }
        else if (ataqueDoMonstro < Defesa)
        {
            Console.WriteLine($"O monstro {nomeDoMonstro} irá atacar o herói {Nome} e seu ataque causará 0 de dano!, {Nome} defendeu");
            Thread.Sleep(2);
        }
        else
        {
            Console.WriteLine($"O ataque do monstro {nomeDoMonstro} não surtiu nenhum efeito! ambos possuem a mesma força");
            Thread.Sleep(2);
        }

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