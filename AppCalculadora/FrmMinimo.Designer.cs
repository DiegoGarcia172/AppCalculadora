namespace AppCalculadora
{
    partial class FrmMinimo
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
            this.iniciatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeOperacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtSegundoNum = new System.Windows.Forms.TextBox();
            this.LblSN = new System.Windows.Forms.Label();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.LblR = new System.Windows.Forms.Label();
            this.TxtPrimN = new System.Windows.Forms.TextBox();
            this.LblPN = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciatToolStripMenuItem,
            this.minimoToolStripMenuItem,
            this.menuDeOperacionesToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(692, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iniciatToolStripMenuItem
            // 
            this.iniciatToolStripMenuItem.Name = "iniciatToolStripMenuItem";
            this.iniciatToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.iniciatToolStripMenuItem.Text = "Iniciar";
            this.iniciatToolStripMenuItem.Click += new System.EventHandler(this.IniciarToolStripMenuItem_Click);
            // 
            // minimoToolStripMenuItem
            // 
            this.minimoToolStripMenuItem.Name = "minimoToolStripMenuItem";
            this.minimoToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.minimoToolStripMenuItem.Text = "<>";
            this.minimoToolStripMenuItem.Click += new System.EventHandler(this.MinimoToolStripMenuItem_Click);
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
            // TxtSegundoNum
            // 
            this.TxtSegundoNum.Location = new System.Drawing.Point(216, 134);
            this.TxtSegundoNum.Name = "TxtSegundoNum";
            this.TxtSegundoNum.Size = new System.Drawing.Size(100, 20);
            this.TxtSegundoNum.TabIndex = 13;
            this.TxtSegundoNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSegundoNum_KeyPress);
            // 
            // LblSN
            // 
            this.LblSN.AutoSize = true;
            this.LblSN.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblSN.Location = new System.Drawing.Point(12, 129);
            this.LblSN.Name = "LblSN";
            this.LblSN.Size = new System.Drawing.Size(175, 23);
            this.LblSN.TabIndex = 12;
            this.LblSN.Text = "Segundo Numero:";
            // 
            // TxtResultado
            // 
            this.TxtResultado.Location = new System.Drawing.Point(466, 86);
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.Size = new System.Drawing.Size(158, 20);
            this.TxtResultado.TabIndex = 11;
            this.TxtResultado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtResultado_KeyPress);
            // 
            // LblR
            // 
            this.LblR.AutoSize = true;
            this.LblR.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblR.Location = new System.Drawing.Point(345, 86);
            this.LblR.Name = "LblR";
            this.LblR.Size = new System.Drawing.Size(106, 23);
            this.LblR.TabIndex = 10;
            this.LblR.Text = "Resultado:";
            // 
            // TxtPrimN
            // 
            this.TxtPrimN.Location = new System.Drawing.Point(216, 37);
            this.TxtPrimN.Name = "TxtPrimN";
            this.TxtPrimN.Size = new System.Drawing.Size(100, 20);
            this.TxtPrimN.TabIndex = 9;
            this.TxtPrimN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrimN_KeyPress);
            // 
            // LblPN
            // 
            this.LblPN.AutoSize = true;
            this.LblPN.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblPN.Location = new System.Drawing.Point(12, 34);
            this.LblPN.Name = "LblPN";
            this.LblPN.Size = new System.Drawing.Size(151, 23);
            this.LblPN.TabIndex = 8;
            this.LblPN.Text = "Primer Numero:";
            // 
            // FrmMinimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(692, 207);
            this.Controls.Add(this.TxtSegundoNum);
            this.Controls.Add(this.LblSN);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.LblR);
            this.Controls.Add(this.TxtPrimN);
            this.Controls.Add(this.LblPN);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMinimo";
            this.Text = "FrmMinimo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iniciatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuDeOperacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.TextBox TxtSegundoNum;
        private System.Windows.Forms.Label LblSN;
        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.Label LblR;
        private System.Windows.Forms.TextBox TxtPrimN;
        private System.Windows.Forms.Label LblPN;
    }
}