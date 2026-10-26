# API de Animes

## Tema

API REST para cadastro e gerenciamento de animes.

## Objetivo

O projeto foi desenvolvido com Minimal API, ASP.NET Core e .NET 10. A aplicação permite cadastrar, consultar, editar e excluir animes por meio de uma API REST e de uma interface web.

Na AP2, o projeto foi atualizado para utilizar SQLite e Entity Framework Core, permitindo que os dados continuem salvos mesmo após o encerramento da aplicação.

## Tecnologias utilizadas

- .NET 10
- ASP.NET Core Minimal API
- Entity Framework Core
- SQLite
- HTML, CSS e JavaScript
- Visual Studio Code
- Bruno para testes dos endpoints

## Como executar

Abra o terminal na pasta do projeto e execute:

```bash
dotnet restore
dotnet build
dotnet ef database update
dotnet run --urls http://localhost:5051
```

A aplicação ficará disponível em:

http://localhost:5051

A interface web pode ser acessada pelo navegador nesse mesmo endereço.

## Endpoints

| Método | Endpoint | Descrição |
|---|---|---|
| GET | `/api/animes` | Lista todos os animes |
| GET | `/api/animes/{id}` | Busca um anime pelo ID |
| POST | `/api/animes` | Cadastra um novo anime |
| PUT | `/api/animes/{id}` | Altera um anime |
| DELETE | `/api/animes/{id}` | Exclui um anime |

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

```json
{
  "nome": "Dragon Ball Z Kai",
  "genero": "Ação",
  "episodios": 167,
  "anoLancamento": 2009
}
```

## Interface web

A aplicação possui uma interface web localizada em `wwwroot/index.html`, que permite:

- Listar os animes cadastrados.
- Cadastrar novos animes.
- Editar animes existentes.
- Excluir animes.

## Armazenamento de dados

Os dados são armazenados em um banco SQLite, utilizando o Entity Framework Core.

O arquivo `animes.db` é criado localmente e não deve ser enviado ao GitHub. As migrações ficam na pasta `Migrations` e permitem criar ou atualizar a estrutura do banco de dados.

Para preparar o banco em uma nova instalação, execute:

```bash
dotnet ef database update
```

## Testes no Bruno

A coleção do Bruno está disponível na pasta `bruno` do projeto e contém requisições para testar os principais endpoints da API.

## Demonstração

**Vídeo da AP1:**

https://youtu.be/QqkC0bnB9tU

**Vídeo da AP2:**

https://youtu.be/tP6s0QzsLSs
