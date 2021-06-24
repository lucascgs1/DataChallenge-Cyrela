# DataChallenge Cyrela

'''
86084 - Alan Oliveira
84177 - Lucas Coutinho Gonçalves de Souza
85928 - Natália Batista dos Santos
85818 - Rafael Silva Romualdo

'''
## Desafio
- Utilizar os arquivos csv e planilhas em excel fornecidas pela cyrela para consistir e relacionar uma base dados
- Limpar, formatar e relacionar a base de dados
- Fornecer os dados em formato multidimensional para utilização de uma plataforma de BI

## Tecnologias utilizadas

- .NET 5
- SQL SERVER
- PowerBI

## Organização do projeto
#### Dados fornecidos
```
*script de criação de tabelas*
01 - DDL Criação das tabelas

*csv com dados das tabelas*
02 - Dados contidos nas tabelas

*planilhas excel com dados para relacionar*
03 - Panilhas de uso interno
```
#### Dados Gerados
```
*script de criação de tabelas*
01 - SQL QUERY
    *Scripts de criacao e inserts das tabelas dos csv*
    01 - Tabelas csv
    
    *Scripts de criacao das tabelas do starScheme*
    02 - Tabelas ETL

    *Arquivos do modelo relacional*
    02 - StarScheme
    
*Aplicacao responsavel por formatar os dados e gravar nas tabelas acessadas pelo bi*
02 - Aplicacao .net

*Arquivos ppt e pdf da aprensetacao*
03 - Apresentação
```

### Dependencias de projeto

Para abrir a aplicação é necessario Instalar o [visual studio] com o pacote de desenvolvimento .net web

### Execução

 - Criar um banco sql
 - Executar os scripts gerados na ordem na nomeação das pastas
 - adicionar a conection string no arquivo appsettings.json
 - executar a api apertando f5 ou clicando no botao verde no centro superior da tela
 - Realizar uma requisicao get na url https://localhost:44337/Home
 - Abra o powerBi e importe o banco de dados sql server
 - coloque a url do banco e o login e senha do banco de dados
 - selecione as tabelas que serao utilizadas
 - monte seus graficos

[visual studio]: <https://visualstudio.microsoft.com/pt-br/downloads/>