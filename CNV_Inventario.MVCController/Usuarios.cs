using System;

namespace CNV_Inventario.MVCController
{

    public class Usuarios
        {

            public int opc
            {
                get; set;
            }
            private string usuario;
            private string clave;
            private Boolean activo;
            private string rol;
            private string nombre;
            private string apellido;

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

            
            
            public Boolean Activo
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

            public string Rol
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

            public Usuarios(string usuario, string clave, Boolean activo, string rol, string nombre, string apellido)
            {
                this.Usuario = usuario;
                this.Clave = clave;
                this.Activo = activo;
                this.Rol = rol;
                this.Nombre = nombre;
                this.Apellido = apellido;
     
            }

            public Usuarios()
            {
                this.Usuario = "";
                this.Clave = "";
                this.Activo = true;
                this.Rol = "";
                this.nombre = "";
                this.clave = "";
            }
        }
    }


