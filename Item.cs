class Item
{
    public string Nome { get; set; }
    public int ModificadorDeAtaque { get; set; }
    public int ModificadorDeDefesa { get; set; }

    public Item(string nome, int modificadorDeAtaque, int modificadorDeDefesa)
    {
        Nome = nome;
        ModificadorDeAtaque = modificadorDeAtaque;
        ModificadorDeDefesa = modificadorDeDefesa;
    }
}