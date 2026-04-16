# Projeto do Semestre

## Stack sugerida

- Frontend: React Native com TypeScript
- Backend: `json-server`
- Navegacao: login -> home -> lista de tarefas
- Funcao principal funcionando com back: cadastro, listagem e conclusao de tarefas

## Tema sugerido

Aplicativo de organizacao de rotina.

## Requisitos atendidos

- Modelagem do banco de dados
- Front de login
- Back de login com `json-server`
- Tela home inicial
- Back da home com `json-server`
- Uma funcao completa do sistema funcionando com back

## Modelagem do banco

### Tabela `usuarios`

Guarda os dados de acesso do usuario.

Campos:

- `id`: number
- `nome`: string
- `email`: string
- `senha`: string

Exemplo:

```json
{
  "id": 1,
  "nome": "Julio",
  "email": "julio@email.com",
  "senha": "123456"
}
```

### Tabela `tarefas`

Guarda as atividades cadastradas pelo usuario.

Campos:

- `id`: number
- `usuarioId`: number
- `titulo`: string
- `descricao`: string
- `prioridade`: string
- `horario`: string
- `concluida`: boolean

Exemplo:

```json
{
  "id": 1,
  "usuarioId": 1,
  "titulo": "Estudar React Native",
  "descricao": "Revisar componentes e props",
  "prioridade": "alta",
  "horario": "19:00",
  "concluida": false
}
```

## Relacionamento

- Um `usuario` pode ter varias `tarefas`
- Cada `tarefa` pertence a um `usuario` por meio do campo `usuarioId`

## `db.json` sugerido

```json
{
  "usuarios": [
    {
      "id": 1,
      "nome": "Julio",
      "email": "julio@email.com",
      "senha": "123456"
    }
  ],
  "tarefas": [
    {
      "id": 1,
      "usuarioId": 1,
      "titulo": "Estudar React Native",
      "descricao": "Revisar a aula 15",
      "prioridade": "alta",
      "horario": "19:00",
      "concluida": false
    },
    {
      "id": 2,
      "usuarioId": 1,
      "titulo": "Fazer trabalho do semestre",
      "descricao": "Montar login e home",
      "prioridade": "media",
      "horario": "21:00",
      "concluida": true
    }
  ]
}
```

## Frontend

### Tela de Login

Campos:

- Email
- Senha
- Botao `Entrar`

Fluxo:

1. Usuario digita email e senha
2. App consulta `/usuarios?email=...&senha=...`
3. Se encontrar usuario, entra na home
4. Se nao encontrar, exibe mensagem de erro

### Tela Home

Elementos:

- Saudacao com nome do usuario
- Lista de tarefas
- Botao para adicionar tarefa
- Botao para marcar tarefa como concluida
- Botao para remover tarefa

## Backend com `json-server`

### Endpoints usados

Login:

- `GET /usuarios?email=julio@email.com&senha=123456`

Home:

- `GET /tarefas?usuarioId=1`

Funcao principal:

- `POST /tarefas`
- `PATCH /tarefas/1`
- `DELETE /tarefas/1`

## Funcao do sistema funcionando com back

Funcao sugerida: gerenciamento de tarefas.

Operacoes:

1. Fazer login com usuario salvo no `json-server`
2. Listar tarefas do usuario na home
3. Adicionar nova tarefa
4. Marcar tarefa como concluida
5. Excluir tarefa

Essa funcao ja demonstra integracao real entre front e back.

## Estrutura sugerida do projeto

```text
src/
  api/
    api.ts
  screens/
    LoginScreen.tsx
    HomeScreen.tsx
  types/
    index.ts
  services/
    authService.ts
    tarefasService.ts
  components/
    TaskCard.tsx
App.tsx
db.json
```

## Exemplo de roteiro para apresentacao

1. Mostrar a modelagem do banco
2. Mostrar o `db.json`
3. Executar o `json-server`
4. Abrir a tela de login
5. Fazer login com usuario de teste
6. Mostrar a home carregando dados do back
7. Adicionar ou concluir uma tarefa para provar a integracao

## Conclusao

O projeto mais seguro para entregar dentro do prazo e:

- Login com `json-server`
- Home com lista de tarefas
- CRUD basico de tarefas

Isso atende o enunciado e fica bem alinhado com o conteudo da aula 15.
