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
        //metodo Insertar que llama al metodo Insertar de la clase Categoria
        //de la capa datos
        public static string Insertar(string nombre, string descripcion)
        {
            Categoria Obj_datos = new Categoria();
            Obj_datos.Nombre = nombre;
            Obj_datos.Descripcion = descripcion;
            return Obj_datos.Insertar(Obj_datos);
        }

        public static string Editar(int id_categoria, string nombre, string descripcion)
        {
            Categoria Obj_datos = new Categoria();
            Obj_datos.ID_categoria = id_categoria;
            Obj_datos.Nombre = nombre;
            Obj_datos.Descripcion = descripcion;
            return Obj_datos.Editar(Obj_datos);
        }

        public static string Eliminar(int id_categoria)
        {
            Categoria Obj_datos = new Categoria();
            Obj_datos.ID_categoria = id_categoria;
            return Obj_datos.Eliminar(Obj_datos);
        }

        public static DataTable Mostrar()
        {
            return new Categoria().Mostrar();
        }

        public static DataTable BuscarNombre(string texto_buscar)
        {
            Categoria Obj_data = new Categoria();
            Obj_data.TextoBuscar = texto_buscar;
            return Obj_data.BuscarNombre(Obj_data);
        }
    }
}
