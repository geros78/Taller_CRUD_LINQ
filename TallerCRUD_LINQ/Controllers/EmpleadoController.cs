using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TallerCRUD_LINQ.Moduls;

namespace TallerCRUD_LINQ.Controllers
{
    public class EmpleadoController : Empleados
    {
        //Constructor para instanciar la lista 
        public EmpleadoController()
        {
            _Empleados = new List<Empleados>();
        }

        private List<Empleados> _Empleados;

        //Modificador de acceso
        public List<Empleados> Empleados { get { return _Empleados; } }

        //Método mostrar empleados 
        public void MostrarEmpleados()
        {
            Empleados.Clear();
            Empleados.Add(new Empleados()
            {
                Id = 1,
                Nombre = "Sara",
                Apellidos = "Arteaga",
                Direccion = "Calle 1E Oe #38b - 56",
                Telefono = "3128873278",
                FechaIngreso = DateTime.Parse("2020/04/12"),
                IdArea = 1
            });
            Empleados.Add(new Empleados()
            {
                Id = 2,
                Nombre = "Alejandro",
                Apellidos = "Otaiza",
                Direccion = "Calle 13b #09-18",
                Telefono = "3147659820",
                FechaIngreso = DateTime.Parse("2021/09/10"),
                IdArea = 2
            });
            Empleados.Add(new Empleados()
            {
                Id = 3,
                Nombre = "Michael",
                Apellidos = "Morantes",
                Direccion = "Cra 3N #56-02",
                Telefono = "3207845367",
                FechaIngreso = DateTime.Parse("2019/08/15"),
                IdArea = 3
            });
        }//Final método MostrarEmpleados

        #region GetEmpleados
        //Método GetEmpleados
        public void GetEmpleados()
        {
            List<Empleados> listaEmpleados = new List<Empleados>();
            listaEmpleados.AddRange(from e in Empleados select e);
            ImprimirEmpleado.Imprimir(listaEmpleados);
        }
        #endregion GetEmpleados

        #region GetEmpleadosId
        //Método GetEmpleadosId
        public void GetbyIdEmp(int id)
        {
            List<Empleados> listaEmpleados = new List<Empleados>();
            listaEmpleados.AddRange(from e in Empleados where e.Id == id select e);
            if(listaEmpleados.Count > 0)
            {
                ImprimirEmpleado.Imprimir(listaEmpleados);
            }
            else
            {
                Console.WriteLine("Id " + id + "no registrado");
            }
            
        }
        #endregion GetEmpleadosId

        #region PostEmpleado
        //Método PostEmpleado
        public void PostEmpleado(int id, string nombre, string apellidos, string direccion, string telefono, DateTime fechaIngreso, int idArea)
        {
            var VerificaId = Empleados.Any(e => e.Id == id);
            if (!VerificaId)
            {
                Empleados.Add(new Empleados()
                {
                    Id = id,
                    Nombre = nombre,
                    Apellidos = apellidos,
                    Direccion = direccion,
                    Telefono = telefono,
                    FechaIngreso = fechaIngreso,
                    IdArea = idArea
                });
                Console.WriteLine("Empleado creado exitosamente");
            }
            else
            {
                Console.WriteLine("Id ya registrado");
            }
        }
        #endregion PostEmpleado

        #region UpdateEmpleado
        //Método UpdateEmpleado
        public void UpdateEmpleado(int id, string nombre, string apellidos, string direccion, string telefono, DateTime fechaIngreso, int idArea)
        {
            var ReplaceItem = new Empleados
            {
                Id = id,
                Nombre = nombre,
                Apellidos = apellidos,
                Direccion = direccion,
                Telefono = telefono,
                FechaIngreso = fechaIngreso,
                IdArea = idArea
            };

            var element = Empleados.FirstOrDefault(i => i.Id == ReplaceItem.Id);
            if(element != null)
            {
                Empleados.Remove(element);
                Empleados.Add(ReplaceItem);
            }
            else
            {
                Console.WriteLine("No existe Id para actualizar");
            }
            
        }
        #endregion UpdateEmpleado

        #region DeletebyId
        //Método DeletebyId
        public void DeletebyIdE(int id)
        {
            var elementoItem = Empleados.FirstOrDefault(i => i.Id == id);
            if (elementoItem != null)
            {
                Empleados.Remove(elementoItem);
                Console.WriteLine("Registro " + id + "fue eliminado");
            }
            else
            {
                Console.WriteLine("Id no coincide con ningún registro");
            }
            
        }

        #endregion DeletebyId


    }//Final clase EmpleadoController
}
