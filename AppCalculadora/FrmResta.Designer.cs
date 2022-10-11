namespace AppCalculadora
{
    partial class FrmResta
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
            this.restarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.restarToolStripMenuItem,
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
            this.iniciarToolStripMenuItem.Click += new System.EventHandler(this.IniciarToolStripMenuItem_Click);
            // 
            // restarToolStripMenuItem
            // 
            this.restarToolStripMenuItem.Name = "restarToolStripMenuItem";
            this.restarToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.restarToolStripMenuItem.Text = "Restar";
            this.restarToolStripMenuItem.Click += new System.EventHandler(this.RestarToolStripMenuItem_Click);
            // 
            // menuDeOperacionesToolStripMenuItem
            // 
            this.menuDeOperacionesToolStripMenuItem.Name = "menuDeOperacionesToolStripMenuItem";
            this.menuDeOperacionesToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.menuDeOperacionesToolStripMenuItem.Text = "Menu de operaciones ";
            this.menuDeOperacionesToolStripMenuItem.Click += new System.EventHandler(this.MenuDeOperacionesToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.CerrarToolStripMenuItem_Click);
            // 
            // txtSegundoNum
            // 
            this.txtSegundoNum.Location = new System.Drawing.Point(243, 145);
            this.txtSegundoNum.Name = "txtSegundoNum";
            this.txtSegundoNum.Size = new System.Drawing.Size(135, 20);
            this.txtSegundoNum.TabIndex = 13;
            this.txtSegundoNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSegundoNum_KeyPress);
            // 
            // lblSN
            // 
            this.lblSN.AutoSize = true;
            this.lblSN.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblSN.Location = new System.Drawing.Point(39, 140);
            this.lblSN.Name = "lblSN";
            this.lblSN.Size = new System.Drawing.Size(175, 23);
            this.lblSN.TabIndex = 12;
            this.lblSN.Text = "Segundo Numero:";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(517, 94);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(135, 20);
            this.txtResultado.TabIndex = 11;
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblR.Location = new System.Drawing.Point(396, 94);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(106, 23);
            this.lblR.TabIndex = 10;
            this.lblR.Text = "Resultado:";
            // 
            // txtPrimN
            // 
            this.txtPrimN.Location = new System.Drawing.Point(243, 48);
            this.txtPrimN.Name = "txtPrimN";
            this.txtPrimN.Size = new System.Drawing.Size(135, 20);
            this.txtPrimN.TabIndex = 9;
            this.txtPrimN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrimN_KeyPress);
            // 
            // lblPN
            // 
            this.lblPN.AutoSize = true;
            this.lblPN.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblPN.Location = new System.Drawing.Point(39, 45);
            this.lblPN.Name = "lblPN";
            this.lblPN.Size = new System.Drawing.Size(151, 23);
            this.lblPN.TabIndex = 8;
            this.lblPN.Text = "Primer Numero:";
            // 
            // FrmResta
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
            this.Name = "FrmResta";
            this.Text = "Resta";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restarToolStripMenuItem;
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