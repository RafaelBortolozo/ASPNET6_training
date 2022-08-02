# Curso ASP.NET 6

## SDK Version
```
.NET 6.0 (v6.0.302)
```

## Comandos
Cria uma pasta como novo projeto
```
dotnet new web -o <NomeProjeto>
```

Cria uma pasta e especifica qual sdk usar (use "dotnet new web -h" para mais informações. Usei o net6.0)
```
dotnet new web -o <NomeProjeto> -f net6.0
```


Lista e instala todas as dependencias
```
dotnet restore
```


Inicia compilação
```
dotnet build
```


Limpa arquivos de cache
```
dotnet clean
```


Roda aplicação
```
dotnet run   
```


Roda aplicação com auto-reload
```
dotnet watch run
```


Roda aplicação emum determinado ambiente de execução
```
dotnet run --environment=<Ambiente>
```


Cria arquivo .gitignore para postagem no github
```
dotnet new gitignore
```


Listar sdks instaladas
```
dotnet --list-sdks
```

Para o TodoList, foi usado dois pacotes
```
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
```

```
dotnet add package Microsoft.EntityFrameworkCore.Design
```

Instalação do "Entity Framework Core" e do pacote "Microsoft.EntityFrameworkCore.Design"
```
dotnet tool install --global dotnet-ef
```
```
dotnet add package Microsoft.EntityFrameworkCore.Design 
```


Adiciona uma migration visualizando mais detalhes
```
dotnet ef -v migrations add <Nome>
```


## Curiosidades do ASP.NET 6

### Padrão MVC

#### Model

 - O Model é responsavel pela manipulaçao dos dados, como por exemplo requisições em banco de dados

#### View

 - O view é á página, onde as informações serão expostas

#### Controller

 - O controller é o responsável por receber as requisições do usuário na web, entrar em contato com o model para obter informações do banco de dados e retornar uma tela ao usuário. Ele é responsável por tudo já que ele faz divisa com o usuario.

 ### Migrations
  - É uma forma de estruturar um banco de dados usando a linguagem de programação do projeto, fugindo de problemas de sintaxe e versionamento. Exemplo, podemos criar um banco de dados usando apenas um comando graças ao migration. Ele também salva os estados, permitindo retroceder ou avançar estados do banco de maneira fácil.