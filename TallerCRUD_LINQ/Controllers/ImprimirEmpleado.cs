using System;
using System.Collections.Generic;
using System.Text;
using TallerCRUD_LINQ.Moduls;

namespace TallerCRUD_LINQ.Controllers
{
    public class ImprimirEmpleado
    {
        public static void Imprimir(List<Empleados> Empleado)
        {
            foreach(var item in Empleado)
            {
                Console.WriteLine("Id: {0} Nombre: {1} Apellidos: {2} Direccion: {3} Telefono: {4} FechaIngreso: {5} IdArea: {6}",
                    item.Id, item.Nombre, item.Apellidos, item.Direccion, item.Telefono, item.FechaIngreso, item.IdArea);
            }
        }
    }
}
