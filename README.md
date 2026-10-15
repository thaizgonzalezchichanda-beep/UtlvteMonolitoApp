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


<img width="659" height="489" alt="image" src="https://github.com/user-attachments/assets/b2090d8d-8301-40aa-8059-4f483c3868cc" />



\---



\## 🖥️ Evidencias de Funcionamiento



\### Listado y Gestión de Estudiantes

<img width="1217" height="468" alt="image" src="https://github.com/user-attachments/assets/1b7239a9-ba1c-404d-8826-9a5465d53559" />

\###  Formulario para Registrar Nuevo Estudiante
<img width="1356" height="674" alt="image" src="https://github.com/user-attachments/assets/06507d88-aa4b-4554-81c2-a52296a7e832" />

## 📚 Actividad Complementaria (Extensión del Taller)
- **Modelo Asignatura:** Implementado con las propiedades `Id`, `Codigo`, `Nombre`, `Creditos` y `Nivel`.
- **Relación Muchos a Muchos:** Configurada entre `Estudiante` y `Asignatura` mediante la entidad intermedia `Matricula`.
- **Migración aplicada:** `AgregarMatriculas` ejecutada y reflejada en SQL Server mediante `dotnet ef database update`.

<img width="728" height="257" alt="image" src="https://github.com/user-attachments/assets/57157d31-1ee2-458d-affd-eef8db42380a" />
<img width="721" height="290" alt="image" src="https://github.com/user-attachments/assets/14c56a82-03ef-4edc-b0d8-0afe2132b3e0" />

### 📊 Evidencia de la Migración y Extensión
<img width="719" height="358" alt="image" src="https://github.com/user-attachments/assets/860a83ae-6f03-4c64-a191-334f10b4ba32" />



