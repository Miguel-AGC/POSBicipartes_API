# POS Bicipartes API

API REST desarrollada con **ASP.NET Core** para un sistema de Punto de Venta (POS) orientado a la administración de una refaccionaria de bicicletas.

El proyecto está diseñado bajo una arquitectura modular y escalable, siguiendo buenas prácticas de desarrollo para facilitar el mantenimiento y la incorporación de nuevas funcionalidades.

---

## Características

- Autenticación mediante JWT
- Administración de usuarios y roles
- Gestión de productos
- Gestión de categorías
- Gestión de marcas
- Gestión de proveedores
- Gestión de clientes
- Compras
- Ventas
- Presupuestos
- Control de inventario
- Movimientos de inventario
- Configuración del sistema
- Historial de precios
- Documentación con Swagger

---

## Tecnologías

- ASP.NET Core
- C#
- Entity Framework Core
- MySQL 8
- JWT Authentication
- AutoMapper
- FluentValidation
- Serilog
- Swagger / OpenAPI

---

## Arquitectura

```
POSBicipartes
│
├── src
│   ├── POSBicipartes.Api
│   ├── POSBicipartes.Application
│   ├── POSBicipartes.Domain
│   ├── POSBicipartes.Infrastructure
│   └── POSBicipartes.Shared
│
├── tests
│
└── docs
```

La solución sigue una arquitectura por capas para mantener separadas las responsabilidades de la aplicación.

---

## Módulos

- Seguridad
- Usuarios
- Roles
- Empleados
- Clientes
- Proveedores
- Categorías
- Marcas
- Productos
- Compras
- Inventarios
- Ventas
- Presupuestos
- Configuración del Sistema
- Reportes

---

## Base de datos

La base de datos está desarrollada en **MySQL 8** e incluye:

- Integridad referencial
- Triggers
- Control automático de inventario
- Historial de precios
- Cálculo automático de importes y totales

---

## Seguridad

- JWT Authentication
- Password Hash
- Roles y permisos
- Validaciones de negocio

---

## Estado del proyecto
 En desarrollo.

Actualmente se está construyendo la estructura base del proyecto y la arquitectura de la solución.

---

## Licencia

Este proyecto se distribuye bajo la licencia MIT.
