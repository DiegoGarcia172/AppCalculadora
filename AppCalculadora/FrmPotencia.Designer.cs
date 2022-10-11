namespace AppCalculadora
{
    partial class FrmPotencia
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
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblR = new System.Windows.Forms.Label();
            this.txtPrimN = new System.Windows.Forms.TextBox();
            this.lblPN = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExponenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtSN = new System.Windows.Forms.TextBox();
            this.lblSN = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(525, 43);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(135, 20);
            this.txtResultado.TabIndex = 24;
            this.txtResultado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResultado_KeyPress);
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblR.Location = new System.Drawing.Point(404, 43);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(106, 23);
            this.lblR.TabIndex = 23;
            this.lblR.Text = "Resultado:";
            // 
            // txtPrimN
            // 
            this.txtPrimN.Location = new System.Drawing.Point(216, 46);
            this.txtPrimN.Name = "txtPrimN";
            this.txtPrimN.Size = new System.Drawing.Size(135, 20);
            this.txtPrimN.TabIndex = 22;
            this.txtPrimN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrimN_KeyPress);
            // 
            // lblPN
            // 
            this.lblPN.AutoSize = true;
            this.lblPN.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblPN.Location = new System.Drawing.Point(12, 43);
            this.lblPN.Name = "lblPN";
            this.lblPN.Size = new System.Drawing.Size(151, 23);
            this.lblPN.TabIndex = 21;
            this.lblPN.Text = "Primer Numero:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarToolStripMenuItem,
            this.ExponenteToolStripMenuItem,
            this.menuToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(747, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iniciarToolStripMenuItem
            // 
            this.iniciarToolStripMenuItem.Name = "iniciarToolStripMenuItem";
            this.iniciarToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.iniciarToolStripMenuItem.Text = "Iniciar";
            this.iniciarToolStripMenuItem.Click += new System.EventHandler(this.iniciarToolStripMenuItem_Click);
            // 
            // ExponenteToolStripMenuItem
            // 
            this.ExponenteToolStripMenuItem.Name = "ExponenteToolStripMenuItem";
            this.ExponenteToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.ExponenteToolStripMenuItem.Text = "Exponente";
            this.ExponenteToolStripMenuItem.Click += new System.EventHandler(this.ExponenteToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.menuToolStripMenuItem.Text = "Menu de operaciones";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // TxtSN
            // 
            this.TxtSN.Location = new System.Drawing.Point(216, 97);
            this.TxtSN.Name = "TxtSN";
            this.TxtSN.Size = new System.Drawing.Size(135, 20);
            this.TxtSN.TabIndex = 26;
            this.TxtSN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSN_KeyPress);
            // 
            // lblSN
            // 
            this.lblSN.AutoSize = true;
            this.lblSN.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblSN.Location = new System.Drawing.Point(12, 94);
            this.lblSN.Name = "lblSN";
            this.lblSN.Size = new System.Drawing.Size(175, 23);
            this.lblSN.TabIndex = 25;
            this.lblSN.Text = "Segundo Numero:";
            // 
            // FrmPotencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(747, 163);
            this.Controls.Add(this.TxtSN);
            this.Controls.Add(this.lblSN);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.txtPrimN);
            this.Controls.Add(this.lblPN);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPotencia";
            this.Text = "FrmPotencia";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.TextBox txtPrimN;
        private System.Windows.Forms.Label lblPN;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExponenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.TextBox TxtSN;
        private System.Windows.Forms.Label lblSN;
    }
}