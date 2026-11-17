# 🟣 Servicio de Perfil con ASP.NET Core

Este repositorio (`portafolio-backend-asp`) es un microservicio desarrollado con **ASP.NET Core** y **C#**. Su función es proveer la información básica del perfil que se muestra en el frontend de Angular.

Es una API ligera, sin conexión a base de datos, que devuelve datos estáticos en formato JSON.

## 🏛️ Rol en la arquitectura

Este microservicio se ejecuta en el puerto `5000` y es consumido por el cliente [portafolio-frontend](https://github.com/jvasquezdev/portafolio-frontend).

Su objetivo es demostrar cómo un frontend puede consumir información desde múltiples servicios backend. En este caso, el servicio responde a peticiones HTTP GET y devuelve los datos del perfil en formato JSON.

## 🚀 Requisitos previos

Para ejecutar este proyecto localmente necesitas:

- **.NET SDK 7.0 o superior**
- Un editor de código como Visual Studio, VS Code o Rider

## ⚙️ Instalación y configuración

1. Clona el repositorio:

```bash
git clone https://github.com/jvasquezdev/portafolio-backend-asp.git
cd portafolio-backend-asp
```

2. Restaura las dependencias del proyecto:

```bash
dotnet restore
```

## 🏃‍♂️ Ejecución del servidor

El servicio está configurado para ejecutarse en el puerto `5000` mediante el archivo `launchSettings.json`.

Para iniciar el servidor, ejecuta:

```bash
dotnet run
```

La API estará disponible en:

```text
http://localhost:5000/api/profile
```

## 🛠️ Tecnologías utilizadas

- **Framework:** ASP.NET Core Web API
- **Lenguaje:** C#
- **Servidor web:** Kestrel
- **Formato de respuesta:** JSON
- **Patrón:** Controlador API con respuestas HTTP mediante `IActionResult`

## 💡 Sobre la implementación

El controlador `ProfileController` expone un endpoint de solo lectura que devuelve la información del perfil en formato JSON. La serialización de los datos se realiza automáticamente por ASP.NET Core.