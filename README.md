# Calculadora modular en C#

Aplicación de consola que permite realizar operaciones aritméticas básicas. El proyecto sirve como práctica de métodos, selección de opciones con `switch`, repetición con `do...while` y validación de entradas.

## Funcionalidades

- Sumar dos números enteros.
- Restar dos números enteros.
- Multiplicar dos números enteros.
- Dividir dos números decimales.
- Repetir el menú para permitir realizar varias operaciones.
- Rechazar opciones que no sean números enteros válidos o que estén fuera del rango aceptado.
- Evitar la división entre cero.

## Requisitos

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- Una terminal o un editor compatible con proyectos .NET, como Visual Studio Code o Visual Studio.

## Ejecutar el proyecto

Desde la carpeta que contiene `metodos.csproj`, ejecuta:

```bash
dotnet run
```

También puedes compilar el proyecto antes de ejecutarlo:

```bash
dotnet build
dotnet run
```

## Uso

Al iniciar, el programa muestra un menú con estas operaciones:

| Opción | Operación |
|---|---|
| 1 | Sumar |
| 2 | Restar |
| 3 | Multiplicar |
| 4 | Dividir |

Escribe el número de la operación y presiona **Enter**. Después, introduce los dos valores solicitados. El resultado se muestra en la consola y, al terminar, aparece nuevamente el menú.

Para cerrar el programa, escribe `5` en la selección del menú. Aunque esa opción no aparece actualmente en el menú, el programa la reconoce como señal de salida.

Si introduces una letra o una opción no válida, el programa muestra un mensaje y vuelve a presentar el menú.

## Notas sobre las operaciones

- La suma, resta y multiplicación reciben números enteros.
- La división recibe números decimales y comprueba que el divisor no sea cero.
- La validación de la selección del menú acepta los valores del `1` al `5`; el `5` cierra el ciclo del programa.

## Estructura del proyecto

```text
metodos/
├── Program.cs      # Menú, validación y métodos de las operaciones
├── metodos.csproj  # Configuración del proyecto .NET
└── README.md       # Documentación
```
