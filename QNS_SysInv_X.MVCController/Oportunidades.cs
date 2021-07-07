using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QNS_SysInv_X.MVCController
{
   public class Oportunidades
    {

        public int opc
        {
            get; set;
        }
        string nombrecliente;
        DateTime fechacierre;
        string marca;
        string detalles;
        int presupuesto;
        int vendedor;
        int id;

        public string Nombrecliente
        {
            get
            {
                return nombrecliente;
            }

            set
            {
                nombrecliente = value;
            }
        }

        public DateTime Fechacierre
        {
            get
            {
                return fechacierre;
            }

            set
            {
                fechacierre = value;
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

        public string Detalles
        {
            get
            {
                return detalles;
            }

            set
            {
                detalles = value;
            }
        }

        public int Presupuesto
        {
            get
            {
                return presupuesto;
            }

            set
            {
                presupuesto = value;
            }
        }

        public int Vendedor
        {
            get
            {
                return vendedor;
            }

            set
            {
                vendedor = value;
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

        public Oportunidades(string nombrecliente, DateTime fechacierre, string marca, string detalles, int presupuesto, int vendedor, int id)
        {
            this.Nombrecliente = nombrecliente;
            this.Fechacierre = fechacierre;
            this.Marca = marca;
            this.Detalles = detalles;
            this.Presupuesto = presupuesto;
            this.Vendedor = vendedor;
            this.Id = id;
        }
        public Oportunidades()
        {
            this.Nombrecliente = "";
            this.Fechacierre = DateTime.Today;
            this.Marca = "";
            this.Detalles = "";
            this.Presupuesto = 0;
            this.Vendedor = 0;
            this.Id = 0;
        }
    }
}
