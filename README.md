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
<img width="1343" height="671" alt="image" src="https://github.com/user-attachments/assets/2476d03b-c3b5-4716-b03f-70a162ad4e78" />


## 📚 Actividad Complementaria (Extensión del Taller)
- **Modelo Asignatura:** Implementado con las propiedades `Codigo`, `Nombre`, `Creditos` y `Nivel`.
  <img width="1309" height="379" alt="image" src="https://github.com/user-attachments/assets/d0f623be-b0b2-4da0-88ae-4aaf853ac114" />
<img width="848" height="480" alt="image" src="https://github.com/user-attachments/assets/2b50d485-ba84-4bc5-b505-815ad9f4669f" />

- **Relación Muchos a Muchos:** Configurada entre `Estudiante` y `Asignatura` mediante la entidad intermedia `Matricula`.
  <img width="1257" height="429" alt="image" src="https://github.com/user-attachments/assets/c70a8ab0-c729-416c-bcca-020146255c86" />
  <img width="753" height="301" alt="image" src="https://github.com/user-attachments/assets/d54d87ea-3b7b-40c3-9c2e-7169d44f2f1f" />

- **Migración aplicada:** `AgregarMatriculas` ejecutada y reflejada en SQL Server mediante `dotnet ef database update`.

<img width="728" height="257" alt="image" src="https://github.com/user-attachments/assets/57157d31-1ee2-458d-affd-eef8db42380a" />
<img width="795" height="250" alt="image" src="https://github.com/user-attachments/assets/817a9765-2ece-4813-b31a-bf23b5d456f9" />


### 📊 Evidencia de la Migración y Extensión*(Pega aquí tu captura de pantalla de la terminal mostrando la ejecución exitosa de la migración o de las tablas en SQL Server)*

<img width="556" height="404" alt="image" src="https://github.com/user-attachments/assets/f396ce0c-87fe-4f1c-8b57-c27c62372064" />





