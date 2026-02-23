TechStoreAPI 🛒

TechStoreAPI é uma API REST robusta desenvolvida com ASP.NET Core para a gestão completa de produtos e pedidos. O projeto foi estruturado seguindo as melhores práticas de desenvolvimento, incluindo arquitetura em camadas e segurança via autenticação JWT.

🚀 Tecnologias Utilizadas

Linguagem: C# 

Framework: ASP.NET Core (.NET 8 ou 6) 

ORM: Entity Framework Core

Banco de Dados: SQL Server / Azure SQL 

Autenticação: JWT (JSON Web Token) 

Documentação: Swagger (OpenAPI)

🎯 O Problema
Em cenários de e-commerce e gestão de estoque, a falta de uma interface centralizada e segura para o controle de produtos e pedidos pode gerar inconsistências nos dados e falhas de segurança. O TechStoreAPI foi desenvolvido para resolver a necessidade de um sistema backend performático que garanta:

Integridade dos Dados: Evitando pedidos sem produtos ou com estoque insuficiente.

Segurança de Acesso: Garantindo que apenas usuários autorizados realizem operações críticas.

Escalabilidade: Permitindo que o sistema cresça sem perder organização, graças à arquitetura em camadas.

🏗️ Arquitetura e Padrões
O projeto foi desenvolvido focando em Clean Code e separação de responsabilidades:

Domain: Entidades e interfaces de negócio.

Infrastructure: Implementação do banco de dados com EF Core e repositórios.

Service: Lógica de negócio e validações.

API: Controllers e configuração de injeção de dependência.

🛠️ Funcionalidades Principais
Gestão de Produtos: CRUD completo com validações de estoque.

Processamento de Pedidos: Fluxo de criação de ordens de compra e cálculo automático de valores.

Segurança: Hash de senhas com BCrypt.Net e autenticação via JWT (JSON Web Token).

Persistência: Migrations para versionamento do esquema do banco de dados.

🏁 Como Rodar o Projeto
1. Clone o repositório:

```bash
git clone https://github.com/mathdp13/TechStoreAPI.git
```

2. Configure o Banco de Dados:
Ajuste a ConnectionString no arquivo appsettings.json para apontar para sua instância do SQL Server.

3. Execute as Migrations:

```Bash
dotnet ef database update
```

4. Inicie a API:

```Bash
dotnet run
```

5. Acesse o Swagger: Abra https://localhost:5001/swagger no seu navegador para testar os endpoints.

   ----------------------------------------

👤 Autor

Matheus de Paula – Engenheiro de Computação.

LinkedIn: linkedin.com/in/mathtech 

GitHub: @mathdp13
