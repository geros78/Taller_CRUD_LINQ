using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TallerCRUD_LINQ.Moduls;

namespace TallerCRUD_LINQ.Controllers
{
    public class AreaController : Areas
    {
        
        //Constructor para instancia
        public AreaController()
        {
            _Area = new List<Areas>();
        }
        private List<Areas> _Area;

        //Modificador de acceso
        private List<Areas> Area { get { return _Area; } }

        #region MostrarArea
        //Método mostrarArea
        public void MostrarArea()
        {
            Area.Clear();
            Area.Add(new Areas()
            {
                Id = 1,
                Nombre = "Desarrollo"
            });
            Area.Add(new Areas()
            {
                Id = 2,
                Nombre = "Recursos Humanos"
            });
            Area.Add(new Areas()
            {
                Id = 3,
                Nombre = "Mercadeo"
            });
            Area.Add(new Areas()
            {
                Id = 4,
                Nombre = "Atención al cliente"
            });
        }//Final método mostrar area

        #endregion MostrarArea

        #region getArea
        //Método getArea
        public void GetArea()
        {
            List<Areas> listaAreas = new List<Areas>();
            listaAreas.AddRange(from a in Area select a);
            ImprimirArea.Imprimir(listaAreas);
        }
        #endregion getArea

        #region GetAreaId
        //Método GetEmpleadosId
        public void GetAreabyId(int id)
        {
            List<Areas> listaAreas = new List<Areas>();
            listaAreas.AddRange(from a in Area where a.Id == id select a);
            if(listaAreas.Count > 0)
            {
                ImprimirArea.Imprimir(listaAreas);
            }
            else
            {
                Console.WriteLine("Id " + id  + "no registrado");
            }
        }
        #endregion GetAreaId

        #region crearArea
        //Método PostArea
        public void PostArea(int id, string nombre)
        {
            var VerificaId = Area.Any(a => a.Id == id);
            if(!VerificaId)
            {
                Area.Add(new Areas()
                {
                    Id = id,
                    Nombre = nombre
                });
                Console.WriteLine("Area creada exitosamente");
            }
            else
            {
                Console.WriteLine("Id ya registrado");
            }
        }
        #endregion crearArea

        #region updateAreaEmpleado
        //Método UpdateEmpleado
        public void UpdateArea(int id, string nombre)
        {
            var ReplaceItem = new Areas
            {
                Id = id,
                Nombre = nombre
            };

            var element = Area.FirstOrDefault(i => i.Id == ReplaceItem.Id);
            if (element != null)
            {
                Area.Remove(element);
                Area.Add(ReplaceItem);
            }
            else
            {
                Console.WriteLine("No existe Id para actualizar");
            }

        }
        #endregion updateAreaEmpleado


        #region DeletebyId
        //Método DeletebyId
        public void DeletebyIdA(int id)
        {
            var elementoItem = Area.FirstOrDefault(i => i.Id == id);
            if (elementoItem != null)
            {
                Area.Remove(elementoItem);
                Console.WriteLine("Registro " + id + "fue eliminado");
            }
            else
            {
                Console.WriteLine("Id no coincide con ningún registro");
            }

        }

        #endregion DeletebyId

    }//Final clase AreaController
}
