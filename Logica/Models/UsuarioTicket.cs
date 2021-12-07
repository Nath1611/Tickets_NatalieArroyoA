using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class UsuarioTicket
    {
        public DateTime FechaHoraInicio { get; set; }
        public DateTime FechaHoraFin { get; set; }
        public string AnotacionDelusuario { get; set; }

        public Usuario MiUsuario { get; set; }

        public UsuarioTicket()
        {
            MiUsuario = new Usuario();

        }

        public bool IniciarAtencionTicket(int IDUsuarioQueAtiende)
        {
            bool R = false;

            return R;
        }
        public bool EstablecerComentarioDeusuario(int IDUsuario, string Comentario)
        {
            bool R = false;

            return R;
        }
        public bool FinalizarAtencionTicket(int IDUsuarioQueAtiende)
        {
            bool R = false;

            return R;
        }
    }
}
