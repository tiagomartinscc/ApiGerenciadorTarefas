# Construindo APIs com C# <img src="https://app.rocketseat.com.br/_next/image?url=%2Fassets%2Flogos%2Frocketseat-logo.svg&w=256&q=75">

<img src="https://efficient-sloth-d85.notion.site/image/https%3A%2F%2Fprod-files-secure.s3.us-west-2.amazonaws.com%2F08f749ff-d06d-49a8-a488-9846e081b224%2F8ef05315-5942-4723-aceb-5359a828f285%2FC.png?table=block&id=61b5a711-3519-42bf-b2f3-69351f85990d&spaceId=08f749ff-d06d-49a8-a488-9846e081b224&width=250&userId=&cache=v2" width="60" alt="c#">

## Construindo uma Api para Gerenciamento de tarefas

Objetivo é exercitar os conceitos de api do C# dividindo o projeto em 3 camadas:
- API - Controller
- Application - Regras de negócio
- Comminications - Classes de comunicação (Requests, Responses, Erros, Enuns)

 ## Requisitos
- Deve ser possível criar uma tarefa;
- Deve ser possível visualizar todas as tarefas criadas;
- Deve ser possível visualizar uma tarefa buscando pelo seu id;
- Deve ser possível editar informações de uma tarefa;
- Deve ser possível excluir uma tarefa.

### Uma tarefa deverá ter os seguintes campos:

- Um id único pra identificar cada tarefa;
- Um nome;
- Uma descrição sobre o que é a tarefa em si;
- Uma prioridade;
*Você pode definir se tem prioridade* `alta`, `média` *ou* `baixa`*, por exemplo;*
- Uma data limite para tarefa ser realizada;
- Um status.
*Você pode definir três status:* `concluída`*,* `em andamento` *e* `aguardando`*, por exemplo.*
