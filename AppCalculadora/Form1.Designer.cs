namespace AppCalculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSuma = new System.Windows.Forms.Label();
            this.gbOpBa = new System.Windows.Forms.GroupBox();
            this.lblResta = new System.Windows.Forms.Label();
            this.lblMulti = new System.Windows.Forms.Label();
            this.lblDiv = new System.Windows.Forms.Label();
            this.gbOpAv = new System.Windows.Forms.GroupBox();
            this.lblRedondeo = new System.Windows.Forms.Label();
            this.lblConstante = new System.Windows.Forms.Label();
            this.lblMM = new System.Windows.Forms.Label();
            this.lblPotencia = new System.Windows.Forms.Label();
            this.lblRaiz = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.pbRedondeo = new System.Windows.Forms.PictureBox();
            this.pbConstante = new System.Windows.Forms.PictureBox();
            this.pbMin = new System.Windows.Forms.PictureBox();
            this.pbPotencia = new System.Windows.Forms.PictureBox();
            this.pbRaiz = new System.Windows.Forms.PictureBox();
            this.pbResta = new System.Windows.Forms.PictureBox();
            this.pbDiv = new System.Windows.Forms.PictureBox();
            this.pbMult = new System.Windows.Forms.PictureBox();
            this.pbSuma = new System.Windows.Forms.PictureBox();
            this.gbOpBa.SuspendLayout();
            this.gbOpAv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRedondeo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConstante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPotencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaiz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSuma)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuma.Location = new System.Drawing.Point(124, 50);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(67, 23);
            this.lblSuma.TabIndex = 0;
            this.lblSuma.Text = "Suma ";
            // 
            // gbOpBa
            // 
            this.gbOpBa.Controls.Add(this.pbResta);
            this.gbOpBa.Controls.Add(this.lblResta);
            this.gbOpBa.Controls.Add(this.pbDiv);
            this.gbOpBa.Controls.Add(this.lblMulti);
            this.gbOpBa.Controls.Add(this.pbMult);
            this.gbOpBa.Controls.Add(this.lblDiv);
            this.gbOpBa.Controls.Add(this.pbSuma);
            this.gbOpBa.Controls.Add(this.lblSuma);
            this.gbOpBa.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.gbOpBa.Location = new System.Drawing.Point(103, 12);
            this.gbOpBa.Name = "gbOpBa";
            this.gbOpBa.Size = new System.Drawing.Size(270, 474);
            this.gbOpBa.TabIndex = 1;
            this.gbOpBa.TabStop = false;
            this.gbOpBa.Text = "Operaciones Basicas ";
            // 
            // lblResta
            // 
            this.lblResta.AutoSize = true;
            this.lblResta.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResta.Location = new System.Drawing.Point(124, 151);
            this.lblResta.Name = "lblResta";
            this.lblResta.Size = new System.Drawing.Size(60, 23);
            this.lblResta.TabIndex = 6;
            this.lblResta.Text = "Resta";
            // 
            // lblMulti
            // 
            this.lblMulti.AutoSize = true;
            this.lblMulti.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMulti.Location = new System.Drawing.Point(124, 383);
            this.lblMulti.Name = "lblMulti";
            this.lblMulti.Size = new System.Drawing.Size(142, 23);
            this.lblMulti.TabIndex = 4;
            this.lblMulti.Text = "Multiplicacion";
            // 
            // lblDiv
            // 
            this.lblDiv.AutoSize = true;
            this.lblDiv.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiv.Location = new System.Drawing.Point(124, 264);
            this.lblDiv.Name = "lblDiv";
            this.lblDiv.Size = new System.Drawing.Size(80, 23);
            this.lblDiv.TabIndex = 2;
            this.lblDiv.Text = "Divison ";
            // 
            // gbOpAv
            // 
            this.gbOpAv.Controls.Add(this.lblRedondeo);
            this.gbOpAv.Controls.Add(this.pbRedondeo);
            this.gbOpAv.Controls.Add(this.lblConstante);
            this.gbOpAv.Controls.Add(this.pbConstante);
            this.gbOpAv.Controls.Add(this.pbMin);
            this.gbOpAv.Controls.Add(this.lblMM);
            this.gbOpAv.Controls.Add(this.lblPotencia);
            this.gbOpAv.Controls.Add(this.pbPotencia);
            this.gbOpAv.Controls.Add(this.pbRaiz);
            this.gbOpAv.Controls.Add(this.lblRaiz);
            this.gbOpAv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbOpAv.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpAv.Location = new System.Drawing.Point(503, 3);
            this.gbOpAv.Name = "gbOpAv";
            this.gbOpAv.Size = new System.Drawing.Size(288, 483);
            this.gbOpAv.TabIndex = 7;
            this.gbOpAv.TabStop = false;
            this.gbOpAv.Text = "Operaciones Avanzadas ";
            // 
            // lblRedondeo
            // 
            this.lblRedondeo.AutoSize = true;
            this.lblRedondeo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblRedondeo.Location = new System.Drawing.Point(124, 414);
            this.lblRedondeo.Name = "lblRedondeo";
            this.lblRedondeo.Size = new System.Drawing.Size(106, 23);
            this.lblRedondeo.TabIndex = 10;
            this.lblRedondeo.Text = "Redondeo";
            // 
            // lblConstante
            // 
            this.lblConstante.AutoSize = true;
            this.lblConstante.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblConstante.Location = new System.Drawing.Point(124, 325);
            this.lblConstante.Name = "lblConstante";
            this.lblConstante.Size = new System.Drawing.Size(155, 23);
            this.lblConstante.TabIndex = 8;
            this.lblConstante.Text = "Constante de PI";
            // 
            // lblMM
            // 
            this.lblMM.AutoSize = true;
            this.lblMM.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblMM.Location = new System.Drawing.Point(124, 133);
            this.lblMM.Name = "lblMM";
            this.lblMM.Size = new System.Drawing.Size(44, 23);
            this.lblMM.TabIndex = 6;
            this.lblMM.Text = "MM";
            // 
            // lblPotencia
            // 
            this.lblPotencia.AutoSize = true;
            this.lblPotencia.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblPotencia.Location = new System.Drawing.Point(124, 235);
            this.lblPotencia.Name = "lblPotencia";
            this.lblPotencia.Size = new System.Drawing.Size(92, 23);
            this.lblPotencia.TabIndex = 4;
            this.lblPotencia.Text = "Potencia";
            // 
            // lblRaiz
            // 
            this.lblRaiz.AutoSize = true;
            this.lblRaiz.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblRaiz.Location = new System.Drawing.Point(111, 46);
            this.lblRaiz.Name = "lblRaiz";
            this.lblRaiz.Size = new System.Drawing.Size(150, 23);
            this.lblRaiz.TabIndex = 0;
            this.lblRaiz.Text = "Raiz Cuadrada";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(395, 202);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(82, 45);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Location = new System.Drawing.Point(395, 141);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(82, 45);
            this.btnIniciar.TabIndex = 9;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // pbRedondeo
            // 
            this.pbRedondeo.Image = global::AppCalculadora.Properties.Resources.RegisteredTM_svg;
            this.pbRedondeo.Location = new System.Drawing.Point(16, 392);
            this.pbRedondeo.Name = "pbRedondeo";
            this.pbRedondeo.Size = new System.Drawing.Size(89, 56);
            this.pbRedondeo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRedondeo.TabIndex = 9;
            this.pbRedondeo.TabStop = false;
            this.pbRedondeo.Click += new System.EventHandler(this.PbRedondeo_Click);
            // 
            // pbConstante
            // 
            this.pbConstante.Image = global::AppCalculadora.Properties.Resources._58afde43829958a978a4a6b5;
            this.pbConstante.Location = new System.Drawing.Point(16, 304);
            this.pbConstante.Name = "pbConstante";
            this.pbConstante.Size = new System.Drawing.Size(89, 60);
            this.pbConstante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbConstante.TabIndex = 7;
            this.pbConstante.TabStop = false;
            this.pbConstante.Click += new System.EventHandler(this.PbConstante_Click);
            // 
            // pbMin
            // 
            this.pbMin.Image = global::AppCalculadora.Properties.Resources._1200px_Parentesi_Uncinate_svg;
            this.pbMin.Location = new System.Drawing.Point(16, 124);
            this.pbMin.Name = "pbMin";
            this.pbMin.Size = new System.Drawing.Size(89, 48);
            this.pbMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMin.TabIndex = 5;
            this.pbMin.TabStop = false;
            this.pbMin.Click += new System.EventHandler(this.PbMin_Click);
            // 
            // pbPotencia
            // 
            this.pbPotencia.Image = global::AppCalculadora.Properties.Resources.pngwing_com;
            this.pbPotencia.Location = new System.Drawing.Point(16, 216);
            this.pbPotencia.Name = "pbPotencia";
            this.pbPotencia.Size = new System.Drawing.Size(89, 59);
            this.pbPotencia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPotencia.TabIndex = 1;
            this.pbPotencia.TabStop = false;
            this.pbPotencia.Click += new System.EventHandler(this.PbPotencia_Click);
            // 
            // pbRaiz
            // 
            this.pbRaiz.Image = global::AppCalculadora.Properties.Resources._43743;
            this.pbRaiz.Location = new System.Drawing.Point(16, 34);
            this.pbRaiz.Name = "pbRaiz";
            this.pbRaiz.Size = new System.Drawing.Size(89, 62);
            this.pbRaiz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRaiz.TabIndex = 0;
            this.pbRaiz.TabStop = false;
            this.pbRaiz.Click += new System.EventHandler(this.PbRaiz_Click);
            // 
            // pbResta
            // 
            this.pbResta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbResta.Image = global::AppCalculadora.Properties.Resources.Resta;
            this.pbResta.Location = new System.Drawing.Point(16, 124);
            this.pbResta.Name = "pbResta";
            this.pbResta.Size = new System.Drawing.Size(89, 76);
            this.pbResta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbResta.TabIndex = 5;
            this.pbResta.TabStop = false;
            this.pbResta.Click += new System.EventHandler(this.PbResta_Click);
            // 
            // pbDiv
            // 
            this.pbDiv.Image = global::AppCalculadora.Properties.Resources.division;
            this.pbDiv.Location = new System.Drawing.Point(16, 239);
            this.pbDiv.Name = "pbDiv";
            this.pbDiv.Size = new System.Drawing.Size(89, 77);
            this.pbDiv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDiv.TabIndex = 3;
            this.pbDiv.TabStop = false;
            this.pbDiv.Click += new System.EventHandler(this.PbDiv_Click);
            // 
            // pbMult
            // 
            this.pbMult.Image = global::AppCalculadora.Properties.Resources.X;
            this.pbMult.Location = new System.Drawing.Point(16, 362);
            this.pbMult.Name = "pbMult";
            this.pbMult.Size = new System.Drawing.Size(89, 77);
            this.pbMult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMult.TabIndex = 1;
            this.pbMult.TabStop = false;
            this.pbMult.Click += new System.EventHandler(this.PbMult_Click);
            // 
            // pbSuma
            // 
            this.pbSuma.Image = global::AppCalculadora.Properties.Resources.suma;
            this.pbSuma.Location = new System.Drawing.Point(16, 25);
            this.pbSuma.Name = "pbSuma";
            this.pbSuma.Size = new System.Drawing.Size(89, 76);
            this.pbSuma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSuma.TabIndex = 0;
            this.pbSuma.TabStop = false;
            this.pbSuma.Click += new System.EventHandler(this.PbSuma_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(873, 511);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbOpAv);
            this.Controls.Add(this.gbOpBa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Operaciones ";
            this.gbOpBa.ResumeLayout(false);
            this.gbOpBa.PerformLayout();
            this.gbOpAv.ResumeLayout(false);
            this.gbOpAv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRedondeo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConstante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPotencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaiz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSuma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.GroupBox gbOpBa;
        private System.Windows.Forms.PictureBox pbResta;
        private System.Windows.Forms.Label lblResta;
        private System.Windows.Forms.PictureBox pbDiv;
        private System.Windows.Forms.Label lblMulti;
        private System.Windows.Forms.PictureBox pbMult;
        private System.Windows.Forms.Label lblDiv;
        private System.Windows.Forms.PictureBox pbSuma;
        private System.Windows.Forms.GroupBox gbOpAv;
        private System.Windows.Forms.Label lblRedondeo;
        private System.Windows.Forms.PictureBox pbRedondeo;
        private System.Windows.Forms.Label lblConstante;
        private System.Windows.Forms.PictureBox pbConstante;
        private System.Windows.Forms.PictureBox pbMin;
        private System.Windows.Forms.Label lblMM;
        private System.Windows.Forms.Label lblPotencia;
        private System.Windows.Forms.PictureBox pbPotencia;
        private System.Windows.Forms.PictureBox pbRaiz;
        private System.Windows.Forms.Label lblRaiz;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnIniciar;
    }
}

