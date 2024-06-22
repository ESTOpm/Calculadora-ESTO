using System.Diagnostics;
using System.Dynamic;
namespace Calculadora;

class Program
{
    public static void Main()
    {
    //Declaracion de Variables
    double Menu;
    double num1, num2;
    double resultado; 
    int milliseconds = 2000;
    int milliseconds2 = 4000;

      //Ciclo Do While, para mantener el codigo en loop hasta que el usuario decida salir.
      do 
      { 
      //Establecer los valores a 0.  
        num2 = 0;
        num2 = 0;  
        Menu = 10; //Estado de inicio asignado por culpa del Try, que al leer menu dentro del try luego el switch no reconoce que la variable haya sido nombrada en el codigo.
      //Menu de opciones 
      Console.WriteLine("\n // CALCULADORA DE 2 DIGITOS // ");
      Console.WriteLine("\n Menu de Opciones: ");
      Console.WriteLine("\n 1. Suma de tipo ( a + b )");
      Console.WriteLine("\n 2. Resta de tipo ( a - b )");
      Console.WriteLine("\n 3. Multiplicación de tipo ( a * b )");
      Console.WriteLine("\n 4. Division de tipo ( a / b )");
      Console.WriteLine("\n 0. --SALIR--");
      //Seleecion de menu por el usuario
      try
      {
      Menu = Convert.ToDouble(Console.ReadLine());
      } catch (Exception e)
      {
      Console.WriteLine("Valor no deseado. " + e.Message);
      Console.WriteLine("Intenta con un valor entre 1 y 4, y usa el 0 para salir.");
      } 
      // Operador de casos para cada opcion, opera bajo el valor de la varibale Menu, del 0 al 4.
        switch (Menu)
        {
        // Operacion de Suma
            case 1: 
            try
            {
              Console.WriteLine("//Seleccionaste Suma//");
              Console.WriteLine("Escribe el primer digito: ");
              num1 = Convert.ToDouble(Console.ReadLine());
              Console.WriteLine("Escribe el segundo digito: ");
              num2 = Convert.ToDouble(Console.ReadLine());
              resultado = num1 + num2;
              Console.WriteLine("La suma de {0} + {1} = " + resultado, num1, num2 );
              Thread.Sleep(milliseconds2);
            } 
            catch (Exception e)
            {
              Console.WriteLine("Valor no deseado. " + e.Message);
              Thread.Sleep(milliseconds2);
            }
            break;

        // Operacion de Resta
            case 2:            
            try
            {
              Console.WriteLine("//Seleccionaste Resta//");
              Console.WriteLine("Escribe el primer digito: ");
              num1 = Convert.ToDouble(Console.ReadLine());
              Console.WriteLine("Escribe el segundo digito: ");
              num2 = Convert.ToDouble(Console.ReadLine());
              resultado = num1 - num2;
              Console.WriteLine("La resta de {0} - {1} = " + resultado, num1, num2 );
              Thread.Sleep(milliseconds2);
            } 
            catch (Exception e)
            {
              Console.WriteLine("Valor no deseado. " + e.Message);
              Thread.Sleep(milliseconds2);
            }
            break;

        // Operacion de Multiplicacion
            case 3: 
            try
            {
              Console.WriteLine("//Seleccionaste Multiplicación//");
              Console.WriteLine("Escribe el primer digito: ");
              num1 = Convert.ToDouble(Console.ReadLine());
              Console.WriteLine("Escribe el segundo digito: ");
              num2 = Convert.ToDouble(Console.ReadLine());
              resultado = num1 * num2;
              Console.WriteLine("El producto de {0} * {1} = " + resultado, num1, num2 );
              Thread.Sleep(milliseconds2);
            } 
            catch (Exception e)
            {
              Console.WriteLine("Valor no deseado. " + e.Message);
              Thread.Sleep(milliseconds2);
            }
            break;

        // Operacion de Division
            case 4:            
            try
            {
              Console.WriteLine("//Seleccionaste Division//");
              Console.WriteLine("Escribe el primer digito: ");
              num1 = Convert.ToDouble(Console.ReadLine());
              Console.WriteLine("Escribe el segundo digito: ");
              num2 = Convert.ToDouble(Console.ReadLine());
              resultado = num1 / num2;
              Console.WriteLine("La division de {0} / {1} = " + resultado, num1, num2 );
              Thread.Sleep(milliseconds2);
            } 
            catch (Exception e)
            {
              Console.WriteLine("Valor no deseado. " + e.Message);
              Thread.Sleep(milliseconds2);
            }
            break;

        // Estado Neutro del Menu (Para poder asignarle un valor a la variable y que no se vaya al default)
            case 10: 
              Thread.Sleep(milliseconds2);
            break;

        // SALIDA del programa
            case 0: Console.WriteLine("Gracias por usar la calculadora"); 
            break;

            // Mensaje de error al introducir un valor diferente a 0 < menu < 5.
            default: Console.WriteLine("Valor incorrecto, intente con los valores descritos por las opciones");
              Thread.Sleep(milliseconds2);
            break;
        }

      } while (Menu != 0);

    //Mensaje de que la calculdora cerrará, un delay de 2 segundos y el comando de salida de la consola.  
    Console.WriteLine("La Calculadora se cerrará en 2 Segundos ");
    Thread.Sleep(milliseconds);
    Environment.Exit(0); 
    }
}