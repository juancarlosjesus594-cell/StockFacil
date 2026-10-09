# StockFácil - Sistema de Control de Inventario

## Propósito del Sistema
StockFácil es un sistema diseñado para apoyar a TecnoMarket en el control y gestión eficiente de los productos disponibles en su almacén. Permite registrar, validar, actualizar el stock y consultar la disponibilidad de los artículos.

## Módulos Principales
- **Registro de Productos (RF-01):** Permite ingresar nuevos productos con su código, nombre, precio y cantidad en stock.
- **Validación de Productos (RF-02):** Garantiza que los productos tengan un nombre válido y un precio mayor a cero.
- **Actualización de Stock (RF-03):** Permite modificar la cantidad disponible de cada producto.
- **Consulta de Disponibilidad (RF-04):** Permite verificar la existencia de stock para un producto específico.

## Estructura del Proyecto
El proyecto está organizado siguiendo el principio de separación de responsabilidades:

- `Controllers/`: Coordina las solicitudes e interacciones relacionadas con los productos (`ProductoController.cs`).
- `Models/`: Contiene las entidades y modelos de datos del sistema (`Producto.cs`).
- `Services/`: Contiene las reglas de negocio y validaciones del sistema (`ProductoService.cs`).
- `Data/`: Gestiona el acceso y persistencia de los datos (`ProductoRepository.cs`).
- `Views/`: Representa la interfaz de usuario para la interacción con el sistema (`ProductoView.cs`).

## Requisito trabajado

RF-02: Validar producto.

El sistema verifica que:

- El nombre del producto no esté vacío.
- El precio sea mayor que cero.