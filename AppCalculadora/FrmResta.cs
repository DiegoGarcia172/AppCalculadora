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
    public partial class FrmResta : Form
    {
        double primernum, segunnum, resta;
        public FrmResta()
        {
            InitializeComponent();
            txtResultado.Visible = false;
            txtPrimN.Visible = false;
            txtSegundoNum.Visible = false;
            lblR.Visible = false;
            lblPN.Visible = false;
            lblSN.Visible = false;
        }
        private void IniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblPN.Visible = true;
            txtPrimN.Visible = true;
            lblSN.Visible = true;
            txtSegundoNum.Visible = true;
        }
        private void RestarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtPrimN.TextLength == 0)
            {
                MessageBox.Show("Antes inserta un numero");
            }
            else
            {
                txtResultado.Visible = true;
                lblR.Visible = true;
                primernum = Convert.ToDouble(txtPrimN.Text);
                segunnum = Convert.ToDouble(txtSegundoNum.Text);
                resta = primernum - segunnum;
                txtResultado.Text = resta.ToString();
                MessageBox.Show("Tu el resultado de tu resta es\n" + resta);
                if (DialogResult != DialogResult.OK)
                {
                    txtPrimN.Clear();
                    txtSegundoNum.Clear();
                    txtResultado.Clear();
                    txtResultado.Visible = false;
                    lblR.Visible = false;
                }
            }
        }
        private void TxtPrimN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }
        private void TxtSegundoNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }
        private void MenuDeOperacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }
        private void CerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
