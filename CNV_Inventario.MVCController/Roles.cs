namespace CNV_Inventario.MVCController
{
    public class Roles
    {
        public int opc
        {
            get; set;
        }

        private string nombre;
        private bool inventario;
        private bool usuarios;
        private bool prestamo;
        private bool entrega;
        private bool roless;

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
        

        public Roles(string nombre, bool inventario, bool usuarios, bool prestamo, bool entrega, bool roless)
        {
            this.Nombre = nombre;
            this.Inventario = inventario;
            this.Usuarios = usuarios;
            this.Prestamo = prestamo;
            this.Entrega = entrega;
            this.Roless = roless;
        }
        public Roles()
        {
            this.Nombre = "";
            this.Inventario = true;
            this.Usuarios = true;
            this.Prestamo = true;
            this.Entrega = true;
            this.Roless = true;
        }
    }
}