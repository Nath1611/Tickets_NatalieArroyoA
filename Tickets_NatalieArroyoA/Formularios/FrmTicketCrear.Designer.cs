namespace Tickets_NatalieArroyoA.Formularios
{
    partial class FrmTicketCrear
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtIDUsuario = new System.Windows.Forms.TextBox();
            this.LblClienteNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CboxCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtIDUsuario
            // 
            this.TxtIDUsuario.BackColor = System.Drawing.Color.SandyBrown;
            this.TxtIDUsuario.Font = new System.Drawing.Font("Candara", 10.25F);
            this.TxtIDUsuario.Location = new System.Drawing.Point(85, 94);
            this.TxtIDUsuario.Name = "TxtIDUsuario";
            this.TxtIDUsuario.Size = new System.Drawing.Size(121, 24);
            this.TxtIDUsuario.TabIndex = 0;
            this.TxtIDUsuario.DoubleClick += new System.EventHandler(this.TxtIDUsuario_DoubleClick);
            // 
            // LblClienteNombre
            // 
            this.LblClienteNombre.AutoSize = true;
            this.LblClienteNombre.Font = new System.Drawing.Font("Candara", 11.25F);
            this.LblClienteNombre.Location = new System.Drawing.Point(227, 96);
            this.LblClienteNombre.Name = "LblClienteNombre";
            this.LblClienteNombre.Size = new System.Drawing.Size(51, 18);
            this.LblClienteNombre.TabIndex = 1;
            this.LblClienteNombre.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            // 
            // CboxCategoria
            // 
            this.CboxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxCategoria.Font = new System.Drawing.Font("Candara", 10.25F);
            this.CboxCategoria.FormattingEnabled = true;
            this.CboxCategoria.Location = new System.Drawing.Point(85, 171);
            this.CboxCategoria.Name = "CboxCategoria";
            this.CboxCategoria.Size = new System.Drawing.Size(243, 25);
            this.CboxCategoria.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 11.25F);
            this.label3.Location = new System.Drawing.Point(82, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Categoría";
            // 
            // DtpFecha
            // 
            this.DtpFecha.CalendarMonthBackground = System.Drawing.Color.BlanchedAlmond;
            this.DtpFecha.CalendarTitleBackColor = System.Drawing.Color.Tan;
            this.DtpFecha.CalendarTrailingForeColor = System.Drawing.Color.Tan;
            this.DtpFecha.Font = new System.Drawing.Font("Candara", 11.25F);
            this.DtpFecha.Location = new System.Drawing.Point(329, 26);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(273, 26);
            this.DtpFecha.TabIndex = 5;
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.BackColor = System.Drawing.Color.Linen;
            this.TxtTitulo.Font = new System.Drawing.Font("Candara", 10.25F);
            this.TxtTitulo.Location = new System.Drawing.Point(85, 252);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(464, 24);
            this.TxtTitulo.TabIndex = 6;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.BackColor = System.Drawing.Color.Linen;
            this.TxtDescripcion.Font = new System.Drawing.Font("Candara", 10.25F);
            this.TxtDescripcion.Location = new System.Drawing.Point(85, 319);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtDescripcion.Size = new System.Drawing.Size(464, 94);
            this.TxtDescripcion.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 11.25F);
            this.label4.Location = new System.Drawing.Point(82, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Título";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 11.25F);
            this.label5.Location = new System.Drawing.Point(82, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Descripción";
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.PapayaWhip;
            this.BtnAceptar.Font = new System.Drawing.Font("Candara", 11.25F);
            this.BtnAceptar.Location = new System.Drawing.Point(173, 452);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 43);
            this.BtnAceptar.TabIndex = 10;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.PapayaWhip;
            this.BtnCancelar.Font = new System.Drawing.Font("Candara", 11.25F);
            this.BtnCancelar.Location = new System.Drawing.Point(365, 452);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 43);
            this.BtnCancelar.TabIndex = 11;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmTicketCrear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(624, 522);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.TxtTitulo);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CboxCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblClienteNombre);
            this.Controls.Add(this.TxtIDUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTicketCrear";
            this.Text = "Crear Ticket";
            this.Load += new System.EventHandler(this.FrmTicketCrear_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtIDUsuario;
        private System.Windows.Forms.Label LblClienteNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CboxCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}