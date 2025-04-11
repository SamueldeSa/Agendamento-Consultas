# AgendaConsultaAPI - Sistema de Agendamento de Consultas Médicas

## Descrição

**AgendaConsultaAPI** é uma aplicação backend desenvolvida em **.NET 8** utilizando **ASP.NET Core Web API**. O sistema tem como objetivo gerenciar o agendamento de consultas médicas, oferecendo funcionalidades como cadastro, listagem, atualização e exclusão de pacientes. A aplicação foi criada com foco em boas práticas de arquitetura e organização de código, utilizando o padrão **Repository Pattern** e **injeção de dependência**.

## Funcionalidades

- **Cadastro de Pacientes**: Permite adicionar novos pacientes ao sistema com dados como nome completo, CPF, data de nascimento, entre outros.
- **Listagem de Pacientes**: Retorna todos os pacientes cadastrados, com possibilidade de paginação e filtros (futuramente).
- **Atualização de Pacientes**: Permite editar os dados dos pacientes já cadastrados.
- **Exclusão de Pacientes**: Remove pacientes do sistema por meio do ID.
- **Documentação com Swagger**: A API é documentada com Swagger, facilitando a visualização e testes dos endpoints.

## Tecnologias Utilizadas

- **.NET 8**
- **ASP.NET Core Web API**
- **Entity Framework Core**
- **SQL Server**
- **Repository Pattern**
- **Injeção de Dependência**
