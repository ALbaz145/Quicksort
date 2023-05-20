internal class Program
{
    static public void QuickSort(int[] NoEmpleado, int primero, int ultimo)
    {
        int i, j, central;
        int pivote, temporal;

        central = (primero + ultimo) / 2;
        pivote = NoEmpleado[central]; // posición central
        i = primero; j = ultimo;

        do
        {
            while (NoEmpleado[i] > pivote) i++; // si primero es mayor que la posición central incrementa
            while (NoEmpleado[j] < pivote) j--; // si ultimo es menor que la posición central decrementa
            if (i <= j)
            {
                temporal = NoEmpleado[i]; // intercambios
                NoEmpleado[i] = NoEmpleado[j];
                NoEmpleado[j] = temporal;
                i++; j--;
            }
        } while (i <= j);

        if (primero < j)
        {
            QuickSort(NoEmpleado, primero, j); // llamada recursiva
        }
        if (i < ultimo)
        {

            QuickSort(NoEmpleado, i, ultimo); // llamada recursiva
        }
    }
    private static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Title = "P43 - SORTEO RAPIDO DE FORMA DESCENDENTE -";
        int[] NoEmpleado = new int[20];
        int C;
        int Capturado;
        int primero = 0, ultimo = NoEmpleado.Length - 1;

        Console.WriteLine("==========================================");
        Console.WriteLine("=           CAPTURA DE DATOS             =");
        Console.WriteLine("==========================================");
        Console.Write("Número de empleado comprendido entre <001 - 999> \n");

            for (C = 0; C < 20; C++) // captura de datos
            {
                try
                {
                    Console.Write("Ingrese el número de empleado {0}: ", C + 1);
                    Capturado = Convert.ToInt32(Console.ReadLine());
                    if (Capturado >= 1 && Capturado <= 999)
                    {
                        NoEmpleado[C] = Capturado;
                    }
                    else
                    {
                        Console.Write("El número de empleado debe estar comprendido entre <001 - 999> \n");
                        C--;
                    }
                }
                catch (FormatException e)
                {
                    Console.Write(e.Message +" Only Numbers\n\n");
                    C--;
                }
            }
        Console.Write("\n\nCaptura exitosa... presione ENTER para continuar");
        Console.ReadKey(); Console.Clear();

        Console.WriteLine("==========================================");
        Console.WriteLine("=     ARREGLO ORGINAL (DESORDENADO)      =");
        Console.WriteLine("==========================================\n");

            for (C = 0; C < 20; C++) // despliegue del arreglo original
            {
                Console.Write("{0} ", NoEmpleado[C]);
            }

        QuickSort(NoEmpleado, primero, ultimo); //ordenamiento

        Console.WriteLine("\n\n===========================================");
        Console.WriteLine("=  ARREGLO ORDENADO DE FORMA DESCENDENTE  =");
        Console.WriteLine("===========================================\n");

            for (C = 0; C < 20; C++) //despliegue del arreglo ordenado 
            {
                Console.Write("{0} ", NoEmpleado[C]);
            }

        Console.WriteLine("\n\nPrograma finalizado... presione ENTER para salir");
        Console.ReadKey();
    }

}