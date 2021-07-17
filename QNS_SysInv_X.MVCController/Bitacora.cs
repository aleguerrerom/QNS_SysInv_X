
namespace QNS_SysInv_X.MVCController
{
    public class Bitacora
    {
        public int opc
        {
            get; set;
        }


        private string usuario;
        private string movimiento;
        private string detalle;
      

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

        public string Movimiento
        {
            get
            {
                return movimiento;
            }

            set
            {
                movimiento = value;
            }
        }

        public string Detalle
        {
            get
            {
                return detalle;
            }

            set
            {
                detalle = value;
            }
        }

        public Bitacora(string usuario,string movimiento, string detalle)
        {
            this.Usuario = usuario;
            this.Movimiento = movimiento;
            this.Detalle = detalle;
        }

        public Bitacora()
        {
            this.Usuario = "";
            this.Movimiento = "";
            this.Detalle = "";
        }
    }
}
