using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bd_proyecto_2026
{
    public class VueloDTO
    {
        private long idVuelo;
        private string origen;
        private string destino;
        private int noAsientos;
        private double precio;
        private DateTime fechaInicio;
        private DateTime fechaLlegada;
        private byte estatus;

        

        public long IdVuelo
        {
            set { idVuelo = value; }
            get { return idVuelo; }
        }

        public string Origen
        {
            set { origen = value; }
            get { return origen; }
        }

        public string Destino
        {
            set { destino = value; }
            get { return destino; }
        }

        public int NoAsientos
        {
            set { noAsientos = value; }
            get { return noAsientos; }
        }

        public double Precio
        {
            set { precio = value; }
            get { return precio; }
        }

        public DateTime FechaInicio
        {
            set { fechaInicio = value; }
            get { return fechaInicio; }
        }

        public DateTime FechaLlegada
        {
            set { fechaLlegada = value; }
            get { return fechaLlegada; }
        }

        public byte Estatus
        {
            set { estatus = value; }
            get { return estatus; }
        }

    }
}
