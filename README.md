# User Management App

## Descripción
Aplicación web de gestión de usuarios desarrollada con **Blazor WebAssembly** (frontend) y **ASP.NET Core Web API** (backend).  
Permite autenticación mediante **JWT** y operaciones CRUD sobre usuarios: crear, leer, actualizar y eliminar.  

El frontend y backend están desacoplados, comunicándose vía **RESTful API**, siguiendo un patrón cliente-servidor moderno.

---

## Tecnologías y Librerías

### Frontend
- **Blazor WebAssembly (.NET 7/8)**: SPA interactiva usando C#.  
- **Blazored.LocalStorage**: almacenamiento del token JWT en el navegador.  
- **HttpClient**: para llamadas HTTP a la API.  
- **Componentes Blazor (`EditForm`, `InputText`)**: formularios y validaciones.  

### Backend
- **ASP.NET Core Web API (.NET 7/8)**: exposición de endpoints RESTful.  
- **JWT Authentication**: protección de endpoints mediante tokens.  
- **Middleware personalizado**: logging, manejo de errores y validación de tokens.  
- **CORS**: habilitado para permitir comunicación con el frontend en diferente origen.  

### Base de Datos (opcional)
- Puede usarse **SQL Server, PostgreSQL o SQLite** con **Entity Framework Core**.

---

## Arquitectura
- **SPA (Single Page Application)**: navegación sin recargar página.  
- **Cliente-servidor desacoplado**: frontend y backend independientes.  
- **Service Layer**: `UserService` centraliza llamadas HTTP y autorización.  
- **Componentes reutilizables**: modales de creación/edición de usuarios.  

---

## Flujo de uso
1. Usuario accede a `/login`.  
2. Introduce credenciales; API devuelve **JWT** si son correctas.  
3. Token se guarda en `localStorage` y se agrega a todas las solicitudes HTTP.  
4. Usuario accede a `/users` y puede:
   - Crear usuarios
   - Editar usuarios
   - Eliminar usuarios  
5. Si no está autenticado, se muestra un mensaje indicando que debe iniciar sesión.  

---

## Buenas prácticas y metodologías
- **Separation of Concerns (SoC)**: UI y lógica de negocio separadas.  
- **Single Responsibility Principle (SRP)**: cada componente y servicio tiene responsabilidad única.  
- **Patrón RESTful**: endpoints claros y consistentes (`GET`, `POST`, `PUT`, `DELETE`).  
- **Seguridad**: autenticación JWT y middleware de autorización.  
- **UX amigable**: mensajes de alerta, modales y estados de carga.  

---

## Conclusión
Proyecto completo que demuestra habilidades en **.NET Full Stack**, integración de **Blazor con APIs REST**, manejo de **autenticación y autorización**, y buenas prácticas de **arquitectura y diseño de software**.
