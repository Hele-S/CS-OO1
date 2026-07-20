//Banda band1 = new Banda("Nirvana");

//Album album1 = new Album("In Utero", band1);

//Musica song1 = new Musica("Heart-Shaped Box", 281, true, band1);


//Musica song2 = new Musica("Dumb", 151, false, band1);


//album1.AdicionarMusica(song1);
//album1.AdicionarMusica(song2);
//song1.ExibirFichaTecnica();
//album1.ExibirMusicas();
//band1.AdicionarAlbum(album1);
//band1.ExibirAlbuns();

Podcast podcast1 = new Podcast("Pod1", "Host1");
Episodio Ep1 = new Episodio("Episódio 1", 30);
Episodio Ep2 = new Episodio("Episódio 2", 31);
Ep2.AdicionarConvidado("Convidado 1");
Ep2.AdicionarConvidado("Convidado 2");
Console.WriteLine(Ep2.Resumo);
Console.WriteLine(Ep1.Resumo);
Console.WriteLine(Ep1.Ordem);


