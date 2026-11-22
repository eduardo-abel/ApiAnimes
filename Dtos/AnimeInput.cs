namespace ApiAnimes.Dtos;

public record AnimeInput(
    string Nome,
    string Genero,
    int Episodios,
    int AnoLancamento
);