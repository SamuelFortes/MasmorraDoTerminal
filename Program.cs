Heroi heroiSamuel = new Heroi();
heroiSamuel.Nome = "Samuel";
heroiSamuel.Vida = 20;
heroiSamuel.Ataque = 15;
heroiSamuel.Defesa = 15;

heroiSamuel.ExibirFichaHeroi();

Monstro monstroGigante = new Monstro();
monstroGigante.Nome = "Monstro Gigante";
monstroGigante.Vida = 40;
monstroGigante.Ataque = 15;
monstroGigante.Defesa = 15;

// luta

void Batalha(Heroi heroi, Monstro monstro)
{
    Console.WriteLine($"Uma batalha entre {heroi.Nome} e {monstro.Nome} irá se iniciar!");
    while (true)
    {
        heroi.Atacar(monstro);
        if(monstro.Vida <= 0)
        {
            Console.WriteLine($"A batalha se encerrou, o vencendor foi {heroi.Nome}!");
            break;
        }
        monstro.Atacar(heroi);
        if(heroi.Vida <= 0)
        {
            Console.WriteLine($"A batalha se encerrou, o vencendor foi {monstro.Nome}!");
            break;
        }

        if((heroi.Ataque == monstro.Defesa) || (monstro.Ataque == heroi.Defesa))
        {
            Console.WriteLine("Como ambos possuem a mesma força, então a batalha será encerrada!");
            break;
        }
        
    }
}

Batalha(heroiSamuel, monstroGigante);
