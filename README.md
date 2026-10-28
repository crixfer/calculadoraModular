# Calculadora modular en C#

Aplicación de consola para practicar métodos, validación de entradas, estructuras de selección (`switch`) y ciclos (`do...while`) en C#.

## Funcionalidades

- Sumar, restar y multiplicar dos números enteros.
- Dividir dos números decimales.
- Mostrar el resultado de la división con exactamente dos cifras decimales.
- Validar que la opción del menú sea un número entre 1 y 5.
- Volver a mostrar el menú después de cada operación.
- Rechazar entradas no numéricas para los operandos.
- Evitar la división entre cero.

## Requisitos

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- Una terminal o un editor compatible con proyectos .NET, como Visual Studio Code o Visual Studio.

## Ejecutar

Desde la carpeta del proyecto, donde se encuentra `metodos.csproj`, ejecuta:

```bash
dotnet run
```

Opcionalmente, puedes compilar el proyecto por separado:

```bash
dotnet build
```

## Uso

Al iniciar, la aplicación muestra este menú:

| Opción | Operación |
|---|---|
| 1 | Sumar |
| 2 | Restar |
| 3 | Multiplicar |
| 4 | Dividir |
| 5 | Salir |

Escribe el número de la opción y presiona **Enter**. Para las opciones del 1 al 4, introduce los dos valores solicitados. Después de mostrar el resultado, presiona **Enter** para volver al menú. Selecciona `5` para cerrar el programa.

Si introduces una letra o un número fuera del rango del menú, se muestra un mensaje y el menú vuelve a aparecer. Si un operando no es numérico, el programa lo solicita nuevamente.

## Tipos de entrada y resultados

- Suma, resta y multiplicación usan números enteros (`int`).
- División usa números decimales (`decimal`); el divisor no puede ser cero.
- El resultado de la división se presenta con dos cifras decimales. Por ejemplo, `2.5` se muestra como `2.50`.
- La división acepta valores negativos y cero como primer operando; solo el segundo operando debe ser distinto de cero.

## Estructura del proyecto

```text
metodos/
├── Program.cs      # Menú, validaciones y operaciones
├── metodos.csproj  # Configuración del proyecto .NET
└── README.md       # Documentación
```
