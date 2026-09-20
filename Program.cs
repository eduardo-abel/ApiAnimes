var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();


// Lista de animes
var animes = new List<Anime>
{
    new Anime(1, "Naruto", "Ação", 220, 2002),
    new Anime(2, "One Piece", "Aventura", 1000, 1999)
};


// Rota inicial
app.MapGet("/", () => "API de Animes funcionando!");


// Listar todos os animes
app.MapGet("/api/animes", () =>
{
    return Results.Ok(animes);
});


// Buscar anime pelo ID
app.MapGet("/api/animes/{id}", (int id) =>
{
    var anime = animes.FirstOrDefault(a => a.Id == id);

    if (anime == null)
    {
        return Results.NotFound();
    }

    return Results.Ok(anime);
});


// Cadastrar novo anime
app.MapPost("/api/animes", (AnimeInput input) =>
{
    var novoId = animes.Count == 0
        ? 1
        : animes.Max(a => a.Id) + 1;

    var novoAnime = new Anime(
        novoId,
        input.Nome,
        input.Genero,
        input.Episodios,
        input.AnoLancamento
    );

    animes.Add(novoAnime);

    return Results.Created($"/api/animes/{novoId}", novoAnime);
});


// Alterar anime
app.MapPut("/api/animes/{id}", (int id, AnimeInput input) =>
{
    var indice = animes.FindIndex(a => a.Id == id);

    if (indice == -1)
    {
        return Results.NotFound();
    }

    var animeAtualizado = new Anime(
        id,
        input.Nome,
        input.Genero,
        input.Episodios,
        input.AnoLancamento
    );

    animes[indice] = animeAtualizado;

    return Results.Ok(animeAtualizado);
});


// Excluir anime
app.MapDelete("/api/animes/{id}", (int id) =>
{
    var anime = animes.FirstOrDefault(a => a.Id == id);

    if (anime == null)
    {
        return Results.NotFound();
    }

    animes.Remove(anime);

    return Results.NoContent();
});


app.Run();


// Modelo completo do Anime
record Anime(
    int Id,
    string Nome,
    string Genero,
    int Episodios,
    int AnoLancamento
);


// Dados usados para cadastrar/alterar
record AnimeInput(
    string Nome,
    string Genero,
    int Episodios,
    int AnoLancamento
);