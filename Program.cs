
using ApiAnimes.Data;
using ApiAnimes.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AnimeDbContext>(options =>
    options.UseSqlite("Data Source=animes.db"));

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();



app.MapGet("/api/animes", async (AnimeDbContext db) =>
{
    return Results.Ok(await db.Animes.ToListAsync());
});

app.MapGet("/api/animes/{id}", async (int id, AnimeDbContext db) =>
{
    var anime = await db.Animes.FindAsync(id);

    return anime is null ? Results.NotFound() : Results.Ok(anime);
});

app.MapPost("/api/animes", async (AnimeInput input, AnimeDbContext db) =>
{
    var anime = new Anime
    {
        Nome = input.Nome,
        Genero = input.Genero,
        Episodios = input.Episodios,
        AnoLancamento = input.AnoLancamento
    };

    db.Animes.Add(anime);
    await db.SaveChangesAsync();

    return Results.Created($"/api/animes/{anime.Id}", anime);
});

app.MapPut("/api/animes/{id}", async (int id, AnimeInput input, AnimeDbContext db) =>
{
    var anime = await db.Animes.FindAsync(id);

    if (anime is null)
        return Results.NotFound();

    anime.Nome = input.Nome;
    anime.Genero = input.Genero;
    anime.Episodios = input.Episodios;
    anime.AnoLancamento = input.AnoLancamento;

    await db.SaveChangesAsync();

    return Results.Ok(anime);
});

app.MapDelete("/api/animes/{id}", async (int id, AnimeDbContext db) =>
{
    var anime = await db.Animes.FindAsync(id);

    if (anime is null)
        return Results.NotFound();

    db.Animes.Remove(anime);
    await db.SaveChangesAsync();

    return Results.NoContent();
});

app.Run();
