//Funciones - Metodos
// CALCULADORA MODULAR

// variables
int opcion = 0;

// menu

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

    Console.Write("Opción: ");

    // validacion de entrada para seleccion de opciones
    if (!int.TryParse(Console.ReadLine(), out opcion) || opcion <= 0 || opcion > 5)
    {
        Console.WriteLine("Debe introducir un numero del 1 al 4 como las opciones del menú.");
    }
    else
    {
        
        switch (opcion)
        {
            case 1:
                Console.WriteLine(sumar());
                break;

            case 2:
                Console.WriteLine(restar());
                break;

            case 3:
                Console.WriteLine(mult());
                break;

            case 4:
                Console.WriteLine(div());
                break;
        }
    }

    // METODOS

    static int sumar() // SUMA
    {
        Console.WriteLine("\t* SUMAR *");

        Console.Write("\nInserte el primer numero: ");
        int num1 = int.Parse(Console.ReadLine()!);

        Console.Write("Agrege el segundo numero: ");
        int num2 = int.Parse(Console.ReadLine()!);

        Console.Write("\nLa adición de esta operación es: ");
        return num1 + num2;

    }

    static int restar() // RESTA
    {

        Console.WriteLine("\t** RESTAR **");

        Console.Write("\nInserte el primer numero: ");
        int num1 = int.Parse(Console.ReadLine()!);

        Console.Write("Inserte el segundo numero: ");
        int num2 = int.Parse(Console.ReadLine()!);

        Console.Write("\nLa diferencia de esta operación es: ");
        return num1 - num2;
    };


    static int mult() // PRODUCTO
    {
        Console.WriteLine("\t*** MULTIPLICAR *** ");

        Console.Write("\nInserte el primer numero: ");
        int num1 = int.Parse(Console.ReadLine()!);

        Console.Write("Inserte el segundo numero: ");
        int num2 = int.Parse(Console.ReadLine()!);

        Console.Write("\nEl producto de esta operación es: ");
        return num1 * num2;
    }

    static decimal div()
    {
        Console.WriteLine("\t**** DIVIDIR *****");

        Console.Write("Inserte el primer numero mayor a 0: ");
        decimal num1 = decimal.Parse(Console.ReadLine()!);

        Console.Write("Inserte el segundo numero mayor a 0: ");
        decimal num2 = decimal.Parse(Console.ReadLine()!);

        if (num2 == 0)
        {
            Console.WriteLine("Mensaje!: No se puede dividir entre 0. Debe insertar otro número.");
            return 0;
        }

        Console.Write("\nEl cociente de esta operación es: ");
        return num1 / num2;

    }
} while (opcion != 5);

Console.WriteLine("***** FIN DEL SISTEMA *****");


