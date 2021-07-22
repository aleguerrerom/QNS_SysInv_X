
using System;

namespace QNS_SysInv_X.MVCController
{
    public class Prestamos
    {
        private int id_articulo;
        private int id_cliente;
        private string contacto;
        private string telefono;
        private string direcicon;
        private string nombre;
        private string cedula;
        private int id;
        private string nombreArticulo;
        private string tipo;
        private string numerodeSerie;
        private string marca;
        private string modelo;
        private string estado;
        private DateTime fecha;

        public int opc
        {
            get; set;
        }
        public Prestamos( int id_articulo, int id_cliente, string contacto, string telefono, string direcicon, string nombre,string cedula, int id, string nombreArticulo, string tipo, string numerodeSerie, string marca, string modelo, string estado, DateTime fecha)
        {
            this.id_articulo = id_articulo;
            this.id_cliente = id_cliente;
            this.contacto = contacto;
            this.telefono = telefono;
            this.direcicon = direcicon;
            this.nombre = nombre;
            this.cedula = cedula;
            this.id = id;
            this.nombreArticulo = nombreArticulo;
            this.tipo = tipo;
            this.numerodeSerie = numerodeSerie;
            this.marca = marca;
            this.modelo = modelo;
            this.estado = estado;
            this.fecha = fecha;
        }

        public Prestamos()
        {
            this.id_articulo = 0;
            this.id_cliente = 0;
            this.contacto = "";
            this.telefono = "";
            this.direcicon = "";
            this.nombre = "";
            this.cedula = "";
            this.id = 0;
            this.nombreArticulo = "";
            this.tipo = "";
            this.numerodeSerie = "";
            this.marca = "";
            this.modelo = "";
            this.estado = "";
            this.fecha = DateTime.Today;
        }
        

        public int Id_articulo
        {
            get
            {
                return id_articulo;
            }

            set
            {
                id_articulo = value;
            }
        }

        public int Id_cliente
        {
            get
            {
                return id_cliente;
            }

            set
            {
                id_cliente = value;
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

        public string Direcicon
        {
            get
            {
                return direcicon;
            }

            set
            {
                direcicon = value;
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

        public string Cedula
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

        public string NombreArticulo
        {
            get
            {
                return nombreArticulo;
            }

            set
            {
                nombreArticulo = value;
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

        public string NumerodeSerie
        {
            get
            {
                return numerodeSerie;
            }

            set
            {
                numerodeSerie = value;
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
    }
}
