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
    public partial class FrmUsuarioRecuperarContrasennia : Form
    {
        public Logica.Email MyEmail { get; set; }
        public Logica.Models.Usuario MyUser { get; set; }

        public FrmUsuarioRecuperarContrasennia()
        {
            InitializeComponent();

            MyEmail = new Logica.Email();
            MyUser = new Logica.Models.Usuario();

        }

        private void FrmUsuarioRecuperarContrasennia_Load(object sender, EventArgs e)
        {
            TxtCodigoEnviado.Enabled = false;
            TxtPass1.Enabled = false;
            TxtPass2.Enabled = false;
            BtnAceptar.Enabled = false;

            TxtCodigoEnviado.Clear();
            TxtPass1.Clear();
            TxtPass2.Clear();


        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnEnviarCodigo_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (!string.IsNullOrEmpty(TxtUsuario.Text.Trim()) && Commons.ObjetosGlobales.ValidarEmail(TxtUsuario.Text.Trim()))
                {
                    MyUser.Email = TxtUsuario.Text.Trim();

                    if (MyUser.ConsultarPorEmail())
                    {
                        //Si el correo existe para un usuario, se procede a enviar el correo con un 
                        //código de verificsción que ele usuario deberá digitar para comprobar que sea él

                        //este código debe generar aleatoriamente

                        string CodigoRecuperacion = "ABC123*";

                        if (MyUser.EnviarCodigoRecuperacion(CodigoRecuperacion))
                        {
                            //se procede a enviar el correo al usuario con el código
                            MyEmail.Asunto = "Su código de recuperación de contraseña de Tickets Progra 5 2021-3";

                            MyEmail.CorreoDestino = MyUser.Email;

                            string Mensaje = string.Format("Su código de recuperación de contraseña es: {0}", CodigoRecuperacion);

                            MyEmail.Mensaje = Mensaje;

                            if (MyEmail.EnviarCorreo_Net_Mail_SmtpClient())
                            {
                                MessageBox.Show("Correo enviado correctamente", "c:", MessageBoxButtons.OK);

                                TxtCodigoEnviado.Enabled = true;
                                TxtPass1.Enabled = true;
                                TxtPass2.Enabled = true;
                                BtnAceptar.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("El correo no se pudo enviar", ":c", MessageBoxButtons.OK);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("El correo no existe o el usuario está desactivado", "Error de validación", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            //1. Se debe verificar que el codigo verificado sea el mismo que está almacenado en la tabla usuario
            //2. Las contraseñas deben ser las mismas
            //3. Se procede con el cambio de contraseñas

            if (!string.IsNullOrEmpty(TxtCodigoEnviado.Text.Trim()) && ValidarContrasennias())
            {
                //el dato del email ya se había asignado en el proceso de enviar el email al usuario
                MyUser.CodigoRecuperacion = TxtCodigoEnviado.Text.Trim();
                MyUser.Contrasennia = TxtPass1.Text.Trim();

                if (MyUser.ComprobarCodigoRecuperacion())
                {
                    //se tiene permiso de modificar la contraseña
                    if (MyUser.CambiarPassword())
                    {
                        MessageBox.Show("La contraseña se ha actualizado correctamente", "c:", MessageBoxButtons.OK);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar la contraseña", ":c", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("El código de verificación digitado no es correcto", "Error de validación", MessageBoxButtons.OK);
                    //TxtCodigoEnviado.BackColor = Color.Red;- //Para cambiar de color si está incorrecto
                }
            }
        }

        private bool ValidarContrasennias()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtPass1.Text.Trim()) && !string.IsNullOrEmpty(TxtPass2.Text.Trim()) && TxtPass1.Text.Trim() == TxtPass2.Text.Trim())
            {
                R = true;
            }
            else
            {
                if (string.IsNullOrEmpty(TxtPass1.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar la contraseña", "Error de validación", MessageBoxButtons.OK);
                    TxtPass1.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(TxtPass2.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar la contraseña", "Error de validación", MessageBoxButtons.OK);
                    TxtPass2.Focus();
                    return false;
                }
                if (!string.IsNullOrEmpty(TxtPass1.Text.Trim()) && !string.IsNullOrEmpty(TxtPass2.Text.Trim()) && TxtPass1.Text.Trim() != TxtPass2.Text.Trim())
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Error de validación", MessageBoxButtons.OK);
                    TxtPass2.Focus();
                    return false;
                }
            }

            return R;
        }
    }
}
