using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Logica.Models
{
    public class Ticket
    {
        public int IDTicket { get; set; }
        public int IDTicketCategoria { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaHoraInicio { get; set; }
        public DateTime FechHoraFin { get; set; }
        public string TicketTitulo { get; set; }
        public string TicketDescripcion { get; set; }
        public int CantidadTiempo { get; set; }
        public bool Pagado { get; set; }
        public bool Activo { get; set; }

        //CONSTRUCTOR
        public Ticket()
        {
            CantidadTiempo = 0;

            MiCategoria = new TicketCategoria();
            MiCliente = new Cliente();
            MiListaDeUsuarios = new List<UsuarioTicket>();
        }

        //Esta clase es la más complicada con respecto a las composiciones
        public TicketCategoria  MiCategoria { get; set; }
        public Cliente MiCliente { get; set; }
        //Composicion múltiple
        public List<UsuarioTicket> MiListaDeUsuarios { get; set; }

        //FUNCIONES
        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@IDCliente", this.MiCliente.IDCliente));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@IDCategoria", this.MiCategoria.IDTicketCategoria));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Descripcion", this.TicketDescripcion));

            int i = MiCnn.DMLUpdateDeleteInsert("SPTicketAgregar");

            if (i > 0)
            {
                R = true;
            }


            return R;
        }
        public bool Eliminar()
        {
            bool R = false;

            return R;
        }
        public bool IniciarTicket()
        {
            bool R = false;

            return R;
        }
        public bool FinalizarTicket()
        {
            bool R = false;

            return R;
        }
        public bool EstablecerPagado()
        {
            bool R = false;

            return R;
        }
    }
}
