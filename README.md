# 🚀 Sistema de Gerenciamento - SalesWebMvc

Aplicação web desenvolvida com ASP.NET Core MVC para gerenciamento de vendedores, departamentos e registros de vendas.

## 📖 Sobre o Projeto

O objetivo deste projeto é aplicar conceitos de desenvolvimento web utilizando ASP.NET Core MVC, Entity Framework Core e banco de dados MySQL.

A aplicação permite realizar operações de cadastro, edição, consulta e remoção de informações relacionadas a vendedores, departamentos e vendas.

## 🛠 Tecnologias Utilizadas

* C#
* ASP.NET Core MVC
* Entity Framework Core
* MySQL
* Bootstrap
* LINQ
* Git e GitHub

## ✨ Funcionalidades

* Cadastro de vendedores
* Edição de vendedores
* Exclusão de vendedores
* Cadastro de departamentos
* Consulta de registros de vendas
* Busca simples de vendas
* Busca agrupada por departamento
* Relacionamento entre entidades
* Persistência de dados com Entity Framework Core

## 📂 Estrutura do Projeto

```text
Controllers/
Models/
Views/
Services/
Data/
wwwroot/
```

## ⚙️ Como Executar

1. Clone o repositório:

```bash
git clone https://github.com/LucasDuarteV/projeto-sistema.git
```

2. Acesse a pasta do projeto:

```bash
cd projeto-sistema
```

3. Configure a Connection String no arquivo:

```text
appsettings.json
```

4. Execute as migrations:

```bash
dotnet ef database update
```

5. Inicie a aplicação:

```bash
dotnet run
```

## 📸 Telas

* Home
* Sellers
* Departments
* Sales Records
* Busca Simples
* Busca Agrupada

## 🎯 Conceitos Aplicados

* MVC (Model-View-Controller)
* CRUD Completo
* Entity Framework Core
* Injeção de Dependência
* Programação Assíncrona
* Relacionamentos entre Entidades
* Tratamento de Exceções
* Boas Práticas de Desenvolvimento

## 👨‍💻 Autor

Lucas Duarte

GitHub:
https://github.com/LucasDuarteV
