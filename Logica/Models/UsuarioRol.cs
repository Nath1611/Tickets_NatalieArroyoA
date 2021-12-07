using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    //los dos puntos son para ligar esta clase (USUARIOROL) con la interfaz (ICRUDBASE)
    public class UsuarioRol : ICrudBase
    {
        public int IDUsuarioRol { get; set; }
        public string UsuarioRolDescripcion { get; set; }

        //Estas funciones deben cumplir el contrato escrito en la interfaz ICrudBase
        public bool Agregar()
        {
            //throw new NotImplementedException();

            bool R = false;

            return R;
        }

        public bool Editar()
        {
            bool R = false;

            return R;
        }

        public bool Eliminar()
        {
            bool R = false;

            return R;
        }

        //Las siguientes funciones son las especificas y no están en el ICrudBase
        //No son comunes en las demás clases

        bool ConsultarPorID()
        {
            bool R = false;

            return R;
        }

        bool ConsultarPorNombre()
        {
            bool R = false;

            return R;
        }

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            //SEQ: SDUsuarioRolListar
            //SDUsuarioRolListar 2.1 y 2.2
            Conexion MiConexion = new Conexion();

            //SDUsuarioRolListar 2.3
            R = MiConexion.DMLSelect("SPUsuarioRolListar");

            //SDUsuarioRolListar 2.4
            return R;
        }
    }
}
