class Episodio
{
    public int Duracao { get; }
    public int Ordem { get; }
    public string Resumo => $"Número: {Ordem}\nTítulo: {Titulo}\nDuração: {Duracao}\nConvidados: {(Convidados.Count > 0 ? string.Join(", ", Convidados) : "Nenhum convidado" ) }\n- - - - - - ";
    public string Titulo { get; }
    public List<string> Convidados { get; } = new List<string>();
    private static int Instancias = 0;

    public Episodio(string Titulo, int Duracao)
    {
        Instancias++;
        this.Titulo = Titulo;
        this.Duracao = Duracao;
        this.Ordem = Instancias;
        
        
    }

    public void AdicionarConvidado(string convidado)
    {
        Convidados.Add(convidado);
    }
}

