# semana02cs
# Proyecto Figuras Geométricas (Círculo y Rectángulo)

Este es un proyecto simple desarrollado en **C#** que demuestra los conceptos básicos de la **Programación Orientada a Objetos (POO)**, específicamente la creación de clases, propiedades y métodos.

El programa principal (`Program.cs`) crea instancias de las clases `Circulo` y `Rectangulo`, les asigna valores y calcula sus propiedades geométricas.

---

## Tecnologías Utilizadas

* **Lenguaje:** C\#
* **Plataforma:** .NET (Console Application)

---

## Estructura del Proyecto

El proyecto se compone de tres archivos principales (o tres clases dentro del mismo archivo, si es un proyecto muy pequeño):

### 1. Clase `Circulo`

Esta clase representa un círculo y maneja todas sus operaciones.

| Propiedad | Tipo | Descripción |
| :--- | :--- | :--- |
| `Radio` | `double` | Define el tamaño del círculo. |

| Método | Retorno | Descripción |
| :--- | :--- | :--- |
| `CalcularArea()` | `double` | Calcula el área del círculo: $\pi \cdot r^2$. |
| `CalcularCircunferencia()` | `double` | Calcula el perímetro del círculo: $2 \cdot \pi \cdot r$. |

### 2. Clase `Rectangulo`

Esta clase representa un rectángulo y maneja sus dimensiones y cálculos.

| Propiedad | Tipo | Descripción |
| :--- | :--- | :--- |
| `Ancho` | `double` | Define la longitud del lado horizontal. |
| `Alto` | `double` | Define la longitud del lado vertical. |

| Método | Retorno | Descripción |
| :--- | :--- | :--- |
| `CalcularArea()` | `double` | Calcula el área del rectángulo: `Ancho` * `Alto`. |
| `CalcularPerimetro()` | `double` | Calcula el perímetro: $2 \cdot (\text{Ancho} + \text{Alto})$. |
