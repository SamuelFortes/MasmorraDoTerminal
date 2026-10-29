Heroi heroiSamuel = new Heroi();
heroiSamuel.Nome = "Samuel";
heroiSamuel.Vida = 20;
heroiSamuel.Ataque = 15;
heroiSamuel.Defesa = 15;

heroiSamuel.ExibirFichaHeroi();

Monstro monstroGigante = new Monstro();
monstroGigante.Nome = "Monstro Gigante";
monstroGigante.Vida = 40;
monstroGigante.Ataque = 20;
monstroGigante.Defesa = 20;

heroiSamuel.Atacar(monstroGigante);
monstroGigante.Atacar(heroiSamuel);
