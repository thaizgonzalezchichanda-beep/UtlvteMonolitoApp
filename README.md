\# Taller 1: Monolito Web en Capas (MVC) con .NET 8 y EF Core



\## 📌 Descripción del Proyecto

Aplicación web monolítica desarrollada en \*\*.NET 8\*\* utilizando el patrón arquitectónico \*\*MVC (Model-View-Controller)\*\* y persistencia de datos mediante \*\*Entity Framework Core (Code-First)\*\* conectada a SQL Server. 



El sistema gestiona entidades académicas e implementa una \*\*relación de Muchos a Muchos\*\* entre `Estudiante` y `Asignatura` a través de la entidad intermedia `Matricula`.



\---



\## 🛠️ Tecnologías y Entorno

\* \*\*Framework:\*\* .NET 8 (ASP.NET Core MVC)\[cite: 3, 4]

\* \*\*Base de Datos:\*\* Microsoft SQL Server (SQL Express / Local)\[cite: 3, 7]

\* \*\*ORM:\*\* Entity Framework Core 8\[cite: 6]

\* \*\*Control de Versiones:\*\* Git y GitHub



\---



\## 📂 Estructura del Proyecto

El proyecto está organizado en las siguientes capas y carpetas principales:

\* `Controllers/`: Controladores de la aplicación (`EstudiantesController.cs`, etc.)\[cite: 7].

\* `Data/`: Contexto de base de datos (`ApplicationDbContext.cs`)\[cite: 6].

\* `Models/`: Clases de dominio y reglas de validación (`Estudiante.cs`, `Asignatura.cs`, `Matricula.cs`)\[cite: 5, 10].

\* `Views/`: Vistas Razor para la interfaz de usuario (`Index.cshtml`, `Crear.cshtml`)\[cite: 8, 9].

\* `appsettings.json`: Configuración de la cadena de conexión a SQL Server\[cite: 6].





\---



\## 🖥️ Evidencias de Funcionamiento



\### Listado y Gestión de Estudiantes

<img width="1217" height="468" alt="image" src="https://github.com/user-attachments/assets/1b7239a9-ba1c-404d-8826-9a5465d53559" />

\###  Formulario para Registrar Nuevo Estudiante
<img width="1356" height="674" alt="image" src="https://github.com/user-attachments/assets/06507d88-aa4b-4554-81c2-a52296a7e832" />





