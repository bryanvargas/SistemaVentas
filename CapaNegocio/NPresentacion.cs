using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;
using System.Data;

namespace CapaNegocio
{
    public class NPresentacion
    {
        //metodo Insertar que llama al metodo Insertar de la clase Presentacion
        //de la capa datos
        public static string Insertar(string nombre, string descripcion)
        {
            DPresentacion Obj_datos = new DPresentacion();
            Obj_datos.Nombre = nombre;
            Obj_datos.Descripcion = descripcion;
            return Obj_datos.Insertar(Obj_datos);
        }

        public static string Editar(int id_presentacion, string nombre, string descripcion)
        {
            DPresentacion Obj_datos = new DPresentacion();
            Obj_datos.IdPresentacion = id_presentacion;
            Obj_datos.Nombre = nombre;
            Obj_datos.Descripcion = descripcion;
            return Obj_datos.Editar(Obj_datos);
        }

        public static string Eliminar(int id_presentacion)
        {
            DPresentacion Obj_datos = new DPresentacion();
            Obj_datos.IdPresentacion = id_presentacion;
            return Obj_datos.Eliminar(Obj_datos);
        }

        public static DataTable Mostrar()
        {
            return new DPresentacion().Mostrar();
        }

        public static DataTable BuscarNombre(string texto_buscar)
        {
            DPresentacion Obj_data = new DPresentacion();
            Obj_data.TextoBuscar = texto_buscar;
            return Obj_data.BuscarNombre(Obj_data);
        }
    }
}
