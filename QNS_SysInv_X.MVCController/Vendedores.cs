using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QNS_SysInv_X.MVCController
{
    public class Vendedores
    {
        public int opc
        {
            get; set;
        }
        int cedula;
        string nombre;
        string apellido1;
        string apellido2;
        string genero;
        DateTime fechanacimiento;
        string correo;

        public int Cedula
        {
            get
            {
                return cedula;
            }

            set
            {
                cedula = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Apellido1
        {
            get
            {
                return apellido1;
            }

            set
            {
                apellido1 = value;
            }
        }

        public string Apellido2
        {
            get
            {
                return apellido2;
            }

            set
            {
                apellido2 = value;
            }
        }

        public string Genero
        {
            get
            {
                return genero;
            }

            set
            {
                genero = value;
            }
        }

        public DateTime Fechanacimiento
        {
            get
            {
                return fechanacimiento;
            }

            set
            {
                fechanacimiento = value;
            }
        }

        public string Correo
        {
            get
            {
                return correo;
            }

            set
            {
                correo = value;
            }
        }

        public Vendedores(int cedula, string nombre, string apellido1, string apellido2, string genero, DateTime fechanacimiento, string correo)
        {
            this.Cedula = cedula;
            this.Nombre = nombre;
            this.Apellido1 = apellido1;
            this.Apellido2 = apellido2;
            this.Genero = genero;
            this.Fechanacimiento = fechanacimiento;
            this.Correo = correo;
        }
        public Vendedores() { 
            this.Cedula = 0;
            this.Nombre = "";
            this.Apellido1 = "";
            this.Apellido2 = "";
            this.Genero = "";
            this.Fechanacimiento = DateTime.Today;
            this.Correo = "";
        }
    
}
}
