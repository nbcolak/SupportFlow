![C#](https://img.shields.io/badge/language-C%23-blue)  
![.NET Core](https://img.shields.io/badge/.NET%20Core-8-blue)  
![RabbitMQ](https://img.shields.io/badge/RabbitMQ-Messaging-orange)  
![MassTransit](https://img.shields.io/badge/MassTransit-Message%20Broker-green)  
![Chain of Responsibility](https://img.shields.io/badge/Design%20Pattern-Chain%20of%20Responsibility-yellow)


English

This project uses the Chain of Responsibility pattern, MassTransit, RabbitMQ, and .NET Core 8 to implement a support request management system. The system processes support requests through a series of handlers, each responsible for a different type of support (technical, billing, general). RabbitMQ is used as a message broker, and MassTransit facilitates communication between handlers.

Technologies Used

	•	.NET Core 8: Backend framework for building the API.
	•	Chain of Responsibility Pattern: Used to pass support requests through multiple handlers in a predefined sequence.
	•	RabbitMQ: Message broker to handle the communication of support requests between services.
	•	MassTransit: Middleware for sending and receiving messages between services.
	•	RESTful API: For external interaction with the system.

Features

	•	Handles support requests based on categories (Technical, Billing, General).
	•	Automatically processes the request through multiple handlers.
	•	Easily extensible with additional support types.
	•	Uses RabbitMQ for asynchronous message handling between different components.
	•	Provides a RESTful API for external interactions.

Türkçe

Bu proje, Chain of Responsibility tasarım deseni, MassTransit, RabbitMQ ve .NET Core 8 kullanarak destek talebi yönetim sistemi sağlar. Sistem, farklı destek türlerine (teknik, fatura, genel) sahip talepleri işleyici zincirinden geçirir. RabbitMQ mesaj iletimi için kullanılırken, MassTransit ise handler’lar arasındaki iletişimi yönetir.

Kullanılan Teknolojiler

	•	.NET Core 8: API geliştirmek için kullanılan backend framework.
	•	Chain of Responsibility Deseni: Destek taleplerini belirli bir sırayla birden fazla işleyiciye geçirir.
	•	RabbitMQ: Mesaj iletimi için kullanılan mesaj kuyruğu sistemi.
	•	MassTransit: Servisler arasında mesajların gönderilmesini ve alınmasını kolaylaştıran middleware.
	•	RESTful API: Sistemle harici etkileşim sağlamak için kullanılır.

Özellikler

	•	Teknik, fatura ve genel gibi kategorilere göre destek taleplerini işler.
	•	Talepleri otomatik olarak birden fazla işleyiciden geçirir.
	•	Ek işleyicilerle kolayca genişletilebilir.
	•	RabbitMQ kullanarak servisler arasında asenkron mesajlaşmayı sağlar.
	•	RESTful API ile harici sistemlerle etkileşim sunar.

Deutsch

Dieses Projekt verwendet das Chain of Responsibility Muster, MassTransit, RabbitMQ und .NET Core 8, um ein Support-Anfrage-Managementsystem zu implementieren. Das System verarbeitet Support-Anfragen durch eine Reihe von Handlern, die jeweils für eine andere Art von Support verantwortlich sind (technisch, Abrechnung, allgemein). RabbitMQ wird als Nachrichtenbroker verwendet, und MassTransit erleichtert die Kommunikation zwischen den Handlern.

Verwendete Technologien

	•	.NET Core 8: Backend-Framework zur Erstellung der API.
	•	Chain of Responsibility Muster: Wird verwendet, um Support-Anfragen durch mehrere Handler in einer vordefinierten Reihenfolge zu leiten.
	•	RabbitMQ: Nachrichtenbroker zur Verwaltung der Kommunikation von Support-Anfragen zwischen den Diensten.
	•	MassTransit: Middleware zum Senden und Empfangen von Nachrichten zwischen Diensten.
	•	RESTful API: Zur externen Interaktion mit dem System.

Funktionen

	•	Verarbeitet Support-Anfragen basierend auf Kategorien (Technisch, Abrechnung, Allgemein).
	•	Bearbeitet die Anfrage automatisch durch mehrere Handler.
	•	Leicht erweiterbar mit zusätzlichen Support-Typen.
	•	Verwendet RabbitMQ für asynchrone Nachrichtenübermittlung zwischen verschiedenen Komponenten.
	•	Bietet eine RESTful API für externe Interaktionen.

Español

Este proyecto utiliza el patrón de Chain of Responsibility, MassTransit, RabbitMQ y .NET Core 8 para implementar un sistema de gestión de solicitudes de soporte. El sistema procesa solicitudes de soporte a través de una serie de manejadores, cada uno responsable de un tipo diferente de soporte (técnico, facturación, general). RabbitMQ se utiliza como un intermediario de mensajes y MassTransit facilita la comunicación entre los manejadores.

Tecnologías Usadas

	•	.NET Core 8: Framework de backend para construir la API.
	•	Chain of Responsibility Pattern: Se utiliza para pasar las solicitudes de soporte a través de varios manejadores en una secuencia predefinida.
	•	RabbitMQ: Intermediario de mensajes para manejar la comunicación de solicitudes de soporte entre servicios.
	•	MassTransit: Middleware para enviar y recibir mensajes entre servicios.
	•	RESTful API: Para la interacción externa con el sistema.

Funcionalidades

	•	Procesa solicitudes de soporte basadas en categorías (Técnico, Facturación, General).
	•	Procesa automáticamente la solicitud a través de varios manejadores.
	•	Fácilmente extensible con tipos adicionales de soporte.
	•	Utiliza RabbitMQ para el manejo asincrónico de mensajes entre diferentes componentes.
	•	Proporciona una API RESTful para interacciones externas.
