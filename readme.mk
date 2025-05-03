# Calculadora de Investimentos CDB

Este projeto é uma aplicação web desenvolvida com **ASP.NET Core (back-end)** e **Angular (front-end)**, que simula o rendimento de um investimento em CDB.

##  Objetivo

A aplicação permite que o usuário informe:

• Um valor inicial de investimento  
• Um prazo em meses  

Com base nessas informações, o sistema calcula:

• O valor bruto estimado ao fim do período  
• O valor líquido, já descontando o imposto de renda conforme a tabela regressiva  

##  Tecnologias Utilizadas

• .NET 8 (ASP.NET Core Web API)  
• Angular 17  
• TypeScript  
• HTML/CSS  

##  Pré-requisitos

Antes de rodar o projeto, verifique se possui instalado:

• .NET SDK 8.0+ — https://dotnet.microsoft.com/download  
• Node.js 18+ e NPM — https://nodejs.org/  
• Visual Studio 2022 com o workload "ASP.NET e desenvolvimento web"  

   git clone https://github.com/seu-usuario/seu-repo.git
   cd CdbCalculatorApp


##  Como executar o projeto

1) Abra a solução no Visual Studio:

   Arquivo: `CdbCalculatorApp.sln`

2) Restaure os pacotes e faça o build:

   O Visual Studio realiza isso automaticamente ao abrir o projeto.

3) Execute o projeto:

   Pressione F5 para iniciar tanto o front-end Angular quanto a API em conjunto.  
   O navegador abrirá automaticamente em `https://localhost:<porta>`.

##  Testes

O projeto inclui testes unitários que cobrem mais de 90% da lógica de cálculo.  
Para executá-los, use:

dotnet test
