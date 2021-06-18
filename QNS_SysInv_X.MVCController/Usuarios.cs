
namespace QNS_SysInv_X.MVCController
{

    public class Usuarios
        {

            public int opc
            {
                get; set;
            }
            private string usuario;
            private string clave;
            private bool activo;
            private int rol;
            private string nombre;
            private string apellido;
        private string correo;
            
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

            public string Clave
            {
                get
                {
                    return clave;
                }

                set
                {
                    clave = value;
                }
            }

            
            
            public bool Activo
            {
                get
                {
                    return activo;
                }

                set
                {
                    activo = value;
                }
            }

            public int Rol
            {
                get
                {
                    return rol;
                }

                set
                {
                    rol = value;
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

            public string Apellido
            {
                get
                {
                    return apellido;
                }

                set
                {
                    apellido = value;
                }
            }

        public string Correo
        {
            get
            {
                return correo;
            }

            set
            {
                correo = value;
            }
        }

        public Usuarios(string usuario, string clave, bool activo, int rol, string nombre, string apellido, string correo)
            {
                this.Usuario = usuario;
                this.Clave = clave;
               this.Activo = activo;
                this.Rol = rol;
                this.Nombre = nombre;
                this.Apellido = apellido;
            this.Correo = correo;
     
            }

            public Usuarios()
            {
                this.Usuario = "";
                this.Clave = "";
                this.Activo = true;
                this.Rol = 0;
                this.nombre = "";
                this.clave = "";
            this.correo = "";
            }
        }
    }


