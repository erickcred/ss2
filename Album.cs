namespace ScreenSound;

public class Album
{
  private List<Musica> _musicas = new();
  public string Nome { get; }
  public int DuracaoTotalEmSegundos => _musicas.Sum(x => x.Duracao);
  public string DuracaoTotalEmMinutos => DuracaoConvertidaEmMinuto();

  public Album(string nomeAlbum)
  {
    Nome = nomeAlbum;
  }


  public void AdicionarMusica(Musica musica)
  {
    _musicas.Add(musica);
  }

  public string DuracaoConvertidaEmMinuto()
  {
    double hora, minuto, segundo, resto;

    hora = DuracaoTotalEmSegundos / 3600;
    resto = DuracaoTotalEmSegundos % 3600;
    minuto = resto / 60;
    segundo = resto % 60;
    string tempo = $"{hora}:{minuto}:{segundo}";
    return tempo.Replace(",", ":");
  }

  public void ExibirMusicasDoAlbum()
  {
    Console.WriteLine($"Album: {Nome} duração: {DuracaoTotalEmMinutos} - {DuracaoTotalEmSegundos}\r\n");
    foreach (var musica in _musicas)
      Console.WriteLine($"Música: {musica.Nome}");
  }
}
