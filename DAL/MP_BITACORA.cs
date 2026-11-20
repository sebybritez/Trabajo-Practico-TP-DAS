using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class MP_BITACORA
    {
        private Acceso acceso = new Acceso();

        public int Insertar(BE.BITACORA item)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@id_usuario", item.IdUsuario));
            parametros.Add(acceso.CrearParametro("@evento", item.Evento));
            parametros.Add(acceso.CrearParametro("@detalle", item.Detalle));

            acceso.Abrir();
            int resultado = acceso.Escribir("BITACORA_INSERTAR", parametros);
            acceso.Cerrar();
            return resultado;
        }

        public List<BE.BITACORA> Listar()
        {
            List<BE.BITACORA> lista = new List<BE.BITACORA>();
            acceso.Abrir();
            DataTable tabla = acceso.Leer("BITACORA_LISTAR");
            acceso.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            {
                BE.BITACORA b = new BE.BITACORA();
                b.Id = int.Parse(registro["ID"].ToString());
                b.Fecha = DateTime.Parse(registro["FECHA"].ToString());
                b.IdUsuario = int.Parse(registro["ID_USUARIO"].ToString());
                b.NombreUsuario = registro["USUARIO"].ToString();
                b.Evento = registro["EVENTO"].ToString();
                b.Detalle = registro["DETALLE"].ToString();
                lista.Add(b);
            }
            return lista;
        }
    }
}

