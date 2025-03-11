# Calculadora Tabajara 2025

![](https://i.imgur.com/LxTvPxH.gif)

## Introdução
Uma simples calculadora de console capaz de realizar as quatro operações matemáticas.

## Funcionalidades

- **Operações Básicas:** Realiza adição, subtração, multiplicação, divisão, e tabuada.
- **Suporte a Decimais:** Capaz de trabalhar com números contendo até duas casas decimais.
- **Validação de Entrada:** A calculadora garante que apenas opções validas sejam aceitas.
- **Tratamento de Divisão por Zero:** A calculadora é capaz de validar erros de divisão por zero.
- **Histórico de Operações:** A calculadora é capaz de gravar e mostrar um histórico de operações.

## Como utilizar

1. Clone o repositório ou baixe o código fonte da Calculadora.
2. Abra o terminal ou o prompt de comando e navegue até a pasta raiz da Calculadora.
3. Utilize o comando abaixo para restaurar as dependências do projeto.

```
dotnet restore
```
4. Em seguida, compile a solução utilizando o comando:
```
dotnet build --configuration Release
```

5. Para executar o projeto compilando em tempo real
```
dotnet run --project Calculadora.ConsoleApp
```

6. Para executar o arquivo compilado, navegue até a pasta `./Calculadora.ConsoleApp/bin/Release/net8.0/` e execute o arquivo:
```
Calculdora.ConsoleApp.exe
```

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.
