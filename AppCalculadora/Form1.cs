using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gbOpBa.Visible = false;
            gbOpAv.Visible = false;
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void PbSuma_Click(object sender, EventArgs e)
        {
            FrmSuma frm = new FrmSuma();
            frm.Show();
            this.Visible = false;
        }
        private void PbResta_Click(object sender, EventArgs e)
        {
            FrmResta frm = new FrmResta();
            frm.Show();
            this.Visible = false;
        }
        private void PbDiv_Click(object sender, EventArgs e)
        {
            FrmDivision frm = new FrmDivision();
            frm.Show();
            this.Visible = false;
        }
        private void PbMult_Click(object sender, EventArgs e)
        {
            FrmMultiplicacion frm = new FrmMultiplicacion();
            frm.Show();
            this.Visible = false;
        }
        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            gbOpBa.Visible = true;
            gbOpAv.Visible = true;
        }
        private void PbRaiz_Click(object sender, EventArgs e)
        {
            FrmRaiz frm = new FrmRaiz();
            frm.Show();
            this.Visible = false;
        }
        private void PbMin_Click(object sender, EventArgs e)
        {
            FrmMinimo frm = new FrmMinimo();
            frm.Show();
            this.Visible = false;
        }
        private void PbPotencia_Click(object sender, EventArgs e)
        {
            FrmPotencia frm = new FrmPotencia();
            frm.Show();
            this.Visible = false;
        }
        private void PbConstante_Click(object sender, EventArgs e)
        {
            FrmConstantePI frm = new FrmConstantePI();
            frm.Show();
            this.Visible = false;
        }
        private void PbRedondeo_Click(object sender, EventArgs e)
        {
            FrmRedondeo frm = new FrmRedondeo();
            frm.Show();
            this.Visible = false;
        }
    }
}
