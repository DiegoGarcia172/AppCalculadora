using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCalculadora
{
    public partial class FrmDivision : Form
    {
        double primernum, segunnum, Division;

        private void dividirToolStripMenuItem_Click(object sender, EventArgs e)
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
                Division = primernum / segunnum;
                txtResultado.Text = Division.ToString();
                MessageBox.Show("Tu el resultado de tu Division es\n" + Division);
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
        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }
        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPrimN_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSegundoNum_KeyPress(object sender, KeyPressEventArgs e)
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
        private void iniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblPN.Visible = true;
            txtPrimN.Visible = true;
            lblSN.Visible = true;
            txtSegundoNum.Visible = true;
        }
        public FrmDivision()
        {
            InitializeComponent();
            txtResultado.Visible = false;
            txtPrimN.Visible = false;
            txtSegundoNum.Visible = false;
            lblR.Visible = false;
            lblPN.Visible = false;
            lblSN.Visible = false;
        }
    }
}
