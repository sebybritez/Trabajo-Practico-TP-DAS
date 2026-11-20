using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    internal class Acceso
    {
        private SqlConnection conexion;

        private string ObtenerCadenaConexion(string baseDatos)
        {
            string servidor = ConfigurationManager.AppSettings["SqlServer"];
            if (string.IsNullOrWhiteSpace(servidor))
            {
                servidor = ".";
            }
            return string.Format("Initial Catalog={0}; Data Source={1}; Integrated Security=SSPI", baseDatos, servidor);
        }

        public void Abrir()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = ObtenerCadenaConexion("BATALLA_NAVAL");
            conexion.Open();
        }

        public void Cerrar()
        {
            if (conexion != null)
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
                conexion = null;
            }
            GC.Collect();
        }

        private SqlCommand CrearComando(string sql, List<SqlParameter> parametros = null)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandText = sql;
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;
            if (parametros != null)
            {
                foreach (SqlParameter p in parametros)
                {
                    comando.Parameters.Add(p);
                }
            }
            return comando;
        }

        public DataTable Leer(string sql, List<SqlParameter> parametros = null)
        {
            DataTable tabla = new DataTable();
            using (SqlDataAdapter adaptador = new SqlDataAdapter())
            {
                adaptador.SelectCommand = CrearComando(sql, parametros);
                adaptador.Fill(tabla);
                adaptador.Dispose();
            }
            return tabla;
        }

        public int Escribir(string sql, List<SqlParameter> parametros = null)
        {
            SqlCommand comando = CrearComando(sql, parametros);
            int filas = 0;
            try
            {
                filas = comando.ExecuteNonQuery();
            }
            catch
            {
                filas = -1;
            }
            return filas;
        }

        public SqlParameter CrearParametro(string nombre, string valor)
        {
            SqlParameter p = new SqlParameter(nombre, valor ?? string.Empty);
            p.DbType = DbType.String;
            return p;
        }

        public SqlParameter CrearParametro(string nombre, int valor)
        {
            SqlParameter p = new SqlParameter(nombre, valor);
            p.DbType = DbType.Int32;
            return p;
        }

        public SqlParameter CrearParametro(string nombre, DateTime valor)
        {
            SqlParameter p = new SqlParameter(nombre, valor);
            p.DbType = DbType.DateTime;
            return p;
        }

        public void EjecutarSqlMaster(string sqlTexto)
        {
            SqlConnection.ClearAllPools();
            using (SqlConnection cn = new SqlConnection(ObtenerCadenaConexion("master")))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlTexto, cn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandTimeout = 120;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public object LeerEscalarMaster(string sqlTexto)
        {
            using (SqlConnection cn = new SqlConnection(ObtenerCadenaConexion("master")))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlTexto, cn))
                {
                    cmd.CommandType = CommandType.Text;
                    return cmd.ExecuteScalar();
                }
            }
        }
    }
}

