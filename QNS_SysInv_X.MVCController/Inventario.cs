using System;

namespace QNS_SysInv_X.MVCController
{
    public class Inventario
    {
        private int id;
        private string Nombre;
        private string tipo;
        private string serialnumber;
        private string marca;
        private string modelo;
        private string estado;
        private DateTime fechamodificacion;
        private string usuario;
        public int opc
        {
            get; set;
        }

        public string Nombre1
        {
            get
            {
                return Nombre;
            }

            set
            {
                Nombre = value;
            }
        }

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

        public string Serialnumber
        {
            get
            {
                return serialnumber;
            }

            set
            {
                serialnumber = value;
            }
        }

        public string Marca
        {
            get
            {
                return marca;
            }

            set
            {
                marca = value;
            }
        }

        public string Modelo
        {
            get
            {
                return modelo;
            }

            set
            {
                modelo = value;
            }
        }

        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public DateTime Fechamodificacion
        {
            get
            {
                return fechamodificacion;
            }

            set
            {
                fechamodificacion = value;
            }
        }

        public string Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public Inventario(string nombre, string tipo, string serialnumber, string marca, string modelo, string estado, DateTime fechamodificacion, string usuario, int id)
        {
            this.Nombre = nombre;
            this.Tipo = tipo;
            this.Serialnumber = serialnumber;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Estado = estado;
            this.Fechamodificacion = fechamodificacion;
            this.Usuario = usuario;
            this.Id = id;
        }

        public Inventario()
        {
            this.Nombre = "";
            this.Tipo = "";
            this.Serialnumber = "";
            this.Marca = "";
            this.Modelo = "";
            this.Estado = "";
            this.Fechamodificacion = DateTime.Today;
            this.Usuario = "";
            this.Id = 0;
        }
    }
}
