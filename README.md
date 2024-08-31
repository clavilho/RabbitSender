# RabbitSender

## Descrição

O **RabbitSender** é uma aplicação de console em .NET projetada por mim para enviar mensagen para uma fila do RabbitMQ. É uma ferramenta simples e eficiente para desenvolvedores testarem e integrarem o RabbitMQ em seus sistemas.

## Pré-requisitos

Antes de começar, você precisará ter instalado:

- [.NET SDK](https://dotnet.microsoft.com/download) (versão mínima recomendada: 6.0)
- [Docker](https://www.docker.com/products/docker-desktop) (opcional, para executar o RabbitMQ em um contêiner)
- Um servidor RabbitMQ em execução

## Configuração do RabbitMQ

Se você ainda não tiver um servidor RabbitMQ em execução, você pode facilmente configurá-lo usando Docker:

```bash
docker run -d --name rabbitmq -p 5672:5672 -p 15672:15672 rabbitmq:3-management
