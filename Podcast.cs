namespace ScreenSound;

public class Podcast
{
  public List<Episodio> episodios = new();


  public string Nome { get; }
  public string Host { get; }
  public int TotalEpisodios => episodios.Count();

  public Podcast(string nome, string host)
  {
    Nome = nome;
    Host = host;
  }

  public void AdicionarEpsodio(Episodio epsodio)
  {
    episodios.Add(epsodio);
  }

  public void ExibirDetalhes()
  {
    Console.WriteLine($"Podcast: {Nome} apresentado por {Host}");

    Console.ForegroundColor = ConsoleColor.Yellow;
    foreach (var ep in  episodios.OrderBy(x => x.Ordem))
      Console.WriteLine(ep.Resumo);
    Console.ForegroundColor = ConsoleColor.White;
    
    Console.WriteLine($"Total de Episodios {TotalEpisodios}");
  }
}
