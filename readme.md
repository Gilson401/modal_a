# ModalMais_a

ModalMais_a é uma API para gerar e persistir números de cartão de crédito gerados aleatoriamente. Também retorna a lista com o histórico de números gerados para um determinado email.
Feito em C# com .Net Core e Entity Framework Core.

## Instalação

É necessário ter o SDK e a runtime pertinente para net core5 . Clone ou baixe o projeto, rode 

```bash
dotnet restore
```
para baixar as dependências.

## Uso

Execute para iniciar o aplicativo:
```netcore
dotnet run

```
O servidor local será em https://localhost:5001

Para gerar um número de cartão faça uma requisição do tipo POST para https://localhost:5001/v1/clientes passando no body um  json como {"email": "email@email.com"}.

A resposta esperada é um json como 
{
    "id": 2,
    "email": "12@thfhfhgh.com",
    "cartao": "1288247223471533"
}

Para receber a lista dos números de cartão gerados para um determinado email faça uma requisição GET para
https://localhost:5001/v1/clientes/
passando o  email como param .


A resposta esperada é um json como :
{
    "email": "12@thfhfhgh.com",
    "listaDeCartoes": [
        "3564662621814171",
        "1288247223471533"
    ]
}

## Contribuição
Pull Requests são bem-vindas. Para mudanças importantes, abra uma issue primeiro para discutir o que você gostaria de mudar.


## Licença
[MIT](https://choosealicense.com/licenses/mit/)