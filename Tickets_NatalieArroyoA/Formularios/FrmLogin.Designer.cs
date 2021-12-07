namespace Tickets_NatalieArroyoA.Formularios
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.LblEmailDeUsuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblContrasennia = new System.Windows.Forms.Label();
            this.TxtEmailDelUsuario = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LblRecuperarContrasennia = new System.Windows.Forms.LinkLabel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.BtnIngresoDirecto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.Color.NavajoWhite;
            this.BtnIngresar.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.Location = new System.Drawing.Point(46, 346);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(75, 38);
            this.BtnIngresar.TabIndex = 0;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // LblEmailDeUsuario
            // 
            this.LblEmailDeUsuario.AutoSize = true;
            this.LblEmailDeUsuario.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmailDeUsuario.Location = new System.Drawing.Point(43, 128);
            this.LblEmailDeUsuario.Name = "LblEmailDeUsuario";
            this.LblEmailDeUsuario.Size = new System.Drawing.Size(110, 18);
            this.LblEmailDeUsuario.TabIndex = 2;
            this.LblEmailDeUsuario.Text = "Email de Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(102, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 99);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // LblContrasennia
            // 
            this.LblContrasennia.AutoSize = true;
            this.LblContrasennia.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContrasennia.Location = new System.Drawing.Point(43, 219);
            this.LblContrasennia.Name = "LblContrasennia";
            this.LblContrasennia.Size = new System.Drawing.Size(78, 18);
            this.LblContrasennia.TabIndex = 4;
            this.LblContrasennia.Text = "Contraseña";
            // 
            // TxtEmailDelUsuario
            // 
            this.TxtEmailDelUsuario.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmailDelUsuario.Location = new System.Drawing.Point(46, 163);
            this.TxtEmailDelUsuario.Name = "TxtEmailDelUsuario";
            this.TxtEmailDelUsuario.Size = new System.Drawing.Size(246, 23);
            this.TxtEmailDelUsuario.TabIndex = 5;
            this.TxtEmailDelUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(46, 247);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(246, 23);
            this.TxtPassword.TabIndex = 6;
            this.TxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // LblRecuperarContrasennia
            // 
            this.LblRecuperarContrasennia.AutoSize = true;
            this.LblRecuperarContrasennia.LinkColor = System.Drawing.Color.MidnightBlue;
            this.LblRecuperarContrasennia.Location = new System.Drawing.Point(179, 270);
            this.LblRecuperarContrasennia.Name = "LblRecuperarContrasennia";
            this.LblRecuperarContrasennia.Size = new System.Drawing.Size(113, 13);
            this.LblRecuperarContrasennia.TabIndex = 7;
            this.LblRecuperarContrasennia.TabStop = true;
            this.LblRecuperarContrasennia.Text = "Recuperar contraseña";
            this.LblRecuperarContrasennia.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblRecuperarContrasennia_LinkClicked);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnCancelar.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(217, 346);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 38);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // BtnIngresoDirecto
            // 
            this.BtnIngresoDirecto.Location = new System.Drawing.Point(127, 340);
            this.BtnIngresoDirecto.Name = "BtnIngresoDirecto";
            this.BtnIngresoDirecto.Size = new System.Drawing.Size(84, 50);
            this.BtnIngresoDirecto.TabIndex = 9;
            this.BtnIngresoDirecto.Text = "Ingreso Directo";
            this.BtnIngresoDirecto.UseVisualStyleBackColor = true;
            this.BtnIngresoDirecto.Visible = false;
            this.BtnIngresoDirecto.Click += new System.EventHandler(this.BtnIngresoDirecto_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(349, 408);
            this.Controls.Add(this.BtnIngresoDirecto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.LblRecuperarContrasennia);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtEmailDelUsuario);
            this.Controls.Add(this.LblContrasennia);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblEmailDeUsuario);
            this.Controls.Add(this.BtnIngresar);
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLogin_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Label LblEmailDeUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblContrasennia;
        private System.Windows.Forms.TextBox TxtEmailDelUsuario;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.LinkLabel LblRecuperarContrasennia;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button BtnIngresoDirecto;
    }
}