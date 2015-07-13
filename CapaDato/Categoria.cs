using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDato
{
    public class Categoria
    {
        private int id_categoria;      
        private string nombre;
        private string descripcion;
        private string text_buscar;

        public Categoria() { }

        public Categoria(int id_categoria, string nombre, string descripcion, string text_buscar)
        {
            this.ID_categoria = id_categoria;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.TextoBuscar = text_buscar;
        }

        public int ID_categoria
        {
            get { return id_categoria; }
            set { id_categoria = value; }
        }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public string TextoBuscar { get; set; }




        /*Esto se deberia implementa en otra clase como UNA CLASE DAO*/

        //Metodo Insertar
        public string Insertar(Categoria categoria)
        {
            string salida = "";
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "psinsertar_categoria";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter idcategoria = new SqlParameter();
            idcategoria.ParameterName = "@idcategoria";
            idcategoria.SqlDbType= SqlDbType.Int;
            idcategoria.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(id_categoria);

            SqlParameter nombre = new SqlParameter();
            nombre.ParameterName = "@nombre";
            nombre.SqlDbType = SqlDbType.VarChar;
            nombre.Size = 50;
            nombre.Value = categoria.Nombre;
            cmd.Parameters.Add(nombre);

            SqlParameter descripcion = new SqlParameter();
            descripcion.ParameterName = "@descripcion";
            descripcion.SqlDbType = SqlDbType.VarChar;
            descripcion.Size = 256;
            descripcion.Value = categoria.Descripcion;
            cmd.Parameters.Add(descripcion);


            //ejecutamos nuestro comando
            salida = cmd.ExecuteNonQuery() == 1 ? "OK" : "no se ingreso el registro";
            try
            {
                conn.ConnectionString = Conexion.string_conn;
                conn.Open();
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();    
                }                
            }
            return salida;
        }
        
        //  Editar
        public string Editar(Categoria categoria)
        {
            string salida = "";
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "speditar_categoria";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter idcategoria = new SqlParameter();
            idcategoria.ParameterName = "@idcategoria";
            idcategoria.SqlDbType = SqlDbType.Int;
            idcategoria.Value = categoria.ID_categoria;
            cmd.Parameters.Add(id_categoria);

            SqlParameter nombre = new SqlParameter();
            nombre.ParameterName = "@nombre";
            nombre.SqlDbType = SqlDbType.VarChar;
            nombre.Size = 50;
            nombre.Value = categoria.Nombre;
            cmd.Parameters.Add(nombre);

            SqlParameter descripcion = new SqlParameter();
            descripcion.ParameterName = "@descripcion";
            descripcion.SqlDbType = SqlDbType.VarChar;
            descripcion.Size = 256;
            descripcion.Value = categoria.Descripcion;
            cmd.Parameters.Add(descripcion);


            //ejecutamos nuestro comando
            salida = cmd.ExecuteNonQuery() == 1 ? "OK" : "no se actualizo el registro";
            try
            {
                conn.ConnectionString = Conexion.string_conn;
                conn.Open();
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return salida;
        }

        public string Eliminar(Categoria categoria)
        {
            string salida = "";
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "speliminar_categoria";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter idcategoria = new SqlParameter();
            idcategoria.ParameterName = "@idcategoria";
            idcategoria.SqlDbType = SqlDbType.Int;
            idcategoria.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(id_categoria);

            //ejecutamos nuestro comando
            salida = cmd.ExecuteNonQuery() == 1 ? "OK" : "no se elimino el registro";
            try
            {
                conn.ConnectionString = Conexion.string_conn;
                conn.Open();
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return salida;
        }

        //metodo mostrar
        public DataTable Mostrar()
        {
            DataTable resultado = new DataTable("categoria");
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                conn.ConnectionString = Conexion.string_conn;
                cmd.Connection = conn;
                cmd.CommandText = "spmostar_categoria";
                cmd.CommandType = CommandType.StoredProcedure;

                //ejecutar el dato y llenar la table
                SqlDataAdapter sqldato = new SqlDataAdapter(cmd);
                sqldato.Fill(resultado);

            }
            catch (Exception ex)
            {
                resultado = null;
            }

            return resultado;

        }

        //metodo buscar nombre
        public DataTable BuscarNombre(Categoria categoria)
        {
            DataTable resultado = new DataTable("categoria");
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                conn.ConnectionString = Conexion.string_conn;
                cmd.Connection = conn;
                cmd.CommandText = "spbuscar_categoria";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter buscar_texto = new SqlParameter();
                buscar_texto.ParameterName = "@textobuscar";
                buscar_texto.SqlDbType = SqlDbType.VarChar;
                buscar_texto.Size = 50;
                buscar_texto.Value = categoria.TextoBuscar;
                cmd.Parameters.Add(buscar_texto);

                //ejecutar el dato y llenar la table
                SqlDataAdapter sqldato = new SqlDataAdapter(cmd);
                sqldato.Fill(resultado);

            }
            catch (Exception ex)
            {
                resultado = null;
            }

            return resultado;
        }


    }
}
