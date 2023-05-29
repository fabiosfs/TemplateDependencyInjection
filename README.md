# TemplateDependencyInjection

Este � um template de projeto utilizando inje��o de depend�ncia focando mais no clean code.

Neste projeto utilizei Entity Framework Core de ORM, banco de dados SQL Server, para conectar em sua base.

Para execu��o do projeto localmente, voc� deve ter instalado no seu computador o SQL Server e deve alterar a connection string do banco de dados que se encontra no arquivo appsettings.json, propriedade FirstDb.

Foi utilizado Migration para versionamento da base de dados, ent�o n�o precise se preocupar em criar a tabela Client para seu projeto executar corretamente, assim que a connection string estiver correta e o projeto for executado, a tabela ser� criada pelo Migration.

## Migration

Para cria��o de novas tabelas, deve ser criada a entidade e realizar o mapeamento na classe de contexto do banco de dados, no caso desse projeto, a classe � FirstDbContext, ap�s isso executar o comando abaixo no "Console do gerenciador de pacotes" do Visual Studio.

No comando abaixo, eu direcionei em qual projeto seria criada a estrutura do migration informando o seu nome no final da instru��o.

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