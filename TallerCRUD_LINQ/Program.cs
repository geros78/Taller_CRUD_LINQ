using System;
using TallerCRUD_LINQ.Controllers;
using TallerCRUD_LINQ.Moduls;

namespace TallerCRUD_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            int op = 0;
            int op2 = 0;

            int id = 0, IdEmpleado = 0,  dia = 0, idArea = 0;

            decimal sueldo = 0m, otro =0m;

            string nombre = string.Empty, apellido = string.Empty, direc = string.Empty, telefono= string.Empty;

            DateTime fecha = new DateTime();

            NominaController nc = new NominaController();
            EmpleadoController cemp = new EmpleadoController();
            AreaController ac = new AreaController();
            menu m = new menu();

            do
            {
                Console.ForegroundColor = ConsoleColor.White;

                m.menuPrincipal();
                
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:

                        

                        Console.WriteLine("Escoja Accion a realizar:\n 1. Mostrar Empleados\n" +
                            " 2. Mostrar empleado por Id\n 3. Crear empleado\n 4. Actualizar Empleado\n 5. Eliminar empleado x Id\n");
                        

                        op2 = Convert.ToInt32(Console.ReadLine());
                        cemp.MostrarEmpleados();
                        
                        switch (op2)
                        {
                            
                            case 1:
                                Console.WriteLine("-- Listado empleados --");
                                cemp.GetEmpleados();

                                Console.ReadKey();
                                Console.Clear();
                                Console.ReadKey();

                                break;

                            case 2:
                                Console.WriteLine("-- Listado empleados por Id --");
                                id = Convert.ToInt32(Console.ReadLine());
                                cemp.GetbyIdEmp(id);

                                Console.ReadKey();
                                Console.Clear();
                                Console.ReadKey();

                                break;

                            case 3:
                                Console.WriteLine("-- Crear nuevo empleado --");
                                Console.Write("Ingrese id empleado: ");
                                id = Convert.ToInt32(Console.ReadLine());

                                Console.Write("Ingrese nombre empleado: ");
                                nombre = Console.ReadLine();

                                Console.Write("Ingrese apellido empleado: ");
                                apellido = Console.ReadLine();

                                Console.Write("Ingrese dirección empleado: ");
                                direc = Console.ReadLine();

                                Console.Write("Ingrese teléfono empleado: ");
                                telefono = Console.ReadLine();

                                Console.Write("Ingrese fecha ingreso: ");
                                fecha = Convert.ToDateTime(Console.ReadLine());

                                Console.Write("Ingrese id area: ");
                                idArea = Convert.ToInt32(Console.ReadLine());

                                cemp.PostEmpleado(id, nombre, apellido, direc, telefono, fecha, idArea);
                                cemp.GetEmpleados();

                                Console.ReadKey();
                                Console.Clear();
                                Console.ReadKey();


                                break;

                            case 4:
                                Console.WriteLine("-- Modificar empleado existente --");
                                Console.Write("Ingrese id empleado: ");
                                id = Convert.ToInt32(Console.ReadLine());

                                Console.Write("Ingrese nombre empleado: ");
                                nombre = Console.ReadLine();

                                Console.Write("Ingrese apellido empleado: ");
                                apellido = Console.ReadLine();

                                Console.Write("Ingrese dirección empleado: ");
                                direc = Console.ReadLine();

                                Console.Write("Ingrese teléfono empleado: ");
                                telefono = Console.ReadLine();

                                Console.Write("Ingrese fecha ingreso: ");
                                fecha = Convert.ToDateTime(Console.ReadLine());

                                Console.Write("Ingrese id area: ");
                                idArea = Convert.ToInt32(Console.ReadLine());

                                cemp.UpdateEmpleado(id, nombre, apellido, direc, telefono, fecha, idArea);
                                cemp.GetEmpleados();

                                Console.ReadKey();
                                Console.Clear();
                                Console.ReadKey();

                                break;

                            case 5:
                                Console.WriteLine("-- Eliminar empleado por Id --");
                                Console.Write("Introduza id a eliminar: ");
                                id = Convert.ToInt32(Console.ReadLine());
                                cemp.DeletebyIdE(id);
                                cemp.GetEmpleados();

                                Console.ReadKey();
                                Console.Clear();
                                Console.ReadKey();

                                break;


                            default:
                                Console.WriteLine("Funcion no valida");

                                Console.ReadKey();
                                Console.Clear();
                                Console.ReadKey();

                                break;
                        }

                        break;

                    case 2:

                        Console.WriteLine("Escoja Accion a realizar:\n 1. Mostrar Area\n" +
                            " 2. Mostrar Area x Id\n 3. Crear Area\n 4. Actualizar Area\n 5. Eliminar Area x Id\n");

                        op2 = Convert.ToInt32(Console.ReadLine());
                        ac.MostrarArea();

                        switch (op2)
                        {

                            case 1:
                                Console.WriteLine("-- Listado Areas --");
                                ac.GetArea();

                                Console.ReadKey();
                                Console.Clear();
                                Console.ReadKey();
                                break;

                            case 2:
                                Console.WriteLine("-- Listado areas por Id --");
                                id = Convert.ToInt32(Console.ReadLine());
                                ac.GetAreabyId(id);

                                Console.ReadKey();
                                Console.Clear();
                                Console.ReadKey();
                                break;

                            case 3:
                                Console.WriteLine("-- Crear nueva area --");
                                Console.Write("Ingrese id area: ");
                                id = Convert.ToInt32(Console.ReadLine());

                                Console.Write("Ingrese nombre area: ");
                                nombre = Console.ReadLine();

                                ac.PostArea(id, nombre);
                                ac.GetArea();

                                Console.ReadKey();
                                Console.Clear();
                                Console.ReadKey();

                                break;

                            case 4:
                                Console.WriteLine("-- Actualizar area --");

                                Console.Write("Ingrese Id: ");
                                id = Convert.ToInt32(Console.ReadLine());

                                Console.Write("Ingrese nombre: ");
                                nombre = Console.ReadLine();

                                ac.UpdateArea(id, nombre);
                                ac.GetArea();

                                Console.ReadKey();
                                Console.Clear();
                                Console.ReadKey();
                                break;

                            case 5:
                                Console.WriteLine("-- Eliminar area por id --");
                                id = Convert.ToInt32(Console.ReadLine());
                                ac.DeletebyIdA(id);
                                ac.GetArea();
                                Console.ReadLine();
                                break;

                            default:
                                Console.WriteLine("Funcion no valida");

                                Console.ReadKey();
                                Console.Clear();
                                Console.ReadKey();

                                break;
                        }


                        break;

                    case 3:

                        Console.WriteLine("Escoja Accion a realizar:\n 1. Mostrar Nomina\n" +
                            " 2. Mostrar Nomina x Id\n 3. Crear Nomina\n 4. Actualizar Nomina\n 5. Eliminar Nomina x Id\n");

                        op2 = Convert.ToInt32(Console.ReadLine());
                        nc.LlenarLista();
                        

                        switch (op2)
                        {

                            case 1:
                                Console.WriteLine("-- Listado Nómina --");
                                nc.get();

                                Console.ReadKey();
                                Console.Clear();
                                Console.ReadKey();

                                break;

                            case 2:
                                Console.WriteLine("-- Listado Nómina por id --");
                                id = Convert.ToInt32(Console.ReadLine());
                                nc.getbyID(id);

                                Console.ReadKey();
                                Console.Clear();
                                Console.ReadKey();

                                break;

                            case 3:
                                Console.WriteLine("-- Registre Nomina --");

                                Console.Write("Ingrese Id: ");
                                id = Convert.ToInt32(Console.ReadLine());

                                Console.Write("Ingrese fecha: ");
                                fecha = DateTime.Parse(Console.ReadLine());

                                Console.Write("Ingrese id empleado: ");
                                IdEmpleado = Convert.ToInt32(Console.ReadLine());

                                Console.Write("Ingrese sueldo: ");
                                sueldo = Convert.ToDecimal(Console.ReadLine());

                                Console.Write("Ingrese dias de trabajo: ");
                                dia = Convert.ToInt32(Console.ReadLine());

                                Console.Write("Ingrese otros pagos: ");
                                otro = Convert.ToDecimal(Console.ReadLine());

                                nc.post(id, fecha, IdEmpleado, sueldo, dia, otro);
                                nc.get();

                                Console.ReadKey();
                                Console.Clear();
                                Console.ReadKey();


                                break;

                            case 4:
                                Console.WriteLine("-- Editar nomina x id --");

                                Console.Write("Ingrese Id: ");
                                id = Convert.ToInt32(Console.ReadLine());

                                Console.Write("Ingrese fecha: ");
                                fecha = DateTime.Parse(Console.ReadLine());

                                Console.Write("Ingrese id empleado: ");
                                IdEmpleado = Convert.ToInt32(Console.ReadLine());

                                Console.Write("Ingrese sueldo: ");
                                sueldo = Convert.ToDecimal(Console.ReadLine());

                                Console.Write("Ingrese dias de trabajo: ");
                                dia = Convert.ToInt32(Console.ReadLine());

                                Console.Write("Ingrese otros pagos: ");
                                otro = Convert.ToDecimal(Console.ReadLine());

                                nc.update(id, fecha, IdEmpleado, sueldo, dia, otro);
                                nc.get();

                                Console.ReadKey();
                                Console.Clear();
                                Console.ReadKey();

                                break;

                            case 5:
                                Console.WriteLine("-- Eliminar nomina x id --");
                                id = Convert.ToInt32(Console.ReadLine());
                                nc.DeletexId(id);
                                nc.get();

                                Console.ReadKey();
                                Console.Clear();
                                Console.ReadKey();


                                break;

                            default:
                                Console.WriteLine("Funcion no valida");
                                Console.ReadLine();
                                
                                break;
                        }

                        break;

                    case 4:
                        char confirmacion = 'N';
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Realmente quieres salir? (S/N)");

                        confirmacion = Convert.ToChar(Console.ReadLine());
                        if (confirmacion == 'S')
                        {
                            op = 4;
                        }
                        else
                        {
                            op = 1;
                        }
                        break;

                    default:
                        Console.WriteLine("Módulo no valido");
                        break;
                }

            } while (op != 4);
        }
    }
}
