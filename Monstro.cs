class Monstro
{
    public string Nome { get; set; }
    public int Vida { get; set; }
    public int Ataque { get; set; }
    public int Defesa { get; set; }

    public void Atacar(Heroi heroi)
    {
        int ataqueDoMonstro = Ataque;
        string nomeDoMonstro = Nome;
        Console.WriteLine($"O monstro {Nome} irá atacar agora!");
        heroi.ReceberDano(ataqueDoMonstro, nomeDoMonstro);
    }

    public void ReceberDano(int ataqueDoHeroi, string nomeDoHeroi)
    {
        if(ataqueDoHeroi > Defesa)
        {
            Console.WriteLine($"O herói {nomeDoHeroi} irá atacar o monstro {Nome} e seu ataque causará {ataqueDoHeroi - Defesa} de dano!");
            Vida -= ataqueDoHeroi - Defesa;
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
        else if (ataqueDoHeroi < Defesa)
        {
            Console.WriteLine($"O herói {nomeDoHeroi} irá atacar o monstro {Nome} e seu ataque causará 0 de dano!, {Nome} defendeu");
            Thread.Sleep(2);
        }
        else
        {
            Console.WriteLine($"O ataque do herói {nomeDoHeroi} não surtiu nenhum efeito! ambos possuem a mesma força");
            Thread.Sleep(2);
        }

        if(Vida <= 0)
        {
            Console.WriteLine($"O monstro {Nome} caiu!");
        }
    }
}