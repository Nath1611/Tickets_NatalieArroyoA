using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tickets_NatalieArroyoA.Formularios
{
    public partial class FrmClienteBuscar : Form
    {
        Logica.Models.Cliente MiCliente { get; set; }
        public DataTable DTLista { get; set; }

        public FrmClienteBuscar()
        {
            InitializeComponent();
            MiCliente = new Logica.Models.Cliente();
            DTLista = new DataTable();
        }

        private void LlenarListaClientes(string Filtro = "")
        {
            DTLista = new DataTable();

            DTLista = MiCliente.ListarActivos(Filtro);

            DgvLista.DataSource = DTLista;

        }

        private void FrmClienteBuscar_Load(object sender, EventArgs e)
        {
            LlenarListaClientes();
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (DgvLista.Rows.Count == 1 && DgvLista.SelectedRows.Count == 1)
            {
                int IdCliente = Convert.ToInt32(DgvLista.SelectedRows[0].Cells["CIDCliente"]);

                string Cliente = Convert.ToString(DgvLista.SelectedRows[0].Cells["CNombre"]);

                //Una vez que he capturado la infro necesario de las columnas del DGV, puedo
                //pasar estos datos al objeto local MiTicket

                Commons.ObjetosGlobales.FormCrearTicket.MiTicket.MiCliente.IDCliente = IdCliente;
                Commons.ObjetosGlobales.FormCrearTicket.MiTicket.MiCliente.Nombre = Cliente;

                //esto cierra el form y retorna una respuesta al formulario que lo invocó
                this.DialogResult = DialogResult.OK;



            }
        }
    }
}
