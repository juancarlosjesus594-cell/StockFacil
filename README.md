# StockFácil - Sistema de control de inventario

## Propósito
Apoyar el control de los productos disponibles en el almacén de TecnoMarket.

## Módulos principales
- Productos
- Stock
- Consultas

## Estructura del proyecto
- Controllers/: Coordina solicitudes de productos.
- Models/: Representa las entidades del sistema.
- Services/: Contiene reglas y lógica del negocio.
- Data/: Gestiona el acceso a los datos.
- Views/: Interacción con el usuario.

## Requisito trabajado

RF-02: Validar producto.

El sistema verifica que:

- El nombre del producto no esté vacío.
- El precio sea mayor que cero.