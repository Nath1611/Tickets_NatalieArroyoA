using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class ClienteCategoria
    {
        //hay varias formas dar usar los atributos de una clase, esta es auto-implementacion
        private int IDClienteCategoria { get; set; }
        private string ClienteCategoriaDescripcion { set; get; }

        /*Esta otra forma es muy usual en Java, esta es full
         * private int MyVar;
         * public int MyProperty
         * {
         *   get{ return MyVar;}
         *   set{ MyVar = value;}
         * }
         */

        //Luego de escribir los atributos, siguen las funciones y métodos
        public DataTable Listar()
        {

            DataTable R = new DataTable();

            //Aqui va la funcionalidad para obtener la DATA desde la BD por medio de un SP (procedimiento almacenado)

            return R;
        }
    }
}
