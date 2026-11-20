using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace BLL
{
    public class XML_PARTIDA
    {
        public string GuardarMovimientos(BE.PARTIDA partida, List<BE.MOVIMIENTO> movimientos)
        {
            string carpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PartidasXML");
            try
            {
                if (!Directory.Exists(carpeta))
                {
                    Directory.CreateDirectory(carpeta);
                }
            }
            catch
            {
                carpeta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "BatallaNaval_XML");
                if (!Directory.Exists(carpeta))
                {
                    Directory.CreateDirectory(carpeta);
                }
            }

            string nombreArchivo = string.Format("Partida_{0:yyyyMMdd_HHmmss}.xml", DateTime.Now);
            string rutaCompleta = Path.Combine(carpeta, nombreArchivo);

            XmlDocument doc = new XmlDocument();
            XmlDeclaration decl = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(decl);

            XmlElement raiz = doc.CreateElement("PartidaBatallaNaval");
            raiz.SetAttribute("Fecha", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            raiz.SetAttribute("Jugador1", partida.NombreJugador1 ?? "");
            raiz.SetAttribute("Jugador2", partida.NombreJugador2 ?? "");
            raiz.SetAttribute("Ganador", partida.NombreGanador ?? "");
            raiz.SetAttribute("DuracionSegundos", partida.DuracionSegundos.ToString());
            doc.AppendChild(raiz);

            XmlElement nodoMovs = doc.CreateElement("Movimientos");
            raiz.AppendChild(nodoMovs);

            foreach (BE.MOVIMIENTO m in movimientos)
            {
                XmlElement nodo = doc.CreateElement("Movimiento");
                nodo.SetAttribute("Turno", m.NumeroTurno.ToString());
                nodo.SetAttribute("FechaHora", m.FechaHora.ToString("yyyy-MM-dd HH:mm:ss"));
                nodo.SetAttribute("Jugador", m.Jugador ?? "");
                nodo.SetAttribute("Fila", m.Fila.ToString());
                nodo.SetAttribute("Columna", m.Columna.ToString());
                nodo.SetAttribute("Coordenada", m.Coordenada ?? "");
                nodo.SetAttribute("Resultado", m.Resultado ?? "");
                nodo.SetAttribute("NaveAfectada", m.NaveAfectada ?? "");
                nodoMovs.AppendChild(nodo);
            }

            doc.Save(rutaCompleta);
            return rutaCompleta;
        }

        public List<BE.MOVIMIENTO> LeerMovimientos(string rutaArchivo)
        {
            List<BE.MOVIMIENTO> lista = new List<BE.MOVIMIENTO>();

            if (string.IsNullOrWhiteSpace(rutaArchivo) || !File.Exists(rutaArchivo))
            {
                return lista;
            }

            XmlDocument doc = new XmlDocument();
            doc.Load(rutaArchivo);

            XmlNodeList nodos = doc.SelectNodes("//PartidaBatallaNaval/Movimientos/Movimiento");
            if (nodos == null) return lista;

            foreach (XmlNode nodo in nodos)
            {
                BE.MOVIMIENTO m = new BE.MOVIMIENTO();
                if (nodo.Attributes["Turno"] != null)
                    m.NumeroTurno = int.Parse(nodo.Attributes["Turno"].Value);
                if (nodo.Attributes["FechaHora"] != null)
                    m.FechaHora = DateTime.Parse(nodo.Attributes["FechaHora"].Value);
                if (nodo.Attributes["Jugador"] != null)
                    m.Jugador = nodo.Attributes["Jugador"].Value;
                if (nodo.Attributes["Fila"] != null)
                    m.Fila = int.Parse(nodo.Attributes["Fila"].Value);
                if (nodo.Attributes["Columna"] != null)
                    m.Columna = int.Parse(nodo.Attributes["Columna"].Value);
                if (nodo.Attributes["Coordenada"] != null)
                    m.Coordenada = nodo.Attributes["Coordenada"].Value;
                if (nodo.Attributes["Resultado"] != null)
                    m.Resultado = nodo.Attributes["Resultado"].Value;
                if (nodo.Attributes["NaveAfectada"] != null)
                    m.NaveAfectada = nodo.Attributes["NaveAfectada"].Value;

                lista.Add(m);
            }

            return lista;
        }
    }
}
