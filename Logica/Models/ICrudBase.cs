using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    //es para encapsular los metodos que comparten las clases (Usuariorol, Cliente, Usuario)

    //se llama ICrudBase, la I es de Interfaz
    internal interface ICrudBase
    {

        //esta Interfaz obliga a las clases que la implementen a cumplir 
        //el contrato de estructura que está escrito aquí
        bool Agregar();
        bool Editar();
        bool Eliminar();


    }
}
