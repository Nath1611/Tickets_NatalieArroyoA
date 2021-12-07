using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Logica.Models
{
    public class Cliente : ICrudBase, IPersona
    {
        //IPersona
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public bool Activo { get; set; }

        //ICrudBase
        public bool Agregar()
        {
            throw new NotImplementedException();
        }

        public bool Editar()
        {
            throw new NotImplementedException();
        }

        public bool Eliminar()
        {
            throw new NotImplementedException();
        }

        //Atributos que no estaban en las interfaces, atributos específicos
        public int IDCliente { get; set; }
        public string Direccion { get; set; }
        public bool EnviarPromos { get; set; }

        //Analiza si hay atrributos compuestos y se agregan
        public ClienteCategoria MiCategoria { get; set; }


        //Cuando hay atributos compuestos es necesario instanciarlos en el constructor
        public Cliente()
        {
            MiCategoria = new ClienteCategoria();
        }
        
        //Funciones que no estaban en las interfaces, funciones especificas de la clase
        bool ConsultarPorID(int ID)
        {
            bool R = false;

            return R;
        }

        bool ConsultarPorCedula(string Cedula)
        {
            bool R = false;

            return R;
        }

        public DataTable ListarActivos(string filtro = ".")
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@filtro", filtro));

            R = MiCnn.DMLSelect("SPClienteBuscar");



            return R;
        }
        public DataTable ListarInactivos()
        {
            DataTable R = new DataTable();

            return R;
        }


    }
}
