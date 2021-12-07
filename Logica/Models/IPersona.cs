using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public interface IPersona
    {
        string Cedula { get; set; }
        string Nombre { get; set; }
        string Telefono { get; set; }
        string Email { get; set; }
        bool Activo { get; set; }
    }
}
