# TemplateDependencyInjection

Este é um template de projeto utilizando injeção de dependência focando mais no clean code.

Neste projeto utilizei Entity Framework Core de ORM, banco de dados SQL Server, para conectar em sua base.

Para execução do projeto localmente, você deve ter instalado no seu computador o SQL Server e deve alterar a connection string do banco de dados que se encontra no arquivo appsettings.json, propriedade FirstDb.

Foi utilizado Migration para versionamento da base de dados, então não precise se preocupar em criar a tabela Client para seu projeto executar corretamente, assim que a connection string estiver correta e o projeto for executado, a tabela será criada pelo Migration.

## Migration

Para criação de novas tabelas, deve ser criada a entidade e realizar o mapeamento na classe de contexto do banco de dados, no caso desse projeto, a classe é FirstDbContext, após isso executar o comando abaixo no "Console do gerenciador de pacotes" do Visual Studio.

No comando abaixo, eu direcionei em qual projeto seria criada a estrutura do migration informando o seu nome no final da instrução.

> add-migration CreateClientTable -project TemplateInjecaoDependencia.Infrastructure

## Pacotes instalados

### Projeto TemplateDependencyInjection.

Microsoft.EntityFrameworkCore.Design

### Projeto TemplateDependencyInjection.Domain

AutoMapper

AutoMapper.Extensions.Microsoft.DependencyInjection

### Projeto TemplateDependencyInjection.Infrastructure

Microsoft.EntityFrameworkCore

Microsoft.EntityFrameworkCore.SqlServer

Microsoft.EntityFrameworkCore.Tools