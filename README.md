# API de Animes

## Tema

API REST para cadastro e gerenciamento de animes.

## Objetivo

O projeto foi desenvolvido com Minimal API, ASP.NET Core e .NET 10. A aplicação permite cadastrar, consultar, editar e excluir animes por meio de uma API REST e de uma interface web.

Na AP2, o projeto passou a utilizar SQLite e Entity Framework Core, permitindo manter os dados salvos mesmo após o encerramento da aplicação. Na AS, foi realizada a organização do código em pastas específicas, mantendo as funcionalidades e melhorando a estrutura do projeto.

## Tecnologias utilizadas

- .NET 10
- ASP.NET Core Minimal API
- Entity Framework Core
- SQLite
- HTML, CSS e JavaScript
- Visual Studio Code
- Bruno para testes dos endpoints

## Estrutura de pastas

```text
ApiAnimes/
├── Data/
│   └── AnimeDbContext.cs
├── Dtos/
│   └── AnimeInput.cs
├── Models/
│   └── Anime.cs
├── Migrations/
├── Properties/
├── wwwroot/
│   └── index.html
├── bruno/
│   ├── environments/
│   └── requisições de teste
├── Program.cs
├── ApiAnimes.csproj
└── README.md
```

- **Data:** contém o contexto do banco de dados.
- **Dtos:** contém os tipos utilizados para receber os dados de entrada.
- **Models:** contém a entidade Anime.
- **Migrations:** contém as migrações do Entity Framework Core.
- **wwwroot:** contém a interface web.
- **bruno:** contém a coleção de requisições e o ambiente de testes.
- **Program.cs:** configura a aplicação, o banco de dados, os middlewares e as rotas da API.

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

A coleção do Bruno está disponível na pasta `bruno/` do projeto.

Foram preparadas requisições para testar:

- GET: listar os animes.
- POST: cadastrar um anime.
- GET por ID: consultar um anime cadastrado.
- PUT: alterar os dados de um anime.
- DELETE: excluir um anime.
- GET por ID após exclusão: confirmar que o registro não existe mais.

Também foi realizado um teste de persistência, cadastrando um anime, encerrando e iniciando novamente a API e consultando o registro para confirmar que os dados continuam salvos.

O ambiente local utiliza o endereço `http://localhost:5051`.

## Vídeos de demonstração

**Vídeo da AP1:**

https://youtu.be/QqkC0bnB9tU

**Vídeo da AP2:**

https://youtu.be/tP6s0QzsLSs

**Vídeo de demonstração — AS:**

https://youtu.be/yD-TrPBzKfA