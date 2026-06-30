class Musica
{
    public string Nome { get; set; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"{Nome} - {Artista}";

    public Musica (string Nome, int Duracao, bool Disponivel, Banda banda)
    {
        this.Nome = Nome;
        this.Artista = banda;
        this.Duracao = Duracao;
        this.Disponivel = Disponivel;
    }
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao/60}:{Duracao%60}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
}