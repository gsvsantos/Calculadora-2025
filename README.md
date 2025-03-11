# Calculdora Tabajara 2025

![](https://i.imgur.com/LxTvPxH.gif)

## Introdu��o
Uma simples calculadora de console capaz de realizar as quatro opera��es matem�ticas.

## Funcionalidades

- **Opera��es B�sicas:** Realiza adi��o, subtra��o, multiplica��o, divis�o, e tabuada.
- **Suporte a Decimais:** Capaz de trabalhar com n�meros contendo at� duas casas decimais.
- **Valida��o de Entrada:** A calculadora garante que apenas op��es validas sejam aceitas.
- **Tratamento de Divis�o por Zero:** A calculadora � capaz de validar erros de divis�o por zero.
- **Hist�rico de Opera��es:** A calculadora � capaz de gravar e mostrar um hist�rico de opera��es.

## Como utilizar

1. Clone o reposit�rio ou baixe o c�digo fonte da Calculadora.
2. Abra o terminal ou o prompt de comando e navegue at� a pasta raiz da Calculadora.
3. Utilize o comando abaixo para restaurar as depend�ncias do projeto.

```
dotnet restore
```
4. Em seguida, compile a solu��o utilizando o comando:
```
dotnet build --configuration Release
```

5. Para executar o projeto compilando em tempo real
```
dotnet run --project Calculadora.ConsoleApp
```

6. Para executar o arquivo compilado, navegue at� a pasta `./Calculadora.ConsoleApp/bin/Release/net8.0/` e execute o arquivo:
```
Calculdora.ConsoleApp.exe
```

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compila��o e execu��o do projeto.