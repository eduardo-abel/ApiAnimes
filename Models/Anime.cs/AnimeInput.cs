namespace ApiAnimes.Models;

public record AnimeInput(
    string Nome,
    string Genero,
    int Episodios,
    int AnoLancamento
);