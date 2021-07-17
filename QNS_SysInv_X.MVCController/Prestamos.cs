
namespace QNS_SysInv_X.MVCController
{
    public class Prestamos
    {
        private int id_articulo;
        private int id_cliente;
        public int opc
        {
            get; set;
        }
        public Prestamos(int id_articulo, int id_cliente)
        {
            this.id_articulo = id_articulo;
            this.id_cliente = id_cliente;
        }

        public Prestamos()
        {
            this.id_articulo = 0;
            this.id_cliente = 0;
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
    }
}
