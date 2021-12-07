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
    public partial class FrmTicketCrear : Form
    {
        public Logica.Models.Ticket MiTicket { get; set; }
        public FrmTicketCrear()
        {
            InitializeComponent();

            MiTicket = new Logica.Models.Ticket();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtIDUsuario_DoubleClick(object sender, EventArgs e)
        {
            FrmClienteBuscar MiFormDeBusqueda = new FrmClienteBuscar();

            DialogResult resp = MiFormDeBusqueda.ShowDialog();

            if (resp == DialogResult.OK)
            {
                TxtIDUsuario.Text = MiTicket.MiCliente.IDCliente.ToString();
                LblClienteNombre.Text = MiTicket.MiCliente.Nombre;
            }
        }

        private void CargarCategorias()
        {
            DataTable Datos = new DataTable();

            Datos = MiTicket.MiCategoria.Listar();

            CboxCategoria.ValueMember = "ID";
            CboxCategoria.DisplayMember = "Descrip";

            CboxCategoria.DataSource = Datos;

            CboxCategoria.SelectedIndex = -1;
        }

        private void FrmTicketCrear_Load(object sender, EventArgs e)
        {
            CargarCategorias();

            LimpiarForm();
        }

        private void LimpiarForm()
        {
            TxtIDUsuario.Clear();
            LblClienteNombre.Text = "";
            TxtTitulo.Clear();
            TxtDescripcion.Clear();
            CboxCategoria.SelectedIndex = -1;

            MiTicket = new Logica.Models.Ticket();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                MiTicket.MiCategoria.IDTicketCategoria = Convert.ToInt32(CboxCategoria.SelectedValue);
                MiTicket.MiCategoria.TicketCategoriaDescripcion = Convert.ToString(CboxCategoria.SelectedValue);

                //MiTicket.FechaCreacion = DateTime.Now.Date;

                MiTicket.TicketTitulo = TxtTitulo.Text.Trim();
                MiTicket.TicketDescripcion = TxtDescripcion.Text.Trim();

                if (MiTicket.Agregar())
                {
                    MessageBox.Show("Ticket agregado correctamente", "c:", MessageBoxButtons.OK);

                    LimpiarForm();

                    //TO DO: implemetar un reporte de crystal para poderlo imprimir y quede
                    //como atestado de creación de ticket

                }
            }
        }
        private bool Validar()
        {
            bool R = false;

            if (MiTicket.MiCliente.IDCliente > 0 && CboxCategoria.SelectedIndex > -1 &&
                !string.IsNullOrEmpty(TxtTitulo.Text.Trim()) && !string.IsNullOrEmpty(TxtDescripcion.Text.Trim()))
            {
                R = true;
            }
            else
            {
                if (MiTicket.MiCliente.IDCliente == 0)
                {
                    MessageBox.Show("Debe selccionar un cliente", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }
                if (CboxCategoria.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe selccionar una categoría para el ticket", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }
                if (string.IsNullOrEmpty(TxtTitulo.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un título para el ticket", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }
                if (string.IsNullOrEmpty(TxtDescripcion.Text.Trim()))
                {
                    MessageBox.Show("Debe introducir una descripción para el ticket", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }
            }

            return R;
        }
    }
}
