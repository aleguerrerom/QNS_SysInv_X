using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QNS_SysInv_X.MVCController
{
    public class Respaldos
    {

        public int opc
        {
            get; set;
        }
        private string nombre;
        private string directorio;
        private byte [] doc;

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

        public string Directorio
        {
            get
            {
                return directorio;
            }

            set
            {
                directorio = value;
            }
        }

        public byte[] Doc
        {
            get
            {
                return doc;
            }

            set
            {
                doc = value;
            }
        }

        public Respaldos(string nombre, string directorio, byte[] doc)
        {
            this.Nombre = nombre;
            this.Directorio = directorio;
            this.Doc = doc;
        }


        public Respaldos()
        {
            this.Nombre = "";
            this.Directorio = "";
            
        }
    }
}
