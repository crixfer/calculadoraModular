//Funciones - Metodos
// CALCULADORA MODULAR

// variables
int opcion, num1, num2;

// Mensaje de bienvenida
Console.WriteLine("===== Bienvenidos al sistema de cálculo básico =====");


// loop do while para cargar el menu al menos una vez
do
{   
    // menu interactivo para las operaciones aritmeticas
    Console.WriteLine("\n===== MENU =====");
    Console.WriteLine("\nElija la operación que desea realizar: \n");

    Console.WriteLine("1. SUMAR");
    Console.WriteLine("2. RESTAR");
    Console.WriteLine("3. MULTIPLICAR");
    Console.WriteLine("4. DIVIDIR\n");
    Console.WriteLine("5. SALIR\n");

    Console.Write("Opción: ");

    // validacion de entrada para seleccion de opciones
    if (!int.TryParse(Console.ReadLine(), out opcion) || opcion <= 0 || opcion > 5)
    {
        Console.WriteLine("Mensaje!: Debe introducir un número del 1 al 5 como las opciones del menú.");
    }
    else
    {
        
        switch (opcion)
        {
            case 1: // sumar
                Console.WriteLine(sumar());
                // mensaje para continuar
                Console.WriteLine("\nPresione ENTER para continuar.");
                Console.ReadLine();
                break;

            case 2: // restar
                Console.WriteLine(restar());
                // mensaje para continuar
                Console.WriteLine("\nPresione ENTER para continuar.");
                Console.ReadLine();
                break;

            case 3: // multiplicar
                Console.WriteLine(mult());
                // mensaje para continuar
                Console.WriteLine("\nPresione ENTER para continuar.");
                Console.ReadLine();
                break;

            case 4: // dividir
                Console.WriteLine($"{div():F2}"); // solo agrega dos digitos para decimales despues del punto
                // mensaje para continuar
                Console.WriteLine("\nPresione ENTER para continuar.");
                Console.ReadLine();
                break;
        }
    }

    // METODOS

     int sumar() // SUMA
    {
       
        Console.WriteLine("\n\t* SUMAR *");

        Console.Write("\nIngrese el primer número: ");
        while (!int.TryParse(Console.ReadLine(), out num1)) // valida que el dato sea correcto para continuar
        {
            Console.WriteLine("\nMensaje!: Debe ingresar un número.");
            Console.Write("\nIngrese el primer número: ");
        }

        Console.Write("Ingrese el segundo número: ");
        while (!int.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("\nMensaje!: Debe ingresar un número.");
            Console.Write("\nIngrese el segundo número: ");
        }

        Console.Write("\nLa adición de esta operación es: ");
        return num1 + num2; // suma ambos numeros

    }

    int restar() // RESTA
    {

        Console.WriteLine("\n\t** RESTAR **");

        Console.Write("\nIngrese el primer número: ");
        while (!int.TryParse(Console.ReadLine(), out num1)) // valida que el dato sea correcto para continuar
        {
            Console.WriteLine("\nMensaje!: Debe ingresar un número válido.");
            Console.Write("\nIngrese el primer número: ");
        }

        Console.Write("Ingrese el segundo numero: ");
        while (!int.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("\nMensaje!: Debe ingresar un número válido.");
            Console.Write("\nIngrese el segundo número: ");
        }

        Console.Write("\nLa diferencia de esta operación es: ");
        return num1 - num2; //  resta ambos numeros

    };


    int mult() // MULTIPLICACION
    {

        Console.WriteLine("\n\t*** MULTIPLICAR *** ");

        Console.Write("\nIngrese el primer número: ");
        while (!int.TryParse(Console.ReadLine(), out num1)) // valida que el dato sea correcto para continuar
        {
            Console.WriteLine("\nMensaje!: Debo ingresar un número válido.");
            Console.Write("\nIngrese el primer número: ");
        }

        Console.Write("Ingrese el segundo número: ");
        while (!int.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("\nMensaje!: Debe ingresar un número válido.");
            Console.Write("\nIngrese el segundo número: ");

        }

        Console.Write("\nEl producto de esta operación es: ");
        return num1 * num2; // multiplica ambos numeros
    }

    decimal div() // DIVISION
    {
        decimal num1, num2;

        Console.WriteLine("\n\t**** DIVIDIR *****");

        Console.Write("\nIngrese el primer número: ");
        while (!decimal.TryParse(Console.ReadLine(), out num1)) // valida que el dato sea correcto para continuar
        {
            Console.WriteLine("\nMensaje!: Debe ingresar un número válido y mayor a 0.");
            Console.Write("\nIngrese el primer número: ");
        }
        Console.Write("Ingrese el segundo número: ");
        while (!decimal.TryParse(Console.ReadLine(), out num2) || num2 == 0)
        {
            Console.WriteLine("\nMensaje!: Debe ingresar un número válido y mayor a 0.");
            Console.Write("\nIngrese el segundo número: ");
        }

        Console.Write("\nEl cociente de esta operación es: ");
        return num1 / num2; // divide ambos numero

    }
} while (opcion != 5); // valida que el numero sea difierente a 5 para continuar en el programa

// mensaje de salida
Console.WriteLine("\n***** FIN DEL SISTEMA *****");


