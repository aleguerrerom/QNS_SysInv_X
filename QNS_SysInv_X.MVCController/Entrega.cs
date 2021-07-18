using System;

namespace QNS_SysInv_X.MVCController
{
  public class Entrega
    {
        private string cliente;
        private string numeroDeSerie;
        private DateTime fecha;
        private string contacto;
        private string dirrecion;
        private string cantidad;
        private string descripcion;
        private string entregadoPor;
        private string numeroFactura;
        private string telefono;
        private string numeroDeParte;
        private string usuario;
        private int linea;

        public Entrega(string cliente,string numeroDeSerie, DateTime fecha, string contacto, string dirrecion, string cantidad, string descripcion, string entregadoPor,string numeroFactura, string telefono, string numeroDeParte, string usuario, int linea)
        {
            this.cliente = cliente;
            this.numeroDeSerie = numeroDeSerie;
            this.fecha = fecha;
            this.contacto = contacto;
            this.dirrecion = dirrecion;
            this.cantidad = cantidad;
            this.descripcion = descripcion;
            this.entregadoPor = entregadoPor;
            this.numeroFactura = numeroFactura;
            this.telefono = telefono;
            this.numeroDeParte = numeroDeParte;
            this.usuario = usuario;
            this.linea = linea;
        }

        public Entrega()
        {
            this.cliente = "";
            this.numeroDeSerie = "";
            this.fecha = DateTime.Today;
            this.contacto = "";
            this.dirrecion = "";
            this.cantidad = "";
            this.descripcion = "";
            this.entregadoPor = "";
            this.numeroFactura = "";
            this.telefono = "";
            this.numeroDeParte = "";
            this.usuario = "";
        }

        public string NumeroDeSerie
        {
            get
            {
                return numeroDeSerie;
            }

            set
            {
                numeroDeSerie = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
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

        public string Dirrecion
        {
            get
            {
                return dirrecion;
            }

            set
            {
                dirrecion = value;
            }
        }

        public string Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }

        public string NumeroFactura
        {
            get
            {
                return numeroFactura;
            }

            set
            {
                numeroFactura = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public string EntregadoPor
        {
            get
            {
                return entregadoPor;
            }

            set
            {
                entregadoPor = value;
            }
        }
        public string Cliente
        {
            get
            {
                return cliente;
            }

            set
            {
                cliente = value;
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
        public string NumeroDeParte
        {
            get
            {
                return numeroDeParte;
            }

            set
            {
                numeroDeParte = value;
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
        public int Linea
        {
            get
            {
                return linea;
            }

            set
            {
                linea = value;
            }
        }
    }
}
