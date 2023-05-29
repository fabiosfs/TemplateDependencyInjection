# TemplateDependencyInjection

Este � um template de projeto utilizando inje��o de depend�ncia focando mais no clean code.

Neste projeto utilizei Entity Framework Core de ORM, banco de dados SQL Server, para conectar em sua base.

Para execu��o do projeto localmente, voc� deve ter instalado no seu computador o SQL Server e deve alterar a connection string do banco de dados que se encontra no arquivo appsettings.json, propriedade FirstDb.

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
add-migration CreateClientTable -project TemplateInjecaoDependencia.Infrastructure
