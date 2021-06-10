using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNV_Inventario.MVCController
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
        string vendedor;

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

        public string Vendedor
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

        public Oportunidades(string nombrecliente, DateTime fechacierre, string marca, string detalles, int presupuesto, string vendedor)
        {
            this.Nombrecliente = nombrecliente;
            this.Fechacierre = fechacierre;
            this.Marca = marca;
            this.Detalles = detalles;
            this.Presupuesto = presupuesto;
            this.Vendedor = vendedor;
        }
        public Oportunidades()
        {
            this.Nombrecliente = "";
            this.Fechacierre = DateTime.Today;
            this.Marca = "";
            this.Detalles = "";
            this.Presupuesto = 0;
            this.Vendedor = "";
        }
    }
}
