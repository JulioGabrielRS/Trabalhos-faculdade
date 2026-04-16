# Organizacao de Rotina

Projeto do semestre com:

- Frontend em React Native + TypeScript
- Backend fake com `json-server`
- Tela de login
- Tela home inicial
- Funcao completa de tarefas integrada ao back

## Como executar

1. Instale as dependencias:

```bash
npm install
```

2. Inicie o backend fake:

```bash
npm run server
```

3. Em outro terminal, inicie o app:

```bash
npm start
```

## Login de teste

- Email: `julio@email.com`
- Senha: `123456`

## Endpoints usados

- `GET /usuarios?email=...&senha=...`
- `GET /tarefas?usuarioId=1`
- `POST /tarefas`
- `PATCH /tarefas/:id`
- `DELETE /tarefas/:id`

## Observacao importante

Em [src/api/api.ts](C:\Users\juliogrs\Downloads\H1\src\api\api.ts), a URL esta configurada para emulador Android:

```ts
const BASE_URL = "http://10.0.2.2:3000";
```

Se for usar celular fisico, troque para o IP da sua maquina na rede local.
