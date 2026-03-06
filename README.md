# UsuariosAPI con Autenticación JWT

## Descripción

Este proyecto es una API REST desarrollada con **ASP.NET Core Web API** que permite gestionar usuarios utilizando operaciones CRUD.
Además, se implementa autenticación mediante **JSON Web Tokens (JWT)** para proteger los endpoints.

---

## Tecnologías utilizadas

* ASP.NET Core Web API
* Entity Framework Core
* SQL Server
* JWT Authentication
* Swagger
* SHA-256 para encriptación de contraseñas

---

## Instalación y ejecución

### 1 Clonar el repositorio

```bash
[git clone https://github.com/TU_USUARIO/UsuariosAPI-JWT.git](https://github.com/ArielPP16/UsuariosAPI-JWT.git)
```

### 2 Abrir el proyecto

Abrir el archivo `.sln` en **Visual Studio**.

### 3 Ejecutar migraciones

Abrir **Package Manager Console** y ejecutar:

```bash
Add-Migration InitialCreate
Update-Database
```

### 4 Ejecutar la API

Presionar:

```
F5
```

Se abrirá **Swagger** en:

```
https://localhost:7065/swagger
```

---

# Autenticación JWT

## Login

Endpoint:

```
POST /api/auth/login
```

Ejemplo:

```json
{
  "correo": "ariel@gmail.com",
  "password": "123456"
}
```

Respuesta:

```json
{
 "token": "JWT_TOKEN"
}
```

---

# Refrescar Token

Endpoint:

```
POST /api/auth/refresh
```

---

# CRUD Usuarios

## Crear usuario

```
POST /api/usuarios
```

```json
{
 "nombre": "Ariel Perez",
 "fechaNacimiento": "2000-05-10",
 "correo": "ariel@gmail.com",
 "password": "123456"
}
```

---

## Obtener usuarios

```
GET /api/usuarios
```

---

## Obtener usuario por ID

```
GET /api/usuarios/{id}
```

---

## Actualizar usuario

```
PUT /api/usuarios/{id}
```

---

## Eliminar usuario

```
DELETE /api/usuarios/{id}
```

---

# Pruebas

Las pruebas se realizaron utilizando **Swagger**.

Pasos:

1. Crear usuario
2. Login
3. Copiar token
4. Presionar **Authorize**
5. Usar token para acceder a endpoints protegidos

---

# Capturas de prueba

Agregar capturas de:

* Crear usuario
* Login
* Obtener usuarios
* Actualizar usuario
* Eliminar usuario

---

# Autor

VICTOR ARIEL PEREZ PEREZ
