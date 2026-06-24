class Album {
    public  string Nome { get; set; }
    public string Banda { get; set; }

    private List<Musica> musicas = new List<Musica>();
    public int Duracao { get; set; }
    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }
}

