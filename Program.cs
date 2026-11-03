Heroi heroiSamuel = new Heroi("Samuel", 11);
heroiSamuel.Ataque = 10;
heroiSamuel.Defesa = 0;

heroiSamuel.ExibirFichaHeroi();

Monstro monstroGigante = new Monstro("Monstro Gigante", 40);
monstroGigante.Ataque = 10;
monstroGigante.Defesa = 20;

// luta

void Batalha(Heroi heroi, Monstro monstro)
{
    Console.WriteLine($"Uma batalha entre {heroi.Nome} e {monstro.Nome} irá se iniciar!");
    while (true)
    {
        heroi.Atacar(monstro);
        if(!monstro.EstaVivo)
        {
            Console.WriteLine($"A batalha se encerrou, o vencendor foi {heroi.Nome}!");
            break;
        }
        monstro.Atacar(heroi);
        if(!heroi.EstaVivo)
        {
            Console.WriteLine($"A batalha se encerrou, o vencendor foi {monstro.Nome}!");
            break;
        }

        heroi.Curar(1);

        if((heroi.Ataque <= monstro.Defesa) && (monstro.Ataque <= heroi.Defesa))
        {
            Console.WriteLine("Como ambos possuem a mesma força, então a batalha será encerrada!");
            break;
        }
        
    }
}

Batalha(heroiSamuel, monstroGigante);
