# Usando bibliotecas de cliente C# do MongoDB

## Instalação via Visual Studio

1. Para localizar o gerenciador de pacotes NuGet, vá para o menu Ferramentas no Visual Studio.

![](https://d36ai2hkxl16us.cloudfront.net/course-uploads/ae62dcd7-abdc-4e90-a570-83eccba49043/nvx534n90cnr-tools-tab.png)

2. No menu suspenso, selecione "Gerenciador de pacotes NuGet".

![](https://d36ai2hkxl16us.cloudfront.net/course-uploads/ae62dcd7-abdc-4e90-a570-83eccba49043/gbt28h7my135-nuget-package-manager.png)

3. Selecione "Gerenciar pacotes NuGet para solução..."

![](https://d36ai2hkxl16us.cloudfront.net/course-uploads/ae62dcd7-abdc-4e90-a570-83eccba49043/g5209ynmxqlq-manage-nuget-packages.png)

4. Clique na guia Procurar e digite "MongoDB.Driver" na barra de pesquisa para procurar o driver MongoDB.

![](https://d36ai2hkxl16us.cloudfront.net/course-uploads/ae62dcd7-abdc-4e90-a570-83eccba49043/e4feea1v85uy-browse-tab.png)

5. Clique no pacote denominado "MongoDB.Driver" da MongoDB Inc.

![](https://d36ai2hkxl16us.cloudfront.net/course-uploads/ae62dcd7-abdc-4e90-a570-83eccba49043/4aqn1ofcyeug-mongodb-driver.png)

6. Marque a caixa de seleção denominada Projeto.

![](https://d36ai2hkxl16us.cloudfront.net/course-uploads/ae62dcd7-abdc-4e90-a570-83eccba49043/r9xzcc3n7gc2-project.png)

7. Confirme se você está instalando a versão estável mais recente e clique no botão Instalar.

8. Conclua a instalação clicando nos botões "OK" e "Aceito" nos prompts.

## Instalação via CMD

O NuGet é a maneira mais simples de obter o driver. Usar MongoDB.Driver para todos os novos projetos.
Para obter mais informações, consulte Instalação.

    $ dotnet add package MongoDB.Driver --version 2.19.0

[fonte de instalação](https://www.nuget.org/packages/mongodb.driver#supportedframeworks-body-tab)

## Configuração na Aplicação

### ConnectionStrings

```C#
{
  "ApplicationInsights": {
    "InstrumentationKey": ""
  },
  "Logging": {
    "IncludeScopes": false,
    "LogLevel": {
      "Default": "Debug",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "MongoDB": {
    "Database": "mongodb",
    "ConnectionStrings": "mongodb://localhost:27017"
  }
}
```

## ConfigureServices

```C#
public void ConfigureServices(IServiceCollection services)
{
    // Add framework services.
    services.AddApplicationInsightsTelemetry(Configuration);

    // Add Mvc services
    services.AddMvc();               
  

    // Add Repository MongoDB e Connect
    // Connect
    services.AddScoped<IConnect, Connect>();
    // Repositories
    services.AddScoped<RepositoryPeopleImpl, RepositoryPeople>();

}
```

## Interface

## IMongoConect

```C#
using MongoDB.Driver;

namespace 
{
    public interface IMongoConnect
    {   
        IMongoCollection<T> Collection<T>(string collectionName);
        IMongoCollection<T> Collection<T>(string collectionName, MongoCollectionSettings mongoCollectionSettings);
    }
}
```
