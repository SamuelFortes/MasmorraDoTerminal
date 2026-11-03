class Heroi
{
    public string Nome { get; set; }
    public int Vida
    {
        get => _vida;
    }
    private int _vida;
    public int Ataque { get; set; }
    public bool EstaVivo => (Vida <= 0) ? false : true;
    public int Defesa { get; set; }

    public Heroi(string nome, int vida)
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
            Console.WriteLine($"O monstro {nomeDoMonstro} irá atacar o herói {Nome} e seu ataque causará {ataqueDoMonstro - Defesa} de dano!");
            _vida -= ((_vida - (ataqueDoMonstro - Defesa)) <= 0) ? _vida : ataqueDoMonstro - Defesa;
            if(!EstaVivo)
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

        if(!EstaVivo)
            {
                Console.WriteLine($"O herói {Nome} caiu!");
            }
    }

    public void Curar(int ptsDeCura)
    {
        bool curarSemPassarLimite = (Vida + ptsDeCura > 100) ? false : true;
        if(ptsDeCura >= 1 && curarSemPassarLimite && EstaVivo)
        {
            _vida += ptsDeCura;
            Console.WriteLine($"{Nome} foi curado e recebeu {ptsDeCura} pts de cura!");
            Console.WriteLine($"Pts de vida atuais do {Nome}: {Vida}");
        }
        
    }

    public void ExibirFichaHeroi()
    {
        Console.WriteLine($"Ficha técnica do herói:\nNome do herói: {Nome}\nPontos de vida: {Vida}\nPontos de ataque: {Ataque}\nPontos de defesa: {Defesa}");
    }
}