Thisney Event
Sobre o Projeto
1. Objetivo
Neste projeto é implementado uma solução de arquitetura para um sistem de vendas de tickets.

2. Requisitos
API
Criar endpoints para serem usados pelo frontend da aplicação.
Criar Endpoints para processo de venda de tickets

3. Arquitetura
O projeto propõe uma arquitetura clean, com a utilização de conceitos do DDD.

API
Application
Domain
Infrasctruture
UnitTests
5. Tecnologias
ASP.NET API Versioning
Swashbuckle (Swagger)
Entity Framework
xUnit
Fluent API
Moq

Execução do Projeto
1. Migrações do Banco de Dados
Para executar os seguintes comandos, é necessário está na pasta onde a solução se encontra.

Após realizar alterações na configuração da entidade (Ex: UserConfiguration) é necessário criar uma nova migração com os campos alterados, essa ação pode ser realizada com a seguinte instrução:

dotnet ef migrations add [NomeDaMigracao] -s ThisneyTicket.API -p ThisneyTicket.Infrastructure/
Caso queira remover as migrações que foram geradas é necessário executar o próximo comando (Só é possível remover se elas não estiverem no banco de dados):

dotnet ef migrations remove -s ThisneyTicket.API -p ThisneyTicket.Infrastructure
Para que as atualizações criadas na migrate sejam feitas no banco de dados execute o seguinte comando:

dotnet ef database update -s ThisneyTicket.API -p ThisneyTicket.Infrastructure
Gerar um script sql das alterações contidas na migrate:

dotnet ef migrations script -s ThisneyTicket.API
2. Execução da API
Dotnet --- Url

dotnet run -p ThisneyTicket.API/ThisneyTicket.API.csproj

3. Execução dos Testes
-Dotnet

  dotnet test
