using System;
using System.Collections.Generic;
using System.Text;
using TallerCRUD_LINQ.Moduls;

namespace TallerCRUD_LINQ.Controllers
{
    public static class ImprimirNomina

    {

        
        public static void Imprimir(List<Nomina> Nomina)
        {
            NominaController ec = new NominaController();

            foreach (var item in Nomina)
            {
                Console.WriteLine("[Id: {0}] [Fecha: {1}] [IdEmpleado: {2}] [Sueldo: {3}] [Dias: {4}]\n" +
                    " [Otros: {5}] [TotalBasico: {6}] [Devengado: {7}] \n",
                    item.Id, item.Fecha, item.IdEmpleado, item.Sueldo, item.Dias, item.Otros,
                    ec.TotalBasico(item.Sueldo, item.Dias), ec.Devengado(ec.TotalBasico(item.Sueldo, item.Dias), item.Otros));
            }
        }
    }
}
