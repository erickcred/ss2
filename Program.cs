using ScreenSound;

Banda banda = new Banda("Queen");

Musica musica1 = new Musica("Love of my life", banda)
{
  Duracao = 213,
  Disponivel = true
};

Musica musica2 = new Musica("Bohemian Rhapsody", banda)
{
  Duracao = 354,
  Disponivel = false
};

Album album = new Album("A night at the opera");

Console.WriteLine("--- Musicas --");
album.AdicionarMusica(musica1);
album.AdicionarMusica(musica2);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

Console.WriteLine("\r\n--- Album ---");
album.ExibirMusicasDoAlbum();

Console.WriteLine("\r\n--- Banda ---");
banda.AdicionarAlbum(album);
banda.ExibirDiscografia();