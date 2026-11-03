class Monstro
{
    public string Nome { get; set; }
    public int Vida
    {
        get => _vida;
    }
    private int _vida;
    public int Ataque { get; set; }
    public int Defesa { get; set; }
    public bool EstaVivo => (Vida <= 0) ? false : true;
    public Monstro(string nome, int vida)
    {
        Nome = nome;

        if(vida <= 100 && vida >= 0)
        {
            _vida = vida;
        }
        else
        {
            Console.WriteLine("A quantidade máxima de pontos de vida que um personagem pode receber é de 100 pts e um personagem não pode ter pontos de vida negativos");
        }
    }

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
            _vida -= ((_vida - (ataqueDoHeroi - Defesa)) <= 0) ? _vida : ataqueDoHeroi - Defesa;
            if(Vida < 0)
            {
                Console.WriteLine($"Pts de vida atuais do monstro {Nome}: 0");
            }
            else
            {
                Console.WriteLine($"Pts de vida atuais do monstro {Nome}: {Vida}");
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

        if(!EstaVivo)
            {
                Console.WriteLine($"O monstro {Nome} caiu!");
            }
    }

    public void Curar(int ptsDeCura)
    {
        bool curarSemPassarLimite = (_vida + ptsDeCura > 100) ? false : true;
        if(ptsDeCura >= 1 && curarSemPassarLimite)
        {
            _vida += ptsDeCura;
            Console.WriteLine($"{Nome} foi curado e recebeu {ptsDeCura} pts de cura!");
            Console.WriteLine($"Pts de vida atuais do {Nome}: {Vida}");
        }
        
    }
}