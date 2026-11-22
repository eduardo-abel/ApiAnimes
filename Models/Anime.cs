namespace ApiAnimes.Models;

public class Anime
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Genero { get; set; } = string.Empty;
    public int Episodios { get; set; }
    public int AnoLancamento { get; set; }
}