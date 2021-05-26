Trata-se de projeto de api que salva e rotorna nº de cartão de crédito fictícios

Clone o projeto,

Rode o comando dotne restore

Rode o comando dotnet run

A API tem dois endpoits e roda em localhost:

Post nesta rota cria um nº de cartão de crédito aleatório para o email dado e retorna para o requisitante. É necessário informar no reqbody: {email : xxxxx}  
https://localhost:5001/v1/categories

Get nesta endpoit retorna os registros com os nº de cartão criados para o user conforme email inofrmado 
https://localhost:5001/v1/categories/?email=[useremail aqui]

