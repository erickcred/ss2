namespace ScreenSound;

public class Musica
{
  public string Nome { get; set; }
  public Banda Artista { get; }
  public int Duracao { get; set; }
  public bool Disponivel { get; set; }
  public string DescricaoResumida => $"A musica {Nome} pertence à banda {Artista}";


  public Musica(string nome, Banda artista, int duracao)
  {
    Nome = nome;
    Artista = artista;
    Duracao = duracao;
  }

  public string DuracaoConvertidaEmMinuto()
  {
    string minutos = ((double)Duracao / 60).ToString();
    return minutos.Replace(",", ":");
  }

  public void ExibirFichaTecnica()
  {
    var disponivel = Disponivel ? "Diponivel no palno" : "Não disponivel no plano";
    Console.WriteLine($"Musica: {Nome} - {DescricaoResumida}" +
      $"\r\nArtista: {Artista}" +
      $"\r\nDuração: {new TimeSpan(Duracao).TotalMinutes} {disponivel}");
  }
}
