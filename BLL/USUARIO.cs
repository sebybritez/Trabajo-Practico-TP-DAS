using System;
using System.Collections.Generic;
using DAL;

namespace BLL
{
    public class USUARIO
    {
        private MP_USUARIO mp = new MP_USUARIO();

        public bool Registrar(BE.USUARIO usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario.Nombre) || string.IsNullOrWhiteSpace(usuario.Contrasena))
            {
                return false;
            }

            List<BE.USUARIO> lista = mp.Listar();
            foreach (BE.USUARIO u in lista)
            {
                if (u.Nombre.Equals(usuario.Nombre.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    return false;
                }
            }

            usuario.Nombre = usuario.Nombre.Trim();
            int filas = mp.Insertar(usuario);
            return filas > 0;
        }

        public BE.USUARIO Login(string nombre, string contrasena)
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(contrasena))
            {
                return null;
            }
            return mp.Login(nombre.Trim(), contrasena);
        }

        public List<BE.USUARIO> Listar()
        {
            return mp.Listar();
        }

        public void ActualizarEstadisticas(BE.USUARIO usuario)
        {
            mp.ActualizarEstadisticas(usuario);
        }

        public void RegistrarResultadoPartida(BE.USUARIO j1, BE.USUARIO j2, int idGanador, int duracionSegundos)
        {
            j1.SegundosJugados += duracionSegundos;
            j2.SegundosJugados += duracionSegundos;

            if (idGanador == 0)
            {
                j1.Empatadas += 1;
                j2.Empatadas += 1;
            }
            else if (idGanador == j1.Id)
            {
                j1.Ganadas += 1;
                j2.Perdidas += 1;
            }
            else
            {
                j2.Ganadas += 1;
                j1.Perdidas += 1;
            }

            mp.ActualizarEstadisticas(j1);
            mp.ActualizarEstadisticas(j2);
        }
    }
}

