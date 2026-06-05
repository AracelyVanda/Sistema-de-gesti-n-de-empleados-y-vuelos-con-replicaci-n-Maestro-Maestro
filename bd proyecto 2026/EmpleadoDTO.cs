using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bd_proyecto_2026
{
    public class EmpleadoDTO
    {
        private long idEmpleado;
        private string nombre;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private DateTime fechaNacimiento;
        private char sexo;
        private string rfc;
        private string telefono;
        private byte estatus;
        private double sueldo;
        private string area;


        public long IdEmpleado
        {
            set { idEmpleado = value; }
            get { return idEmpleado; }
        }

        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public string ApellidoPaterno
        {
            set { apellidoPaterno = value; }
            get { return apellidoPaterno; }
        }

        public string ApellidoMaterno
        {
            set { apellidoMaterno = value; }
            get { return apellidoMaterno; }
        }

        public DateTime FechaNacimiento
        {
            set { fechaNacimiento = value; }
            get { return fechaNacimiento; }
        }

        public char Sexo
        {
            set { sexo = value; }
            get { return sexo; }
        }

        public string Rfc
        {
            set { rfc = value; }
            get { return rfc; }
        }

        public string Telefono
        {
            set { telefono = value; }
            get { return telefono; }
        }

        public byte Estatus
        {
            set { estatus = value; }
            get { return estatus; }
        }

        public double Sueldo
        {
            set { sueldo = value; }
            get { return sueldo; }
        }

        public string Area
        {
            set { area = value; }
            get { return area; }
        }
    }
}
