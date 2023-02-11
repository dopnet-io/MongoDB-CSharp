# Conectando a um Cluster Atlas em Aplicativos C#

## Obtenha sua string de conexão do MongoDB

1. Acesse [login mongo atlas](https://account.mongodb.com/account/login) e faça login no Atlas. A página de login tem a seguinte aparência:

![](https://d36ai2hkxl16us.cloudfront.net/course-uploads/ae62dcd7-abdc-4e90-a570-83eccba49043/f3wzr9w9nf34-100-mongodb-login.png)

2. Uma vez conectado, você será levado ao painel do Atlas para o seu projeto atual. Clique no botão Conectar.

![](https://d36ai2hkxl16us.cloudfront.net/course-uploads/ae62dcd7-abdc-4e90-a570-83eccba49043/o6zksa29hn57-300-atlas-dashboard-connect-button.png)

3. Esta janela exibe suas opções de conexão. Clique no botão "Conectar seu aplicativo".

![](https://d36ai2hkxl16us.cloudfront.net/course-uploads/ae62dcd7-abdc-4e90-a570-83eccba49043/pxnabkw2iwd4-400-connection-string-options.png)

4. Esta janela contém as instruções para conectar seu aplicativo. Clique no ícone de cópia para copiar a string de conexão.

![](https://d36ai2hkxl16us.cloudfront.net/course-uploads/ae62dcd7-abdc-4e90-a570-83eccba49043/yppbtzerpvru-500-connection-string-window.png)

Agora você pode usar sua string de conexão para se conectar ao seu cluster Atlas!

## Implementação da Classe MongoHelper.cs

```C#
using Mongo.Driver;

var mongoUrl = ""

var client = new MongoClient(mongoUrl);

var mongodbList = client.ListDatabases().ToList();

Console.Writeline();

foreach (var mongodb in mongodbList)
{
    Console.Writeline(mongodb);
}
```
