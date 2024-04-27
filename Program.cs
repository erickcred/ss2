using ScreenSound;

Banda banda = new Banda("Queen");

Musica musica1 = new Musica("Love of my life", banda, 213);
Musica musica2 = new Musica("Bohemian Rhapsody", banda, 354);

Album album = new Album("A night at the opera");

Console.WriteLine(musica1.DuracaoConvertidaEmMinuto());

album.AdicionarMusica(musica1);
album.AdicionarMusica(musica2);
album.ExibirMusicasDoAlbum();
Console.WriteLine(album.DuracaoConvertidaEmMinuto());


Console.WriteLine("\r\n-----------\r\n");

banda.AdicionarAlbum(album);
banda.ExibirDiscografia();