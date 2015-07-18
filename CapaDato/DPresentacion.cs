using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDato
{
    public class DPresentacion
    {
        private int id_presentacion;
        private string nombre;
        private string descripcion;
        private string texto_buscar;

        //shortcut constructor = ctor   
        public DPresentacion()
        {
                            
        }
        public DPresentacion(int id_presentacion,string nombre, string descripcion, string text_buscar)
        {
            this.IdPresentacion = id_presentacion;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.TextoBuscar = text_buscar;
        }

        public int IdPresentacion { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string TextoBuscar { get; set; }



        /*Esto se deberia implementa en otra clase como UNA CLASE DAO*/

        //Metodo Insertar
        public string Insertar(DPresentacion presentacion)
        {
            string salida = "";
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = Conexion.string_conn;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "spinsertar_presentacion";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter id_presentacion = new SqlParameter();
                id_presentacion.ParameterName = "@idpresentacion";
                id_presentacion.SqlDbType = SqlDbType.Int;
                id_presentacion.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(id_presentacion);

                SqlParameter nombre = new SqlParameter();
                nombre.ParameterName = "@nombre";
                nombre.SqlDbType = SqlDbType.VarChar;
                nombre.Size = 50;
                nombre.Value = presentacion.Nombre;
                cmd.Parameters.Add(nombre);

                SqlParameter descripcion = new SqlParameter();
                descripcion.ParameterName = "@descripcion";
                descripcion.SqlDbType = SqlDbType.VarChar;
                descripcion.Size = 256;
                descripcion.Value = presentacion.Descripcion;
                cmd.Parameters.Add(descripcion);


                //ejecutamos nuestro comando
                salida = cmd.ExecuteNonQuery() == 1 ? "OK" : "no se ingreso el registro";
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
        public string Editar(DPresentacion presentacion)
        {
            string salida = "";
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = Conexion.string_conn;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "speditar_presentacion";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter id_presentacion = new SqlParameter();
                id_presentacion.ParameterName = "@idpresentacion";
                id_presentacion.SqlDbType = SqlDbType.Int;
                id_presentacion.Value = presentacion.IdPresentacion;
                cmd.Parameters.Add(id_presentacion);

                SqlParameter nombre = new SqlParameter();
                nombre.ParameterName = "@nombre";
                nombre.SqlDbType = SqlDbType.VarChar;
                nombre.Size = 50;
                nombre.Value = presentacion.Nombre;
                cmd.Parameters.Add(nombre);

                SqlParameter descripcion = new SqlParameter();
                descripcion.ParameterName = "@descripcion";
                descripcion.SqlDbType = SqlDbType.VarChar;
                descripcion.Size = 256;
                descripcion.Value = presentacion.Descripcion;
                cmd.Parameters.Add(descripcion);


                //ejecutamos nuestro comando
                salida = cmd.ExecuteNonQuery() == 1 ? "OK" : "no se actualizo el registro";
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

        public string Eliminar(DPresentacion presentacion)
        {
            string salida = "";
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = Conexion.string_conn;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "speliminar_presentacion";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter id_presentacion = new SqlParameter();
                id_presentacion.ParameterName = "@idpresentacion";
                id_presentacion.SqlDbType = SqlDbType.Int;
                id_presentacion.Value = presentacion.IdPresentacion;
                cmd.Parameters.Add(id_presentacion);

                //ejecutamos nuestro comando
                salida = cmd.ExecuteNonQuery() == 1 ? "OK" : "no se elimino el registro";
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
            DataTable resultado = new DataTable("presentacion");
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                conn.ConnectionString = Conexion.string_conn;
                cmd.Connection = conn;
                cmd.CommandText = "spmostrar_presentacion";
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
        public DataTable BuscarNombre(DPresentacion presentacion)
        {
            DataTable resultado = new DataTable("presentacion");
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                conn.ConnectionString = Conexion.string_conn;
                cmd.Connection = conn;
                cmd.CommandText = "spbuscar_presentacion_nombre";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter buscar_texto = new SqlParameter();
                buscar_texto.ParameterName = "@textbuscar";
                buscar_texto.SqlDbType = SqlDbType.VarChar;
                buscar_texto.Size = 50;
                buscar_texto.Value = presentacion.TextoBuscar;
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
