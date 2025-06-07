internal class empleado
{


    static string[] nombre = new string[3];   // arreglo unidimensional
    static string[] salario = new string[3];
    static string[] cedula = new string[3];
    static int pos = 0;

    static void ingresarEmpleado()
    {
        int opcion = 1;  // 1 es continuar 2 es salir
        while ((pos < nombre.Length) && (opcion == 1))
        {
            Console.Write("Ingrese el nombre: ");
            nombre[pos] = Console.ReadLine();
            Console.WriteLine("Ingrese la cedula: ");
            cedula[pos] = Console.ReadLine();
            Console.WriteLine("Ingrese el salario: ");
            salario[pos] = Console.ReadLine();
            pos++;

            Console.WriteLine("Usuario ingresado");
            Console.WriteLine("Desea continuar: 1=si y 2= no");
            opcion = int.Parse(Console.ReadLine());
        }

        if (pos == 3)
        {
            Console.WriteLine("No hay espacio en arreglo");
        }

    }

    static void ActualizarEmpleado()
    {
        int op = 0;
        Console.WriteLine("Que desea actualizar?: ");
        Console.WriteLine("Digite: 1= Cambiar el nombre, 2=Cambiar la cedula, 3=Cambiar el salario ");
        op = int.Parse(Console.ReadLine());
        Boolean activo = false;
        switch (op)
        {
            case 1:
                Console.Write("Digite un nombre: ");
                string nombTemporal = Console.ReadLine();


                for (int i = 0; i < nombre.Length; i++)
                {
                    if (nombTemporal.Equals(nombre[i]))
                    {
                        Console.WriteLine("Digite el nuevo nombre");
                        nombre[i] = Console.ReadLine();
                        Console.WriteLine("Empleado actualizado");
                        activo = true;
                        break;
                    }
                }

                if (!activo)
                {
                    Console.WriteLine("Usuario no existe");
                    Console.WriteLine("Desea ingresar el nuevo empleado S/N");
                    char respuesta = Convert.ToChar(Console.ReadLine());

                    switch (respuesta)
                    {
                        case 'S':
                            ingresarEmpleado();
                            break;
                        case 'N': break;
                    }
                }
                break;
            case 2:
                Console.Write("Digite la cedula: ");
                string cedTemporal = Console.ReadLine();

                for (int i = 0; i < cedula.Length; i++)
                {
                    if (cedTemporal.Equals(cedula[i]))
                    {
                        Console.WriteLine("Digite la nueva cedula");
                        cedula[i] = Console.ReadLine();
                        Console.WriteLine("Empleado actualizado");
                        activo = true;
                        break;
                    }
                }

                if (!activo)
                {
                    Console.WriteLine("Usuario no existe");
                    Console.WriteLine("Desea ingresar el nuevo empleado S/N");
                    char respuesta = Convert.ToChar(Console.ReadLine());

                    switch (respuesta)
                    {
                        case 'S':
                            ingresarEmpleado();
                            break;
                        case 'N': break;
                    }
                }
                break;
            case 3:
                {
                    Console.Write("Digite el salario: ");
                    string salTemporal = Console.ReadLine();

                    for (int i = 0; i < salario.Length; i++)
                    {
                        if (salTemporal.Equals(salario[i]))
                        {
                            Console.WriteLine("Digite el nuevo salario");
                            salario[i] = Console.ReadLine();
                            Console.WriteLine("Empleado actualizado");
                            activo = true;
                            break;
                        }
                    }

                    if (!activo)
                    {
                        Console.WriteLine("Usuario no existe");
                        Console.WriteLine("Desea ingresar el nuevo empleado S/N");
                        char respuesta = Convert.ToChar(Console.ReadLine());

                        switch (respuesta)
                        {
                            case 'S':
                                ingresarEmpleado();
                                break;
                            case 'N': break;
                        }
                    }
                }
                break;
        }


    }

    static void BorrarEmpleado()
    {
        Console.WriteLine("Ingrese el nombre del empleado que desea borrar");
        string nombreTemporal = Console.ReadLine();


        for (int i = 0; i < nombre.Length; i++)
        {
            if (nombreTemporal.Equals(nombre[i]))
            {
                nombre[i] = null;
                cedula[i] = null;
                salario[i] = null;
                Console.WriteLine("Empleado borrado");
            }
            else
            {
                Console.WriteLine("Empleado no encontrado");
            }
            


        }
    }

    static void reportes()
    {
        for (int i = 0; i < nombre.Length; i++)
        {

            Console.WriteLine($"Nombre del empleado: {nombre[i]}, Cedula: {cedula[i]}, Salario: {salario[i]}, ");
        }
    }

    public static void menu()
    {
        byte op = 0;

        do
        {
            Console.WriteLine("1- Ingresar Empleados");
            Console.WriteLine("2- Modificar Empleados");
            Console.WriteLine("3- Borrar Empleados");
            Console.WriteLine("4- Consultar Empleados");
            Console.WriteLine("5- Salir");
            Console.Write("Elija una opcion: ");
            byte.TryParse(Console.ReadLine(), out op);

            switch (op)
            {
                case 1:
                    ingresarEmpleado();
                    break;
                case 2:
                    ActualizarEmpleado();
                    break;
                case 3:
                    BorrarEmpleado();
                    break;
                case 4:
                    reportes();
                    break;
                case 5:
                    Console.WriteLine("Saliendo del sistema...");
                    break;
                default:
                    Console.WriteLine("Opcion incorrecta");
                    break;
            }
        } while (op != 5);
    }

    public static void Main(string[] args)
    {
        empleado.menu();
    }
}

//Console.WriteLine($"Nombre Actual:");
//string nombreABorrar = Console.ReadLine();
//List<string> listaBorrar = new List<string>(nombre);
//listaBorrar.Remove(nombreABorrar);
//nombre = listaBorrar.ToArray();