namespace AppCalculadora
{
    partial class FrmMultiplicacion
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
            this.iniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplicarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeOperacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSegundoNum = new System.Windows.Forms.TextBox();
            this.lblSN = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblR = new System.Windows.Forms.Label();
            this.txtPrimN = new System.Windows.Forms.TextBox();
            this.lblPN = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarToolStripMenuItem,
            this.multiplicarToolStripMenuItem,
            this.menuDeOperacionesToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(692, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iniciarToolStripMenuItem
            // 
            this.iniciarToolStripMenuItem.Name = "iniciarToolStripMenuItem";
            this.iniciarToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.iniciarToolStripMenuItem.Text = "Iniciar";
            this.iniciarToolStripMenuItem.Click += new System.EventHandler(this.iniciarToolStripMenuItem_Click);
            // 
            // multiplicarToolStripMenuItem
            // 
            this.multiplicarToolStripMenuItem.Name = "multiplicarToolStripMenuItem";
            this.multiplicarToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.multiplicarToolStripMenuItem.Text = "Multiplicar";
            this.multiplicarToolStripMenuItem.Click += new System.EventHandler(this.multiplicarToolStripMenuItem_Click);
            // 
            // menuDeOperacionesToolStripMenuItem
            // 
            this.menuDeOperacionesToolStripMenuItem.Name = "menuDeOperacionesToolStripMenuItem";
            this.menuDeOperacionesToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.menuDeOperacionesToolStripMenuItem.Text = "Menu de operaciones";
            this.menuDeOperacionesToolStripMenuItem.Click += new System.EventHandler(this.menuDeOperacionesToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // txtSegundoNum
            // 
            this.txtSegundoNum.Location = new System.Drawing.Point(216, 141);
            this.txtSegundoNum.Name = "txtSegundoNum";
            this.txtSegundoNum.Size = new System.Drawing.Size(135, 20);
            this.txtSegundoNum.TabIndex = 25;
            this.txtSegundoNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSegundoNum_KeyPress);
            // 
            // lblSN
            // 
            this.lblSN.AutoSize = true;
            this.lblSN.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblSN.Location = new System.Drawing.Point(12, 136);
            this.lblSN.Name = "lblSN";
            this.lblSN.Size = new System.Drawing.Size(175, 23);
            this.lblSN.TabIndex = 24;
            this.lblSN.Text = "Segundo Numero:";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(490, 90);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(135, 20);
            this.txtResultado.TabIndex = 23;
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblR.Location = new System.Drawing.Point(369, 90);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(106, 23);
            this.lblR.TabIndex = 22;
            this.lblR.Text = "Resultado:";
            // 
            // txtPrimN
            // 
            this.txtPrimN.Location = new System.Drawing.Point(216, 44);
            this.txtPrimN.Name = "txtPrimN";
            this.txtPrimN.Size = new System.Drawing.Size(135, 20);
            this.txtPrimN.TabIndex = 21;
            this.txtPrimN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrimN_KeyPress);
            // 
            // lblPN
            // 
            this.lblPN.AutoSize = true;
            this.lblPN.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblPN.Location = new System.Drawing.Point(12, 41);
            this.lblPN.Name = "lblPN";
            this.lblPN.Size = new System.Drawing.Size(151, 23);
            this.lblPN.TabIndex = 20;
            this.lblPN.Text = "Primer Numero:";
            // 
            // FrmMultiplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(692, 207);
            this.Controls.Add(this.txtSegundoNum);
            this.Controls.Add(this.lblSN);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.txtPrimN);
            this.Controls.Add(this.lblPN);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMultiplicacion";
            this.Text = "FrmMultiplicacion";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplicarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuDeOperacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSegundoNum;
        private System.Windows.Forms.Label lblSN;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.TextBox txtPrimN;
        private System.Windows.Forms.Label lblPN;
    }
}