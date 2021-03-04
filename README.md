# CadClientes
*Sistema simples em ASPNET CORE 5 de Cadastro de Clientes*

Usando "ASPNET" e ".NET CORE 5.1".
___
## Para executar.:

1) Instale o [.NET CORE 5.0.2 ](https://dotnet.microsoft.com/download/dotnet-core/5.0)
2) Faça Download do repositório ou **git clone** em seu computador.
3) Altere a string de conexao do MySql no arquivo CadCliente/appsettings.json
4) **Execute no terminal.:**

    a) *dotnet restore*

    b) *dotnet build*

    c) *dotnet tool install --global dotnet-ef*

    d) *dotnet ef database update*

    e) *dotnet run*

___
## Caso esteja utilizando o Visual Studio.:
**Abra o Prompt do nuget e execute o seguinte comando.:**
- update-database

#### Arquivo de Migrations já compilado; Apenas execute os passos acima para fazer update no banco.

##### Projeto desenvolvido usando [Visual Studio Code](https://code.visualstudio.com), [.NET Core CLI](https://docs.microsoft.com/en-us/dotnet/core/tools/), linguagem [C#](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference) e estrutura [MVC](https://docs.microsoft.com/en-us/previous-versions/aspnet/dd381412(v=vs.108)).