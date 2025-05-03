# Calculadora de Investimentos CDB

Este projeto � uma aplica��o web desenvolvida com **ASP.NET Core (back-end)** e **Angular (front-end)**, que simula o rendimento de um investimento em CDB.

##  Objetivo

A aplica��o permite que o usu�rio informe:

� Um valor inicial de investimento  
� Um prazo em meses  

Com base nessas informa��es, o sistema calcula:

� O valor bruto estimado ao fim do per�odo  
� O valor l�quido, j� descontando o imposto de renda conforme a tabela regressiva  

##  Tecnologias Utilizadas

� .NET 8 (ASP.NET Core Web API)  
� Angular 17  
� TypeScript  
� HTML/CSS  

##  Pr�-requisitos

Antes de rodar o projeto, verifique se possui instalado:

� .NET SDK 8.0+ � https://dotnet.microsoft.com/download  
� Node.js 18+ e NPM � https://nodejs.org/  
� Visual Studio 2022 com o workload "ASP.NET e desenvolvimento web"  

   git clone https://github.com/seu-usuario/seu-repo.git
   cd CdbCalculatorApp


##  Como executar o projeto

1) Abra a solu��o no Visual Studio:

   Arquivo: `CdbCalculatorApp.sln`

2) Restaure os pacotes e fa�a o build:

   O Visual Studio realiza isso automaticamente ao abrir o projeto.

3) Execute o projeto:

   Pressione F5 para iniciar tanto o front-end Angular quanto a API em conjunto.  
   O navegador abrir� automaticamente em `https://localhost:<porta>`.

##  Testes

O projeto inclui testes unit�rios que cobrem mais de 90% da l�gica de c�lculo.  
Para execut�-los, use:

dotnet test
