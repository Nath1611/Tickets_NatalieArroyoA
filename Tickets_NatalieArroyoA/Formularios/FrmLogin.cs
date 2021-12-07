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
    public partial class FrmLogin : Form
    {
        string MensajeValidacion = "Error de validación";

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //SALIR DE LA APLICACION
            Application.Exit();
        }

        private bool ValidarDatos()
        {

            bool R = false;

            if (!string.IsNullOrEmpty(TxtEmailDelUsuario.Text.Trim()) &&
                Commons.ObjetosGlobales.ValidarEmail(TxtEmailDelUsuario.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtPassword.Text.Trim()))
            {
                R = true;
            }
            else
            {
                if (string.IsNullOrEmpty(TxtEmailDelUsuario.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un email de usuario", MensajeValidacion, MessageBoxButtons.OK);
                    TxtEmailDelUsuario.Focus();
                    return false;
                }
                if (!Commons.ObjetosGlobales.ValidarEmail(TxtEmailDelUsuario.Text.Trim()))
                {
                    MessageBox.Show("El email no tiene el fromato correcto", MensajeValidacion, MessageBoxButtons.OK);
                    TxtEmailDelUsuario.Focus();
                    TxtEmailDelUsuario.SelectAll();
                    return false;
                }
                if (string.IsNullOrEmpty(TxtPassword.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar la contraseña", MensajeValidacion, MessageBoxButtons.OK);
                    TxtPassword.Focus();
                    return false;
                }
            }

            return R;

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                //TODO: Hay que validar que el usuario y la contraseña sean correctos antes de seguir con el FrmPrincipal

                Logica.Models.Usuario MiUsuarioValidado = new Logica.Models.Usuario();

                MiUsuarioValidado = MiUsuarioValidado.ValidarIngreso(TxtEmailDelUsuario.Text.Trim(), TxtPassword.Text.Trim());

                if (MiUsuarioValidado != null && MiUsuarioValidado.IDUsuario > 0)
                {
                    Commons.ObjetosGlobales.MiUsuarioDeSistema = MiUsuarioValidado;

                    //Se muestra el objeto global del FrmMain
                    Commons.ObjetosGlobales.MiFormPrincipal.Show();

                    //Se oculta (NO destruye) el formulario FrmLogin
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Email de usuario o contraseña incorrectoas", MensajeValidacion, MessageBoxButtons.OK);
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            TxtPassword.UseSystemPasswordChar = true;
        }

        private void BtnIngresoDirecto_Click(object sender, EventArgs e)
        {
            Commons.ObjetosGlobales.MiUsuarioDeSistema.IDUsuario = 1;             //ESTOS DATOS SON QUEMADOS SEGUN A LOS USUARIOS YA INGRESADOS EN LA BD
            Commons.ObjetosGlobales.MiUsuarioDeSistema.Email = "a@gmail.com";     //VAN CONFORME A LOS USUARIOS YA AGREGADOS
            Commons.ObjetosGlobales.MiUsuarioDeSistema.Nombre = "USUARIO DE PRUEBAS";
            Commons.ObjetosGlobales.MiUsuarioDeSistema.MiRol.IDUsuarioRol = 1;

            //Se muestra el objeto global del FrmMain
            Commons.ObjetosGlobales.MiFormPrincipal.Show();

            //Se oculta (NO destruye) el formulario FrmLogin
            this.Hide();
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift & e.KeyCode == Keys.Escape) //Shift + esc (escape) //esta combinación de teclas puede ser cualquier otra
            {
                BtnIngresoDirecto.Visible = true;
            }

            if (true)
            {

            }
        }

        private void LblRecuperarContrasennia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Commons.ObjetosGlobales.FormularioRecuperarContrasennia.TxtUsuario.Text = TxtEmailDelUsuario.Text.Trim();

            Commons.ObjetosGlobales.FormularioRecuperarContrasennia.Show();
        }
    }
}
