using System;

namespace QNS_SysInv_X.MVCController
{
  public class Entrega
    {
        private int opc;
        private string cliente;
        private int id;
        private string tipo;
        private string numeroDeSerie;
        private string marca;
        private DateTime fecha;
        private string contacto;
        private string dirrecion;
        private int cantidad;
        private string descripcion;
        private string entregadoPor;

        public Entrega(int opc, string cliente, int id, string tipo, string numeroDeSerie, string marca, DateTime fecha, string contacto, string dirrecion, int cantidad, string descripcion, string entregadoPor)
        {
            this.opc = opc;
            this.cliente = cliente;
            this.id = id;
            this.tipo = tipo;
            this.numeroDeSerie = numeroDeSerie;
            this.marca = marca;
            this.fecha = fecha;
            this.contacto = contacto;
            this.dirrecion = dirrecion;
            this.cantidad = cantidad;
            this.descripcion = descripcion;
            this.entregadoPor = entregadoPor;
        }

        public Entrega()
        {
            this.opc = 0;
            this.cliente = "";
            this.id = 0;
            this.tipo = "";
            this.numeroDeSerie = "";
            this.marca = "";
            this.fecha = DateTime.Today;
            this.contacto = "";
            this.dirrecion = "";
            this.cantidad = 0;
            this.descripcion = "";
            this.entregadoPor = "";
        }

        public int Opc
        {
            get
            {
                return opc;
            }

            set
            {
                opc = value;
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

        public int Cantidad
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
    }
}
