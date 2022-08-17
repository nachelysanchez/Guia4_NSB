using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia4_NSB
{
    class Conexion
    {
        public string servidor, db, cadena;

        public void conec()
        {
            servidor = "LAPTOP-TN73JHLV\\SQLEXPRESS";
            db = "DB_Avanzada";
            cadena = "Server = " + servidor + "; Database = " + db + ";Integrated Security= true";
        }
    }
}
