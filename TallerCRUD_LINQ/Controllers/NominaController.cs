using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TallerCRUD_LINQ.Moduls;

namespace TallerCRUD_LINQ.Controllers
{
    public class NominaController : Nomina
    {

        public NominaController()
        {
            _Nomina = new List<Nomina>();
        }
        private List<Nomina> _Nomina;
        private List<Nomina> Nomina { get { return _Nomina; } }

        #region LlenarLista
        public void LlenarLista()
        {
            Nomina.Clear();
            Nomina.Add(new Moduls.Nomina()
            {
                Id = 1,
                Fecha = DateTime.Parse("2022/10/07"),
                IdEmpleado = 1,
                Sueldo = 1200000m,
                Dias = 20,
                Otros = 200000m

            });
            Nomina.Add(new Moduls.Nomina()
            {
                Id = 2,
                Fecha = DateTime.Parse("2022/08/20"),
                IdEmpleado = 2,
                Sueldo = 1500000m,
                Dias = 28,
                Otros = 120000m

            });
            Nomina.Add(new Moduls.Nomina()
            {
                Id = 3,
                Fecha = DateTime.Parse("2022/01/01"),
                IdEmpleado = 3,
                Sueldo = 2100000,
                Dias = 30,
                Otros = 100000m

            });
        }
        #endregion LlenarLista

        #region get
        public void get()
        {
            List<Nomina> lista = new List<Nomina>();
            lista.AddRange(from o in Nomina orderby o.Id select o);
            if(lista.Count > 0)
            {
                ImprimirNomina.Imprimir(lista);
            }
            else
            {
                Console.WriteLine("[]");
            }
            
        }
        #endregion get

        #region getbyID
        public void getbyID(int id)
        {
            List<Nomina> lista = new List<Nomina>();
            lista.AddRange(from o in Nomina where o.Id == id select o);
            if (lista.Count > 0)
            {
                ImprimirNomina.Imprimir(lista);
            }
            else
            {
                Console.WriteLine("No hay elementos con ese Id");
            }
            

        }
        #endregion getbyID

        #region post
        public void post(int id, DateTime fecha, int idempleado, decimal sueldo, int dias, decimal otros)
        {
            Nomina.Add(new Nomina()
            {
                Id = id,
                Fecha = fecha,
                IdEmpleado = idempleado,
                Sueldo = sueldo,
                Dias = dias,
                Otros = otros
            });

        }
        #endregion post

        #region update
        public void update(int id, DateTime fecha, int idempleado, decimal sueldo, int dias, decimal otros)
        {
            var ReplaceItem = new Nomina
            {
                Id = id,
                Fecha = fecha,
                IdEmpleado = idempleado,
                Sueldo = sueldo,
                Dias = dias,
                Otros = otros
            };

            var element = Nomina.FirstOrDefault(i => i.Id == ReplaceItem.Id);
            if(element != null)
            {
                Nomina.Remove(element);
                Nomina.Add(ReplaceItem);
                
            }
            else
            {
                
            }
        }
        #endregion update

        #region DeletexId
        public void DeletexId(int id)
        {
            //var EliminarItem = new Productos { Id = id };
            var element = Nomina.FirstOrDefault(i => i.Id == id);
            if(element != null)
            {
                Nomina.Remove(element);
                Console.WriteLine("Registro " + id + "fue eliminado");
            }
            else
            {
                Console.WriteLine("No hay registros con el id:  " + id + "");
            }
            
        }
        #endregion DeletexId

        public decimal TotalBasico(decimal sueldo, int dias)
        {
            Sueldo = sueldo;
            Dias = dias;

            decimal diasConvert = Convert.ToDecimal(Dias);

            return (Sueldo * diasConvert)/30;
        }


        public decimal Devengado(decimal TotalBasico, decimal otro)
        {
            Otros = otro;
            return TotalBasico + Otros;
        }
        
    }
}
