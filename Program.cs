using ScreenSound;

//Banda banda = new Banda("Queen");

//Musica musica1 = new Musica("Love of my life", banda)
//{
//  Duracao = 213,
//  Disponivel = true
//};

//Musica musica2 = new Musica("Bohemian Rhapsody", banda)
//{
//  Duracao = 354,
//  Disponivel = false
//};

//Album album = new Album("A night at the opera");

//Console.WriteLine("--- Musicas --");
//album.AdicionarMusica(musica1);
//album.AdicionarMusica(musica2);

//musica1.ExibirFichaTecnica();
//musica2.ExibirFichaTecnica();

//Console.WriteLine("\r\n--- Album ---");
//album.ExibirMusicasDoAlbum();

//Console.WriteLine("\r\n--- Banda ---");
//banda.AdicionarAlbum(album);
//banda.ExibirDiscografia();

Console.WriteLine("\r\n--- Podcasts --");

var podcast = new Podcast("Programação em C-Sharp", "https://www.ppro/c-sharp.com");
Episodio episodio, episodio1, episodio2, episodio3;

episodio2 = new Episodio(3, "Aprofundado em OOP", 650);
episodio2.AdicionarConvidados("Fulano");
episodio2.AdicionarConvidados("Ciclano");

episodio = new Episodio(1, "Iniciando", 650);
episodio.AdicionarConvidados("Fulano");
episodio.AdicionarConvidados("Astoufo");

episodio1 = new Episodio(2, "Evoluindo", 650);
episodio1.AdicionarConvidados("Astoufo");

Console.WriteLine("\r\n--- Podcasts view --");
podcast.AdicionarEpsodio(episodio);
podcast.AdicionarEpsodio(episodio1);
podcast.AdicionarEpsodio(episodio2);
podcast.ExibirDetalhes();

