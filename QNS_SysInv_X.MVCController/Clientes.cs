using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QNS_SysInv_X.MVCController
{
    public class Clientes
    {
        public int opc
        {
            get; set;
        }
        string tipo;
        string nombre;
        int cedula;
        string contacto;
        string telefono;
        string correo;
        string direccion;
        int agente;

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

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

        public string Contacto
        {
            get
            {
                return contacto;
            }

            set
            {
                contacto = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
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

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public int Agente
        {
            get
            {
                return agente;
            }

            set
            {
                agente = value;
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

        public Clientes(string tipo, int cedula, string contacto, string telefono, string correo, string direccion, int agente, string nombre)
        {
            this.Tipo = tipo;
            this.Cedula = cedula;
            this.Contacto = contacto;
            this.Telefono = telefono;
            this.Correo = correo;
            this.Direccion = direccion;
            this.Agente = agente;
            this.Nombre = nombre;
        }
        public Clientes()
        {
            this.Tipo = "";
            this.Cedula = 0;
            this.Contacto = "";
            this.Telefono ="";
            this.Correo = "";
            this.Direccion = "";
            this.Nombre = "";
            this.Agente = 0;
        }
    }

}
