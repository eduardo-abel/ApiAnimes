# API de Animes

## Tema

API REST para cadastro e gerenciamento de animes.

## Objetivo

O projeto foi desenvolvido como uma Minimal API utilizando ASP.NET Core e .NET 10. A API permite cadastrar, consultar, alterar e excluir animes.

## Requisitos

* .NET 10
* Visual Studio Code
* Bruno para testar os endpoints

## Como executar

Abra o terminal na pasta do projeto e execute:

```bash
dotnet build
```

Depois:

```bash
dotnet run --urls http://localhost:5050
```

A API ficará disponível em: 
http://localhost:5050
```

## Endpoints

| Método | Endpoint           | Descrição                          |
| ------ | ------------------ | ---------------------------------- |
| GET    | `/`                | Verifica se a API está funcionando |
| GET    | `/api/animes`      | Lista todos os animes              |
| GET    | `/api/animes/{id}` | Busca um anime pelo ID             |
| POST   | `/api/animes`      | Cadastra um novo anime             |
| PUT    | `/api/animes/{id}` | Altera um anime                    |
| DELETE | `/api/animes/{id}` | Exclui um anime                    |

## Exemplo de POST

```json
{
  "nome": "Dragon Ball Z",
  "genero": "Ação",
  "episodios": 291,
  "anoLancamento": 1989
}
```

## Exemplo de PUT


{
  "nome": "Dragon Ball Z Kai",
  "genero": "Ação",
  "episodios": 167,
  "anoLancamento": 2009
}
```

## Armazenamento

Os dados são armazenados somente em memória utilizando uma `List<Anime>`.

Isso significa que os dados cadastrados são perdidos quando a aplicação é encerrada ou reiniciada.

## Testes no Bruno

A coleção do Bruno está localizada na pasta:


bruno


Ela contém os testes dos principais endpoints da API.

## Demonstração

Link do vídeo público:

https://youtu.be/QqkC0bnB9tU
