# TechStoreAPI 🛒

**TechStoreAPI** é uma solução completa de backend e frontend para gestão de produtos e usuários. O projeto foi desenvolvido com foco em **segurança**, **portabilidade via Docker** e uma **experiência de usuário fluida**, utilizando modais customizados em vez de alertas nativos do navegador.
______________________________

## 🏗️ Arquitetura e Infraestrutura
O projeto utiliza **Docker Compose** para orquestrar o ecossistema:
* **API (C# / .NET 8):** Backend robusto com persistência em SQLite.
* **Web (Nginx):** Frontend servindo a interface de gestão de forma isolada.
* **Persistência:** Utilização de **Docker Volumes** para garantir que os dados do banco SQLite não sejam perdidos entre reinicializações.

______________________________

## 🚀 Tecnologias e Segurança
* **Framework:** ASP.NET Core 8.
* **Segurança (Auth):** Proteção de rotas no Frontend via **LocalStorage** e Hashing de senhas com **BCrypt.Net** no Backend.
* **UX/UI:** Sistema de **Modais Customizados** (HTML/CSS) para confirmação de ações críticas (Salvar/Excluir), substituindo janelas nativas do navegador.
* **CORS:** Configurado para permitir a comunicação segura entre as portas `5500` (Front) e `5082` (API).
* **Documentação:** Swagger UI integrada para testes de endpoints.

______________________________

## 🛠️ Funcionalidades Principais
* **Gestão de Produtos:** CRUD completo com persistência automática.
* **Controle de Acesso:** Bloqueio de acesso direto ao `index.html` sem login prévio.
* **Ações de Confirmação:** Fluxo de "OK" e "Retomar" para edições de produtos, garantindo integridade nas alterações.

______________________________

## 🏁 Como Rodar o Projeto

A grande vantagem desta versão conteinerizada é o **Quick Start**:

1.  **Clone o repositório:**
    ```bash
    git clone [https://github.com/mathdp13/TechStoreAPI.git](https://github.com/mathdp13/TechStoreAPI.git)
    cd TechStoreAPI
    ```

2.  **Suba toda a estrutura (API + Front + Banco):**
    ```bash
    docker compose up -d --build
    ```

3.  **Acesse no navegador:**
    * **Sistema (Login):** http://localhost:5500/Frontend/login.html
    * **Swagger (Docs):** http://localhost:5082/swagger

    ______________________________

## 🧹 Manutenção (Reset de Dados)
Se precisar limpar o banco de dados e as configurações para um novo início:
```bash
docker compose down -v
docker compose up -d --build
```

 ______________________________

👤 Autor
Matheus de Paula – Engenheiro de Computação.

LinkedIn: linkedin.com/in/mathtech

GitHub: @mathdp13
