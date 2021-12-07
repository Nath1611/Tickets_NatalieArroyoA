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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void TmrHora_Tick(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            TmrHora.Enabled = true;

            LblUsuarioLogueado.Text = Commons.ObjetosGlobales.MiUsuarioDeSistema.Email;
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //TODO: Analizar si se quiere hacer un LogOut cuando se cierra el principal
            Application.Exit();
        }

        private void gestiónDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Muestra el fromulario global de gestión de usuarios

            Commons.ObjetosGlobales.FormularioGestionUsuarios = new FrmUsuarioGestion();

            Commons.ObjetosGlobales.FormularioGestionUsuarios.Show();

        }

        private void creaciónDeTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Commons.ObjetosGlobales.FormCrearTicket = new FrmTicketCrear();
            Commons.ObjetosGlobales.FormCrearTicket.Show();
        }

        private void soluciónDeTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Commons.ObjetosGlobales.FormAtencion = new FrmAtencionDeTickets();
            Commons.ObjetosGlobales.FormAtencion.Show();
        }
    }
}