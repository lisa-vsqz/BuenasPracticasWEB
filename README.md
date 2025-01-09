# Proyecto: Design Patterns - Vehículos

## Descripción
Este proyecto implementa varios patrones de diseño en un sistema de gestión de vehículos dentro de una aplicación ASP.NET Core. Se han aplicado mejoras para mejorar la escalabilidad, mantenibilidad y modularidad del código.

## Mejoras Implementadas

### 1. Patrón Singleton para Repositorio en Memoria
Se utilizó el patrón **Singleton** en `MemoryCollection` para garantizar que haya una única instancia de la colección de vehículos en memoria, evitando la creación de múltiples instancias y mejorando el uso eficiente de los recursos.

### 2. Inyección de Dependencias
Se aplicó la **Inyección de Dependencias** para desacoplar la lógica de almacenamiento de vehículos (`MyVehiclesRepository` y `DBVehicleRepository`), permitiendo cambiar la implementación sin modificar la lógica del controlador.

### 3. Patrón Builder para Creación de Vehículos
El **Patrón Builder** se utilizó en `CarModelBuilder` para simplificar la construcción de objetos `Vehicle`, permitiendo la configuración flexible de sus atributos y mejorando la mantenibilidad.

### 4. Patrón Factory Method para la Creación de Vehículos
Se implementó el **Factory Method**, creando una jerarquía de fábricas (`FordMustangFactory`, `FordExplorerFactory`, `FordEscapeFactory`) que encapsulan la lógica de creación de cada tipo de vehículo, facilitando la extensibilidad.

---

## Problemas Detectados en el Código Original
El código original presentaba varias deficiencias:

- **Acoplamiento alto:** La creación de instancias de vehículos estaba directamente en el `HomeController`, lo que dificultaba la modificación o extensión sin afectar la lógica existente.
- **Código repetitivo:** La creación de objetos `Car` estaba dispersa y se realizaba manualmente en los métodos `AddMustang` y `AddExplorer`, generando redundancia.
- **Ineficiencia en la gestión de memoria:** `MyVehiclesRepository` creaba una nueva colección en cada instancia en lugar de utilizar un **Singleton**.
- **Falta de abstracción en la creación de vehículos:** Se requería instanciar manualmente cada tipo de vehículo, aumentando el mantenimiento del código.
- **Ausencia de patrones de diseño clave:** No se aplicaban **Factory Method** ni **Builder**, lo que resultaba en menor reutilización de código y menor escalabilidad.
