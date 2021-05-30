namespace CNV_Inventario.MVCController
{
    public class Roles
    {
        public int opc
        {
            get; set;
        }

        public int ID1
        {
            get
            {
                return ID;
            }

            set
            {
                ID = value;
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

        public bool Inventario
        {
            get
            {
                return inventario;
            }

            set
            {
                inventario = value;
            }
        }

        public bool Usuarios
        {
            get
            {
                return usuarios;
            }

            set
            {
                usuarios = value;
            }
        }

        public bool Prestamo
        {
            get
            {
                return prestamo;
            }

            set
            {
                prestamo = value;
            }
        }

        public bool Entrega
        {
            get
            {
                return entrega;
            }

            set
            {
                entrega = value;
            }
        }

        public bool Roless
        {
            get
            {
                return roless;
            }

            set
            {
                roless = value;
            }
        }

        public bool Bitacora
        {
            get
            {
                return bitacora;
            }

            set
            {
                bitacora = value;
            }
        }

        private int ID;
        private string nombre;
        private bool inventario;
        private bool usuarios;
        private bool prestamo;
        private bool entrega;
        private bool roless;
        private bool bitacora;


        
        public Roles()
        {
            this.ID = 0;
            this.Nombre = "";
            this.Inventario = true;
            this.Usuarios = true;
            this.Prestamo = true;
            this.Entrega = true;
            this.Roless = true;
            this.Bitacora = true;
        }

        public Roles(int iD, string nombre, bool inventario, bool usuarios, bool prestamo, bool entrega, bool roless, bool bitacora)
        {
            ID1 = iD;
            this.Nombre = nombre;
            this.Inventario = inventario;
            this.Usuarios = usuarios;
            this.Prestamo = prestamo;
            this.Entrega = entrega;
            this.Roless = roless;
            this.Bitacora = bitacora;
        }
    }
}