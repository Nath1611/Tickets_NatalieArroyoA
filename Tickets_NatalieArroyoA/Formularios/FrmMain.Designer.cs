namespace Tickets_NatalieArroyoA.Formularios
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.gestiónDeRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeCategoríasDeTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creaciónDeTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soluciónDeTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblUsuarioLogueado = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.TmrHora = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.NavajoWhite;
            this.menuStrip1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(743, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónDeUsuariosToolStripMenuItem,
            this.gestiónDeClientesToolStripMenuItem,
            this.toolStripSeparator1,
            this.gestiónDeRolesToolStripMenuItem,
            this.gestiónDeCategoríasDeTicketToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(110, 19);
            this.toolStripMenuItem1.Text = "Mantenimientos";
            // 
            // gestiónDeUsuariosToolStripMenuItem
            // 
            this.gestiónDeUsuariosToolStripMenuItem.BackColor = System.Drawing.Color.NavajoWhite;
            this.gestiónDeUsuariosToolStripMenuItem.Name = "gestiónDeUsuariosToolStripMenuItem";
            this.gestiónDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.gestiónDeUsuariosToolStripMenuItem.Text = "Gestión de Usuarios";
            this.gestiónDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.gestiónDeUsuariosToolStripMenuItem_Click);
            // 
            // gestiónDeClientesToolStripMenuItem
            // 
            this.gestiónDeClientesToolStripMenuItem.BackColor = System.Drawing.Color.NavajoWhite;
            this.gestiónDeClientesToolStripMenuItem.Name = "gestiónDeClientesToolStripMenuItem";
            this.gestiónDeClientesToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.gestiónDeClientesToolStripMenuItem.Text = "Gestión de Clientes";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.SaddleBrown;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(245, 6);
            // 
            // gestiónDeRolesToolStripMenuItem
            // 
            this.gestiónDeRolesToolStripMenuItem.BackColor = System.Drawing.Color.NavajoWhite;
            this.gestiónDeRolesToolStripMenuItem.Name = "gestiónDeRolesToolStripMenuItem";
            this.gestiónDeRolesToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.gestiónDeRolesToolStripMenuItem.Text = "Gestión de Roles";
            // 
            // gestiónDeCategoríasDeTicketToolStripMenuItem
            // 
            this.gestiónDeCategoríasDeTicketToolStripMenuItem.BackColor = System.Drawing.Color.NavajoWhite;
            this.gestiónDeCategoríasDeTicketToolStripMenuItem.Name = "gestiónDeCategoríasDeTicketToolStripMenuItem";
            this.gestiónDeCategoríasDeTicketToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.gestiónDeCategoríasDeTicketToolStripMenuItem.Text = "Gestión de Categorías de Ticket";
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creaciónDeTicketToolStripMenuItem,
            this.soluciónDeTicketToolStripMenuItem});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(68, 19);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // creaciónDeTicketToolStripMenuItem
            // 
            this.creaciónDeTicketToolStripMenuItem.BackColor = System.Drawing.Color.NavajoWhite;
            this.creaciónDeTicketToolStripMenuItem.Name = "creaciónDeTicketToolStripMenuItem";
            this.creaciónDeTicketToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.creaciónDeTicketToolStripMenuItem.Text = "Creación de Ticket";
            this.creaciónDeTicketToolStripMenuItem.Click += new System.EventHandler(this.creaciónDeTicketToolStripMenuItem_Click);
            // 
            // soluciónDeTicketToolStripMenuItem
            // 
            this.soluciónDeTicketToolStripMenuItem.BackColor = System.Drawing.Color.NavajoWhite;
            this.soluciónDeTicketToolStripMenuItem.Name = "soluciónDeTicketToolStripMenuItem";
            this.soluciónDeTicketToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.soluciónDeTicketToolStripMenuItem.Text = "Solución de Ticket";
            this.soluciónDeTicketToolStripMenuItem.Click += new System.EventHandler(this.soluciónDeTicketToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(70, 19);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(74, 19);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 19);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.LblUsuarioLogueado,
            this.LblHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 402);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(743, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel1.Text = "Usuario:";
            // 
            // LblUsuarioLogueado
            // 
            this.LblUsuarioLogueado.Name = "LblUsuarioLogueado";
            this.LblUsuarioLogueado.Size = new System.Drawing.Size(14, 17);
            this.LblUsuarioLogueado.Text = "u";
            // 
            // LblHora
            // 
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(659, 17);
            this.LblHora.Spring = true;
            this.LblHora.Text = "Hora";
            this.LblHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TmrHora
            // 
            this.TmrHora.Interval = 1000;
            this.TmrHora.Tick += new System.EventHandler(this.TmrHora_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(743, 424);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Control de Tickets de Soporte Técnico y Trabajos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeRolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeCategoríasDeTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creaciónDeTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soluciónDeTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel LblUsuarioLogueado;
        private System.Windows.Forms.ToolStripStatusLabel LblHora;
        private System.Windows.Forms.Timer TmrHora;
    }
}