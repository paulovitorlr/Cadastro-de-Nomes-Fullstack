# 📌 Cadastro de Nomes Fullstack

Projeto fullstack desenvolvido para demonstrar a comunicação entre **Angular (frontend)** e **.NET Minimal API (backend)**.

O sistema permite cadastrar, listar e remover pessoas através de uma interface web que consome uma API REST.

---

# 🚀 Tecnologias Utilizadas

## 🔙 Backend

* .NET 7/8 Minimal API
* C#
* In-memory data (lista em memória)
* CORS habilitado

## 🎨 Frontend

* Angular
* TypeScript
* HttpClient
* RxJS

---

# 🏗️ Arquitetura do Projeto

```
Cadastro-de-Nomes-Fullstack/
├── PessoaAPI/      → Backend .NET
└── ConsumirAPI/    → Frontend Angular
```

### 📌 Responsabilidades

**Backend (PessoaAPI)**

* Expõe endpoints HTTP
* Gerencia os dados de pessoas
* Processa requisições

**Frontend (ConsumirAPI)**

* Interface do usuário
* Consome a API
* Exibe e manipula dados

---

# 🔄 Fluxo da Aplicação

```
Usuário digita nome
      ↓
Angular captura evento
      ↓
Service faz requisição HTTP
      ↓
API recebe a requisição
      ↓
API processa e retorna JSON
      ↓
Angular atualiza a tela
```

---

# 🔌 Endpoints da API

## 📥 Listar pessoas

```
GET /pessoas
```

Retorna todas as pessoas cadastradas.

---

## ➕ Adicionar pessoa

```
POST /pessoas
```

Adiciona uma nova pessoa à lista.

---

## ❌ Remover pessoa

```
DELETE /pessoas/{id}
```

Remove uma pessoa pelo ID.

---

# ▶️ Como Executar o Projeto

## ✅ Pré-requisitos

* Node.js
* Angular CLI
* .NET SDK
* Git

---

## 🔙 Rodando o Backend

```bash
cd PessoaAPI
 dotnet run
```

A API normalmente ficará em:

```
http://localhost:xxxx
```

---

## 🎨 Rodando o Frontend

```bash
cd ConsumirAPI
npm install
ng serve
```

A aplicação Angular ficará em:

```
http://localhost:4200
```

---

# ⚠️ Observações Importantes

* Os dados são armazenados **apenas em memória**
* Ao reiniciar a API, os dados são perdidos
* Projeto com foco educacional e demonstração de integração fullstack

---

# 🧠 Aprendizados Demonstrados

* Comunicação Angular ↔ .NET
* Consumo de API REST
* Uso de Minimal API
* Estruturação de projeto fullstack
* Uso de Observables no Angular
* Separação de responsabilidades

---

# 🚀 Melhorias Futuras

* [ ] Persistência com Entity Framework

* [ ] Banco de dados 

* [ ] **Melhorar o CSS da aplicação** — Refinar layout, responsividade e feedback visual para melhor experiência do usuário e apresentação profissional.

* [ ] **Implementar PUT no frontend (rota já existente na API)**
  Atualmente a API já possui endpoint para atualização, mas o frontend ainda não consome essa funcionalidade. Implementar o método PUT no Angular permitirá edição de registros, completando o ciclo CRUD (Create, Read, Update, Delete) e deixando a aplicação mais próxima de um cenário real de produção.

* [ ] **Substituir Map isolado por MapGroup no backend**
  Hoje as rotas estão mapeadas individualmente. O uso de `MapGroup` permite agrupar endpoints relacionados (ex: `/pessoas`) trazendo benefícios importantes:

  * melhor organização do código
  * redução de repetição de prefixos
  * aplicação centralizada de middlewares (ex: authorization, versionamento)
  * maior escalabilidade da API

  Essa é uma prática recomendada em Minimal APIs modernas.

* [ ] **Remover lambdas das rotas e extrair para métodos nomeados**
  Atualmente os endpoints utilizam lambdas inline. Extrair a lógica para métodos dedicados melhora significativamente a qualidade do código porque:

  * aumenta a legibilidade
  * facilita testes unitários
  * melhora a manutenção
  * reduz o tamanho do `Program.cs`
  * segue melhor o princípio de responsabilidade única

  Em projetos maiores, manter toda a lógica dentro de lambdas torna o código difícil de escalar e manter.

---

# 👨‍💻 Autor

**Paulo Vitor Lopes Ribeiro dos Santos**

* LinkedIn: [www.linkedin.com/in/paulo-vitor-lopes](http://www.linkedin.com/in/paulo-vitor-lopes)
* GitHub: [https://github.com/paulovitorlr](https://github.com/paulovitorlr)

---

# ⭐ Objetivo do Projeto

Este projeto foi desenvolvido com fins de estudo e para compor portfólio de desenvolvedor fullstack júnior, demonstrando a integração entre frontend Angular e backend .NET.
