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
    public partial class FrmPotencia : Form
    {
        double num1, num2, cuadrado;
        public FrmPotencia()
        {
            InitializeComponent();
            txtPrimN.Visible = false;
            TxtSN.Visible = false;
            txtResultado.Visible = false;
            lblPN.Visible = false;
            lblR.Visible = false;
            lblSN.Visible = false;
        }
        private void ExponenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtPrimN.Text);
            num2 = Convert.ToDouble(txtPrimN.Text);
            if (num1 <0)
            {
                MessageBox.Show("Ingresa un numero positvo");
                return;
            }
            txtResultado.Visible = true;
            lblR.Visible = true; 
            cuadrado = Math.Pow(num1, num2);
            txtResultado.Text = cuadrado.ToString();
            MessageBox.Show("Tu el resultado de tu potencia es\n" + cuadrado.ToString());
            if (DialogResult != DialogResult.OK)
            {
                txtPrimN.Clear();
                TxtSN.Clear();
                txtResultado.Clear();
                txtResultado.Visible = false;
                lblR.Visible = false;
            }
        }
        private void iniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtPrimN.Visible = true;
            TxtSN.Visible = true;
            lblPN.Visible = true;
            lblSN.Visible = true;
        }
        private void txtPrimN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TxtSN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtResultado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
