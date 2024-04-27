namespace ScreenSound;

public class Musica
{
  public string Nome { get; }
  public Banda Artista { get; }
  public int Duracao { get; set; }
  public bool Disponivel { get; set; }
  public string DescricaoResumida => $"A musica {Nome} pertence à banda {Artista}";


  public Musica(string nome, Banda artista)
  {
    Nome = nome;
    Artista = artista;
  }

  public string DuracaoConvertidaEmMinuto()
  {
    double hora, minuto, segundo, resto;

    hora = Duracao / 3600;
    resto = Duracao % 3600;
    minuto = resto / 60;
    segundo = resto % 60;
    string tempo = $"{hora}:{minuto}:{segundo}";
    return tempo.Replace(",", ":");
  }

  public void ExibirFichaTecnica()
  {
    var disponivel = Disponivel ? "Diponivel no palno" : "Não disponivel no plano";
    Console.WriteLine($"Musica: {Nome} - {DescricaoResumida}" +
      $"\r\nArtista: {Artista.Nome}" +
      $"\r\nDuração: {DuracaoConvertidaEmMinuto()} {disponivel}\r\n");
  }
}
