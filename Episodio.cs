namespace ScreenSound;

public class Episodio
{
	public List<string> Convidados = new();


	public string Titulo { get; }
	public int Duracao { get; }
	public int Ordem { get; }
	public string Resumo => $"{Ordem}. {Titulo} duração: ({Duracao} min) \r\n{string.Join(", ", Convidados)}";

	public Episodio(int ordem, string titulo, int duracao)
	{
		Titulo = titulo;
		Duracao = duracao;
		Ordem = ordem;
	}

	public void AdicionarConvidados(string convidado)
	{
		Convidados.Add(convidado);
	}
}
