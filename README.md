# First ASP.NET project


## Criando um peojeto ASP.NET Core Web App (Model-View-Controller) dotnet CLI 
> Comando utilizados para criar a estrutura de um projeto mvc utilizando o terminal e a verramenta de CLI do .netframework.

1. Com o .netframework instalado na máquina, executar o comando a seguir no diretório onde deve ficar o projeto ```$ dotnet new mvc -n <projectName> ```
2. Após a conclusão da criação do template do projeto, executar o comando ```$ dotnet build```
3. Após a conclusão do build do projeto, executar o comando ```$ dotnet run```

> Após a execução do comando run, no terminal ficará disponível os endereços IP:PORTA onde o servidor estara aguardando as requisições. Por padrão será o localhost:<portaObtidaAutomanticamente> 

### Instalando pacotes adicionais ao projeto usando o dotnet CLI
```$ dotnet add package```
> Pacotes para o projeto do curso.

1. ```$ dotnet add package Microsoft.EntityFrameworkCore.SqlServer```
2. ```$ dotnet add package Microsoft.EntityFrameworkCore.Tool```
3. ```$ dotnet tool install --global dotnet-ef```
4. ```$ dotnet tool update --global dotnet-ef```
5. ```dotnet add package Microsoft.EntityFrameworkCore.Design```
6. Validar a instalação do EntityFrameworkCore ```$ dotnet ef```

>Exemplo de saída após a execução de todas as etapas.
_/\__
               ---==/    \\
         ___  ___   |.    \|\
        | __|| __|  |  )   \\\
        | _| | _|   \_/ |  //|\\
        |___||_|       /   \\\/\\

Entity Framework Core .NET Command-line Tools 2.1.3-rtm-32065

<Usage documentation follows, not shown.>

> Comando para execução dos Migrations:

1. Criar a migration```$ dotnet ef migrations add <Migration name>```
2. Atualizar o banco de dados```$ dotnet ef database update```
