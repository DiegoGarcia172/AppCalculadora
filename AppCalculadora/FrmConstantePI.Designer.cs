namespace AppCalculadora
{
    partial class FrmConstantePI
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
            this.ConstantePiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(495, 65);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(135, 20);
            this.txtResultado.TabIndex = 24;
            this.txtResultado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResultado_KeyPress);
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblR.Location = new System.Drawing.Point(383, 62);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(106, 23);
            this.lblR.TabIndex = 23;
            this.lblR.Text = "Resultado:";
            // 
            // txtPrimN
            // 
            this.txtPrimN.Location = new System.Drawing.Point(216, 62);
            this.txtPrimN.Name = "txtPrimN";
            this.txtPrimN.Size = new System.Drawing.Size(135, 20);
            this.txtPrimN.TabIndex = 22;
            this.txtPrimN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrimN_KeyPress);
            // 
            // lblPN
            // 
            this.lblPN.AutoSize = true;
            this.lblPN.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblPN.Location = new System.Drawing.Point(12, 59);
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
            this.ConstantePiToolStripMenuItem,
            this.menuToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(714, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iniciarToolStripMenuItem
            // 
            this.iniciarToolStripMenuItem.Name = "iniciarToolStripMenuItem";
            this.iniciarToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.iniciarToolStripMenuItem.Text = "Iniciar";
            // 
            // ConstantePiToolStripMenuItem
            // 
            this.ConstantePiToolStripMenuItem.Name = "ConstantePiToolStripMenuItem";
            this.ConstantePiToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.ConstantePiToolStripMenuItem.Text = "Constante Pi";
            this.ConstantePiToolStripMenuItem.Click += new System.EventHandler(this.ConstantePiToolStripMenuItem_Click);
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
            // FrmConstantePI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(714, 154);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.txtPrimN);
            this.Controls.Add(this.lblPN);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConstantePI";
            this.Text = "FrmConstantePI";
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
        private System.Windows.Forms.ToolStripMenuItem ConstantePiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
    }
}