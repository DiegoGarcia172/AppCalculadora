namespace AppCalculadora
{
    partial class FrmRaiz
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.IniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeOperacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblR = new System.Windows.Forms.Label();
            this.txtPrimN = new System.Windows.Forms.TextBox();
            this.lblN = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IniciarToolStripMenuItem,
            this.raizToolStripMenuItem,
            this.menuDeOperacionesToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(692, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // IniciarToolStripMenuItem
            // 
            this.IniciarToolStripMenuItem.Name = "IniciarToolStripMenuItem";
            this.IniciarToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.IniciarToolStripMenuItem.Text = "Iniciar";
            this.IniciarToolStripMenuItem.Click += new System.EventHandler(this.IniciarToolStripMenuItem_Click);
            // 
            // raizToolStripMenuItem
            // 
            this.raizToolStripMenuItem.Name = "raizToolStripMenuItem";
            this.raizToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.raizToolStripMenuItem.Text = "Raiz";
            this.raizToolStripMenuItem.Click += new System.EventHandler(this.RaizToolStripMenuItem_Click);
            // 
            // menuDeOperacionesToolStripMenuItem
            // 
            this.menuDeOperacionesToolStripMenuItem.Name = "menuDeOperacionesToolStripMenuItem";
            this.menuDeOperacionesToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.menuDeOperacionesToolStripMenuItem.Text = "Menu de operaciones";
            this.menuDeOperacionesToolStripMenuItem.Click += new System.EventHandler(this.MenuDeOperacionesToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.CerrarToolStripMenuItem_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(509, 74);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(135, 20);
            this.txtResultado.TabIndex = 29;
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblR.Location = new System.Drawing.Point(388, 74);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(106, 23);
            this.lblR.TabIndex = 28;
            this.lblR.Text = "Resultado:";
            // 
            // txtPrimN
            // 
            this.txtPrimN.Location = new System.Drawing.Point(142, 79);
            this.txtPrimN.Name = "txtPrimN";
            this.txtPrimN.Size = new System.Drawing.Size(135, 20);
            this.txtPrimN.TabIndex = 27;
            this.txtPrimN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrimN_KeyPress);
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblN.Location = new System.Drawing.Point(48, 79);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(88, 23);
            this.lblN.TabIndex = 26;
            this.lblN.Text = "Numero:";
            // 
            // FrmRaiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(692, 207);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.txtPrimN);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmRaiz";
            this.Text = "FrmRaiz";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem IniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuDeOperacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.TextBox txtPrimN;
        private System.Windows.Forms.Label lblN;
    }
}