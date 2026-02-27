<div align="center">
  <h1 align="center">🧮 Calculator App CLI</h1>
  <p align="center">
    <strong>Uma calculadora simples e eficiente direto no terminal, construída em C#.</strong>
  </p>
  <p align="center">
    <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" alt="C#" />
    <img src="https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET" />
    <img src="https://img.shields.io/badge/CLI-Terminal-black?style=for-the-badge&logo=windows-terminal&logoColor=white" alt="CLI" />
  </p>
</div>

<hr />

## 📖 Sobre o Projeto

O **Calculator App CLI** é uma aplicação de console interativa e intuitiva. Ela provê ao usuário as 4 grandes operações matemáticas (Soma, Subtração, Multiplicação e Divisão) utilizando o *prompt* de linha de comando.

Este projeto foca em controle de interface utilizando o Console do Sistema Operacional, formatação de saída de dados e conversões seguras de tipos em C# (como manipulação de *doubles*), oferecendo de forma rápida respostas matemáticas diretas antes de retornar dinamicamente ao menu principal da aplicação.

---

## 🚀 Funcionalidades

- **Menu Fixo e Estético**: Um sistema de menu baseado em console desenhado com ASCII Art com seleções padronizadas.
- **Tipagem Dinâmica em Cálculo**: Suporte a números flutuantes e fracionários via ponto flutuante de precisão dupla (`double`). As operações englobam qualquer combinação matemática primária.
- **Ciclo de Aplicação Contínuo**: A arquitetura do programa faz com que o menu retorne recursivamente à tela após a exibição do resultado através de limpezas de tela (`Console.Clear()`) contíguas, proporcionando imersão ininterrupta sem finalizar o executável agressivamente.

---

## 🛠️ Stack Tecnológica

| Tecnologia | Descrição |
| :--- | :--- |
| **[C# (C-Sharp)](https://docs.microsoft.com/en-us/dotnet/csharp/)** | Linguagem orientada a objetos forte, usada como estrutura mestre. |
| **[.NET](https://dotnet.microsoft.com/)** | Core base utilizado para rodar a aplicação em multi-ambientes. |
| **System** | Uso ostensivo de bibliotecas base para I/O (`Console.ReadLine`, `Console.WriteLine` e `Environment.Exit`). |

---

## 🏗️ Como Executar o Projeto Localmente

### Pré-requisitos
- [.NET SDK](https://dotnet.microsoft.com/download) instalado.

### Modo de Uso (Terminal)

```bash
# 1. Acesse o local do projeto
cd CalculatorApp_CLI

# 2. Rode o app via .NET Core CLI
dotnet run
```
*Após iniciar, insira o número da operação desejada no prompt.*

---

## 👨‍💻 Avaliados por Tech Recruiters: O que observar?

Embora seja um projeto introdutório que resolve um problema matematicamente simples, este repositório possui elementos formativos em programação .NET madura:

1. **Separação Simples de Responsabilidades**: Em vez de concentrar as decisões num grande método `Main`, cada uma das 4 operações matemáticas (`Sum`, `Sub`, `Div`, `Mult`) são separadas em blocos **`static void`**, facilitando testes ou substituição da injeção no futuro caso a aplicação escale para chamadas externas/APIs.
2. **Type Safety e Parse de Strings**: Operadores que vêm do teclado nativamente são cadeias de caracteres. O emprego bem sussedido do `double.Parse()` reflete tratamento rígido de tipos nativos previnindo falhas numéricas. *(Recomenda-se no futuro `TryParse` em ambientes produtivos de alto risco).*
3. **Escopo de Interface Desacoplado**: O uso de `switch...case` somado a chamadas condicionais propicia uma máquina de estados enxuta pro Menu (o usuário visualiza estado de "Menu" ou estado de "Operação").

---
> Desenvolvido com foco nos fundamentos rígidos do .NET.
