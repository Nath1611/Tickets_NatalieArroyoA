using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class TicketCategoria
    {
        //ATRIBUTOS:
        public int IDTicketCategoria { get; set; }
        public string TicketCategoriaDescripcion { get; set; }

        //COMPORTAMIENTOS
        public DataTable Listar()
        {
            DataTable R = new DataTable();
            
            Conexion MiConexion = new Conexion();

            R = MiConexion.DMLSelect("SPTicketCategoriaListar");

            return R;
        }
    }
}
