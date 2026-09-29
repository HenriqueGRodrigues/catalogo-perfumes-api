# 🏷️ Perfume Catalog API (Catálogo de Fragrâncias RESTful)

Uma API Web desenvolvida em **C# (ASP.NET Core)** para gestão de um catálogo especializado em fragrâncias de nicho e designer. O projeto demonstra a construção de um backend robusto, utilizando arquitetura REST para disponibilizar dados estruturados (JSON) que podem ser consumidos por qualquer aplicação frontend ou mobile.

---

## 🚀 Sobre o Projeto

Este sistema atua como o motor de dados (backend) de um catálogo de produtos. Ele permite simular o fluxo real de uma aplicação corporativa, onde os dados dos itens (nome, marca, categoria e preço) são geridos de forma centralizada através de requisições HTTP padronizadas.

## 🛠️ Tecnologias Utilizadas

* **C# 12 / .NET 8**
* **ASP.NET Core Web API**
* **Arquitetura REST (Controllers, Endpoints, HTTP Methods)**

## 🔌 Endpoints Disponíveis (Rotas)

A API responde aos seguintes comandos HTTP:

* `GET /api/perfumes` - Retorna a lista completa de todos os perfumes catalogados.
* `GET /api/perfumes/{id}` - Busca um perfume específico pelo seu ID.
* `POST /api/perfumes` - Adiciona uma nova fragrância ao catálogo.
* `DELETE /api/perfumes/{id}` - Remove um perfume do sistema.

## ⚙️ Como Executar e Testar Localmente

1. Clone este repositório:
   ```bash
   git clone [https://github.com/HenriqueGRodrigues/catalogo-perfumes-api.git](https://github.com/HenriqueGRodrigues/catalogo-perfumes-api.git)
