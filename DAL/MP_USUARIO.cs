using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class MP_USUARIO
    {
        private Acceso acceso = new Acceso();

        private BE.USUARIO MapearUsuario(DataRow registro)
        {
            BE.USUARIO u = new BE.USUARIO();
            u.Id = int.Parse(registro["ID"].ToString());
            u.Nombre = registro["NOMBRE"].ToString();
            u.Contrasena = registro["CONTRASENA"].ToString();
            u.Ganadas = int.Parse(registro["GANADAS"].ToString());
            u.Perdidas = int.Parse(registro["PERDIDAS"].ToString());
            u.Empatadas = int.Parse(registro["EMPATADAS"].ToString());
            u.SegundosJugados = int.Parse(registro["SEGUNDOS_JUGADOS"].ToString());
            return u;
        }

        public int Insertar(BE.USUARIO usuario)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@nom", usuario.Nombre));
            parametros.Add(acceso.CrearParametro("@pass", usuario.Contrasena));

            acceso.Abrir();
            int resultado = acceso.Escribir("USUARIO_INSERTAR", parametros);
            acceso.Cerrar();
            return resultado;
        }

        public BE.USUARIO Login(string nombre, string contrasena)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@nom", nombre));
            parametros.Add(acceso.CrearParametro("@pass", contrasena));

            acceso.Abrir();
            DataTable tabla = acceso.Leer("USUARIO_LOGIN", parametros);
            acceso.Cerrar();

            if (tabla.Rows.Count > 0)
            {
                return MapearUsuario(tabla.Rows[0]);
            }
            return null;
        }

        public List<BE.USUARIO> Listar()
        {
            List<BE.USUARIO> lista = new List<BE.USUARIO>();
            acceso.Abrir();
            DataTable tabla = acceso.Leer("USUARIO_LISTAR");
            acceso.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            {
                lista.Add(MapearUsuario(registro));
            }
            return lista;
        }

        public int ActualizarEstadisticas(BE.USUARIO usuario)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@id", usuario.Id));
            parametros.Add(acceso.CrearParametro("@ganadas", usuario.Ganadas));
            parametros.Add(acceso.CrearParametro("@perdidas", usuario.Perdidas));
            parametros.Add(acceso.CrearParametro("@empatadas", usuario.Empatadas));
            parametros.Add(acceso.CrearParametro("@segundos", usuario.SegundosJugados));

            acceso.Abrir();
            int resultado = acceso.Escribir("USUARIO_ACTUALIZAR_ESTADISTICAS", parametros);
            acceso.Cerrar();
            return resultado;
        }
    }
}

