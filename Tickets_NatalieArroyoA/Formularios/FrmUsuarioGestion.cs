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
    public partial class FrmUsuarioGestion : Form
    {
        //Este objeto será el que usa para asignar y obtener los valores que se mostrarán
        //en el fromulario (en la parte gráfica), debería contener toda la funcionalidad 
        //que se requiere para cumplir los requerimientos funcionales
        private Logica.Models.Usuario MiUsuarioLocal { get; set; }
        private DataTable ListaUsuarios { get; set; }

        public FrmUsuarioGestion()
        {
            InitializeComponent();

            //Se instancia el objeto local
            //SDUsuarioRolListar 1 y 1.1

            //SDUsuarioAgregar 1.1 y 1.2
            MiUsuarioLocal = new Logica.Models.Usuario();

            ListaUsuarios = new DataTable();
        }

        private void FrmUsuarioGestion_Load(object sender, EventArgs e)
        {
            //Este código se desencadena al mostrar el FORM gráficamente en pantalla
            //primero vamos a llenar la info de los tipos de roles que existen en la BD

            CargarComboRoles();

            //Cargar la lista de ususarios
            LlenarListaUsuarios(CboxVerActivos.Checked);

            LimpiarFormulario();
        }

        private void LlenarListaUsuarios(bool VerActivos, string FiltroBusqueda = "")
        {
            //El cuadro de búsqueda tiene escrita la palabra "Buscar", para no usar un label.
            //Debemos considerar esa palabra como NO VÁLIDA, y cualquier otro texto
            //como válido para el parámetro de búsqueda

            string Filtro = "";

            if (!string.IsNullOrEmpty(FiltroBusqueda) && FiltroBusqueda != "Buscar")
            {
                Filtro = FiltroBusqueda;
            }


            ListaUsuarios = MiUsuarioLocal.Listar(VerActivos, Filtro);

            DgvListaUsuarios.DataSource = ListaUsuarios;

            DgvListaUsuarios.ClearSelection();
        }

        private void CargarComboRoles()
        {
            DataTable DatosDeRoles = new DataTable();

            //SDUsuarioRolListar 2
            DatosDeRoles = MiUsuarioLocal.MiRol.Listar();

            CbRol.ValueMember = "ID";
            CbRol.DisplayMember = "Descrip";

            //SDUsuarioRolListar 2.5
            CbRol.DataSource = DatosDeRoles;

            CbRol.SelectedIndex = -1;
        }

        private bool ValidarDatosRequeridos(bool ValidarPassword = true)
        //esta funcion valida los datos requerisos segun 
        //se diseñó el modelo lógico y físico dde base de datos
        {
            bool R = false;

            if (!string.IsNullOrEmpty(MiUsuarioLocal.Nombre) &&
                !string.IsNullOrEmpty(MiUsuarioLocal.Cedula) &&
                !string.IsNullOrEmpty(MiUsuarioLocal.Email) &&
                MiUsuarioLocal.MiRol.IDUsuarioRol > 0)
            {
                //la contraseña NO se debe validar si estamos en modo de edición y no hemos escrito
                //algo en la contraseña
                if (ValidarPassword && !string.IsNullOrEmpty(MiUsuarioLocal.Contrasennia))
                {
                    //si se cumplen los parámetros de validación se pasa el valor de R a true
                    R = true;
                }
                else
                {
                    //si se cumplen los parámetros de validación se pasa el valor de R a true
                    R = true;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(MiUsuarioLocal.Nombre))
                {
                    MessageBox.Show("Debe digitar el nombre", "Error de validación", MessageBoxButtons.OK);
                    TxtNombre.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(MiUsuarioLocal.Cedula))
                {
                    MessageBox.Show("Debe digitar la cédula", "Error de validación", MessageBoxButtons.OK);
                    TxtCedula.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(MiUsuarioLocal.Email))
                {
                    MessageBox.Show("Debe digitar el email del usuario", "Error de validación", MessageBoxButtons.OK);
                    TxtEmailDeUsuario.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(MiUsuarioLocal.Contrasennia))
                {
                    MessageBox.Show("Debe digitar la contraseña", "Error de validación", MessageBoxButtons.OK);
                    TxtContrasennia.Focus();
                    return false;
                }

                if (MiUsuarioLocal.MiRol.IDUsuarioRol <= 0)
                {
                    MessageBox.Show("Debe seleccionar un Rol", "Error de validación", MessageBoxButtons.OK);
                    CbRol.Focus();
                    return false;
                }
            }

            return R;
        }

        private void LimpiarFormulario(bool LimpiarBusqueda = true)
        {
            //se procede a limpiar de datos los controles del formulario
            TxtIDUsuario.Clear();
            TxtNombre.Clear();
            TxtCedula.Clear();
            TxtTelefono.Clear();
            TxtEmailDeUsuario.Clear();
            TxtContrasennia.Clear();
            CbRol.SelectedIndex = -1;

            if (LimpiarBusqueda)
            {
                TxtBuscar.Text = "Buscar";
            }
           
            //Al reinstanciar el objeto local se eliminan todos los datos de los atributos
            MiUsuarioLocal = new Logica.Models.Usuario();

            ActivarAgregar();

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            //Asigancion de valores de atributos
            /* MiUsuarioLocal.Cedula = TxtCedula.Text.Trim();
             MiUsuarioLocal.Nombre = TxtNombre.Text.Trim();
             MiUsuarioLocal.Email = TxtEmailDeUsuario.Text.Trim();

             Así no, sino que se realiza en tiempo real, 
            usando el evento LEAVE para alamcenar el dato del atributo al objeto local*/

            //Es importante validar que los atributos tengan datos antes de proceder 
            if (ValidarDatosRequeridos())
            {
                //SDUsuarioAgregar 1.3 y 3.6
                bool OkCedula = MiUsuarioLocal.ConsultarPorCedula(MiUsuarioLocal.Cedula);

                //SDUsuarioAgregar 1.4 y 1.6
                bool OkEmail = MiUsuarioLocal.ConsultarPorEmail(MiUsuarioLocal.Email);

                //SDUsuarioAgregar 1.5
                if (!OkCedula && !OkEmail)
                {
                    //Si no existe la cedula y si no existe el email, se tiene permiso para continuar con agregar

                    string Mensaje = string.Format("¿Desea continuar y agregar al usuario {0}?", "???", MessageBoxButtons.YesNo);
                    DialogResult Continuar = MessageBox.Show(Mensaje, "???", MessageBoxButtons.YesNo);

                    //si el ID o cualquier atributo obligatoria tiene datos, 
                    //se puede asegurar que el usuario aún existe y proceder con el AGREGAR

                    if (Continuar == DialogResult.Yes)
                    {
                        //SDUsuarioAgregar 1.6
                        if (MiUsuarioLocal.Agregar())
                        {
                            MessageBox.Show("Usuario agregado correctamente", "c:", MessageBoxButtons.OK);

                            LimpiarFormulario();

                            LlenarListaUsuarios(CboxVerActivos.Checked);

                            //TODO: limpiar el formulario y recargar la lista de usuarios en el DATADGRIDVIEW

                        }
                        else
                        {
                            MessageBox.Show("No se ha guardado el usuario", ":c", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                {
                    //En caso de que ya exista la cedula o el email, debe informarle al usuario
                    if (OkCedula)
                    {
                        MessageBox.Show("Ya existe un usuario con la cédula digitada", "Error de validación", MessageBoxButtons.OK);
                    }
                    if (OkEmail)
                    {
                        MessageBox.Show("Ya existe un usuario con el email digitado", "Error de validación", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void TxtNombre_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtNombre.Text.Trim()))
            {
                MiUsuarioLocal.Nombre = TxtNombre.Text.Trim();
            }
            else
            {
                MiUsuarioLocal.Nombre = "";
            }
        }

        private void TxtCedula_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtCedula.Text.Trim()))
            {
                MiUsuarioLocal.Cedula = TxtCedula.Text.Trim();
            }
            else
            {
                MiUsuarioLocal.Cedula = "";
            }
        }

        private void TxtTelefono_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtTelefono.Text.Trim()))
            {
                MiUsuarioLocal.Telefono = TxtTelefono.Text.Trim();
            }
            else
            {
                MiUsuarioLocal.Telefono = "";
            }
        }

        private void TxtEmailDeUsuario_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtEmailDeUsuario.Text.Trim()))
            {
                if (Commons.ObjetosGlobales.ValidarEmail((TxtEmailDeUsuario.Text.Trim())))
                {
                    MiUsuarioLocal.Email = TxtEmailDeUsuario.Text.Trim();
                }
                else
                {
                    MessageBox.Show("El formato del correo no es correcto", "Error de validación", MessageBoxButtons.OK);
                    TxtEmailDeUsuario.Focus();
                    TxtEmailDeUsuario.SelectAll();
                }
            }
            else
            {
                MiUsuarioLocal.Email = "";
            }
        }

        private void TxtContrasennia_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtContrasennia.Text.Trim()))
            {
                MiUsuarioLocal.Contrasennia = TxtContrasennia.Text.Trim();
            }
            else
            {
                MiUsuarioLocal.Contrasennia = "";
            }
        }

        private void CbRol_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (CbRol.SelectedIndex >= 0)
            {
                MiUsuarioLocal.MiRol.IDUsuarioRol = Convert.ToInt32(CbRol.SelectedValue);
            }
            else
            {
                MiUsuarioLocal.MiRol.IDUsuarioRol = 0;
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            LlenarListaUsuarios(CboxVerActivos.Checked);
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            //Según el diagrama de clases de uso expandido, se deb preguntar por ID
            //antes de proceder con el proceso de actualización.
            //Esto se explica en el diagrama de secuencia correspondiente

            if (ValidarDatosRequeridos(false))
            {
                //si se cumplen los datos mínimos se puede continuar

                //Se usa un objeto temporal para no tocar el usuario local 
                //y poder evaluar (si tiene datos en los atributos) que el usuario existe aún en la BD
                Logica.Models.Usuario ObjUsuario = MiUsuarioLocal.ConsultarPorID(MiUsuarioLocal.IDUsuario);

                if (ObjUsuario.IDUsuario > 0)
                {

                    string Mensaje = string.Format("¿Desea continuar con la modificación del usuario {0}?", MiUsuarioLocal.Nombre);
                    DialogResult Continuar = MessageBox.Show(Mensaje, "???", MessageBoxButtons.YesNo);

                    //si el ID o cualquier atributo obligatoria tiene datos, 
                    //se puede asegurar que el usuario aún existe y proceder con el UPDATE

                    if (Continuar == DialogResult.Yes)
                    {
                        if (MiUsuarioLocal.Editar())
                        {
                            //se muestra mensaje y se actualiza la lista
                            MessageBox.Show("El usuario se ha actualizado correctamente", "c:", MessageBoxButtons.OK);

                            LimpiarFormulario();

                            LlenarListaUsuarios(CboxVerActivos.Checked);
                        }
                        else
                        {
                            MessageBox.Show("No se logró actualizar el usuario", ":c", MessageBoxButtons.OK);
                        }
                    }
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Logica.Models.Usuario ObjUsuarioTemporal = MiUsuarioLocal.ConsultarPorID(MiUsuarioLocal.IDUsuario);

            //Si se muestran los usuarios eliminados, el botón debe funcionar para ACTIVAR de nuevo
            //al usuario y mostrarlo de nuevo en la lista de activos.
            //1. Crear el SPUusuarioActivar
            //2. Modificar la clase USUARIO para que tenga una función de activación de usuario
            //3. Modificar el código de este botón para que tenga ambas funcionalidades.

            if (ObjUsuarioTemporal.IDUsuario > 0)
            {
                string Mensaje = "";

                if (CboxVerActivos.Checked)
                {
                    Mensaje = string.Format("¿Desea continuar con la desactivación del usuario {0}?", MiUsuarioLocal.Nombre);
                }
                else
                {
                    Mensaje = string.Format("¿Desea continuar con la activación del usuario {0}?", MiUsuarioLocal.Nombre);
                }
                
                DialogResult Continaur = MessageBox.Show(Mensaje, "???", MessageBoxButtons.YesNo);

                if (Continaur == DialogResult.Yes)
                {
                    if (CboxVerActivos.Checked)
                    {
                        //si el ID o cualquier atributo obligatoria tiene datos, 
                        //se puede asegurar que el usuario aún existe y proceder con el DELETE
                        if (MiUsuarioLocal.Eliminar())
                        {
                            //se muestra el mensaje de éxito y se actualiza la lista
                            MessageBox.Show("El usuario ha sido desactivado correctamente", "Gestión de usuarios", MessageBoxButtons.OK);

                        }
                        else
                        {
                            MessageBox.Show("No se logró desactivar el usuario", "Gestión de usuarios", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        if (MiUsuarioLocal.Activar())
                        {
                            //se muestra el mensaje de éxito y se actualiza la lista
                            MessageBox.Show("El usuario ha sido activado correctamente", "Gestión de usuarios", MessageBoxButtons.OK);

                        }
                        else
                        {
                            MessageBox.Show("No se logró activar el usuario", "Gestión de usuarios", MessageBoxButtons.OK);
                        }
                    }

                    LimpiarFormulario();

                    LlenarListaUsuarios(CboxVerActivos.Checked);
                }
            }
        }

        private void DgvListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaUsuarios.SelectedRows.Count == 1)
            {
                LimpiarFormulario(false);

                DataGridViewRow MiFila = DgvListaUsuarios.SelectedRows[0];

                int CodigoUsuario = Convert.ToInt32(MiFila.Cells["CIDUsuario"].Value);

                MiUsuarioLocal = MiUsuarioLocal.ConsultarPorID(CodigoUsuario);

                TxtIDUsuario.Text = MiUsuarioLocal.IDUsuario.ToString();
                TxtNombre.Text = MiUsuarioLocal.Nombre;
                TxtCedula.Text = MiUsuarioLocal.Cedula;
                TxtTelefono.Text = MiUsuarioLocal.Telefono;
                TxtEmailDeUsuario.Text = MiUsuarioLocal.Email;
                //TxtContrasennia.Text = MiUsuarioLocal.Contrasennia;
                CbRol.SelectedValue = MiUsuarioLocal.MiRol.IDUsuarioRol;

                ActivarEditaryEliminar();
            }
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Commons.ObjetosGlobales.CaracteresTexto(e, true);
        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Commons.ObjetosGlobales.CaracteresNumeros(e);
        }

        private void TxtEmailDeUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Commons.ObjetosGlobales.CaracteresTexto(e, false, true);
        }


        //es por seguridad, para que el usuario no sea inducido a cometer algún error
        private void ActivarAgregar()
        {
            BtnAceptar.Enabled = true;
            BtnEditar.Enabled = false;
            BtnEliminar.Enabled = false;

            LblPassRequerido.Enabled = true;
        }
        private void ActivarEditaryEliminar()
        {
            BtnAceptar.Enabled = false;
            BtnEditar.Enabled = true;
            BtnEliminar.Enabled = true;

            LblPassRequerido.Enabled = false;
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            //cada que se escribe en el cuadro de texto, debemos llamar
            //al metodo de carga de usuarios considerando el valor de filtrado

            if (!string.IsNullOrEmpty(TxtBuscar.Text.Trim()) && TxtBuscar.Text.Count() >= 2)
            {
                LlenarListaUsuarios(CboxVerActivos.Checked, TxtBuscar.Text.Trim());
            }
            else
            {
                LlenarListaUsuarios(CboxVerActivos.Checked);
            }

        }

        private void CboxVerActivos_Click(object sender, EventArgs e)
        {
            LlenarListaUsuarios(CboxVerActivos.Checked);

            if (CboxVerActivos.Checked)
            {
                BtnEliminar.Text = "Eliminar";
                BtnEliminar.BackColor = Color.BurlyWood;
            }
            else
            {
                BtnEliminar.Text = "Activar";
                BtnEliminar.BackColor = Color.Peru;
            }
        }

        private void DgvListaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
