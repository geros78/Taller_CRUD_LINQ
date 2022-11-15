using System;
using System.Collections.Generic;
using System.Text;
using TallerCRUD_LINQ.Moduls;

namespace TallerCRUD_LINQ.Controllers
{
    class ImprimirArea
    {
        public static void Imprimir(List<Areas> Area)
        {
            foreach (var item in Area)
            {
                Console.WriteLine("Id: {0} || Nombre: {1}\n",
                    item.Id, item.Nombre);
            }
        }
    }
}
