using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class MP_PARTIDA
    {
        private Acceso acceso = new Acceso();

        public int Insertar(BE.PARTIDA partida)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@id_j1", partida.IdJugador1));
            parametros.Add(acceso.CrearParametro("@id_j2", partida.IdJugador2));
            parametros.Add(acceso.CrearParametro("@imp_j1", partida.ImpactosJ1));
            parametros.Add(acceso.CrearParametro("@imp_j2", partida.ImpactosJ2));
            parametros.Add(acceso.CrearParametro("@id_ganador", partida.IdGanador));
            parametros.Add(acceso.CrearParametro("@duracion", partida.DuracionSegundos));
            parametros.Add(acceso.CrearParametro("@xml", partida.ArchivoXml));

            acceso.Abrir();
            int resultado = acceso.Escribir("PARTIDA_INSERTAR", parametros);
            acceso.Cerrar();
            return resultado;
        }

        public List<BE.PARTIDA> Listar()
        {
            List<BE.PARTIDA> lista = new List<BE.PARTIDA>();
            acceso.Abrir();
            DataTable tabla = acceso.Leer("PARTIDA_LISTAR");
            acceso.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            {
                BE.PARTIDA p = new BE.PARTIDA();
                p.Id = int.Parse(registro["ID"].ToString());
                p.Fecha = DateTime.Parse(registro["FECHA"].ToString());
                p.IdJugador1 = int.Parse(registro["ID_JUGADOR1"].ToString());
                p.NombreJugador1 = registro["JUGADOR1"].ToString();
                p.IdJugador2 = int.Parse(registro["ID_JUGADOR2"].ToString());
                p.NombreJugador2 = registro["JUGADOR2"].ToString();
                p.ImpactosJ1 = int.Parse(registro["IMPACTOS_J1"].ToString());
                p.ImpactosJ2 = int.Parse(registro["IMPACTOS_J2"].ToString());
                p.IdGanador = int.Parse(registro["ID_GANADOR"].ToString());
                p.NombreGanador = registro["GANADOR"].ToString();
                p.DuracionSegundos = int.Parse(registro["DURACION_SEGUNDOS"].ToString());
                p.ArchivoXml = registro["ARCHIVO_XML"].ToString();
                lista.Add(p);
            }
            return lista;
        }
    }
}

