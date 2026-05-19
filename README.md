# Simulador de Lutas em C#

Projeto console desenvolvido em C# para praticar fundamentos de Programação Orientada a Objetos por meio da simulação de confrontos entre lutadores.

O sistema modela entidades como `Lutador` e `Luta`, aplica regras para validação de combates e atualiza o histórico dos participantes de acordo com o resultado.

## Objetivo do projeto

Este projeto foi desenvolvido como exercício de consolidação de conceitos fundamentais de POO, incluindo:

- Classes e objetos
- Encapsulamento
- Métodos
- Composição entre entidades
- Regras de negócio simples
- Atualização de estado dos objetos

## Funcionalidades

- Cadastro e representação de lutadores
- Validação de confrontos por categoria
- Marcação de lutas
- Simulação de resultado
- Atualização de vitórias, derrotas e empates

## Tecnologias utilizadas

- C#
- .NET

## Estrutura principal

- `lutador.cs`: define os atributos e comportamentos de cada lutador
- `luta.cs`: controla as regras e a simulação do confronto
- `main.cs`: ponto de entrada da aplicação

## Como executar

### Pré-requisitos

- .NET SDK instalado

### Passos

1. Clone o repositório:

```bash
git clone https://github.com/lucassousa-dev/Luta-POO.git
```

2. Acesse a pasta:

```bash
cd Luta-POO
```

3. Execute:

```bash
dotnet run
```

## Observação

Este é um projeto de fundamentos, mantido no portfólio para demonstrar a base inicial em C# e Programação Orientada a Objetos.