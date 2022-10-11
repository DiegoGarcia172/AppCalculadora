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
    public partial class FrmRedondeo : Form
    {
        double num1;
        public FrmRedondeo()
        {
            InitializeComponent();
            TxtPrimN.Visible = false;
            lblPN.Visible = false;
            lblR.Visible = false;
            TxtResultado.Visible = false;
        }
        private void RedondeoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TxtPrimN.TextLength == 0)
            {
                MessageBox.Show("Antes de redondear agrega un numero");
                return;
            }
            TxtResultado.Visible = true;
            lblR.Visible = true;
            num1 = double.Parse(TxtPrimN.Text);
            int i = (int)Math.Round(num1);
            TxtResultado.Text = i.ToString();
            MessageBox.Show("Tu el resultado de tu redondeo es\n" + i.ToString());
            if (DialogResult != DialogResult.OK)
            {
                TxtResultado.Visible = false;
                lblR.Visible = false;
                TxtPrimN.Clear();
                TxtResultado.Clear();
            }
        }
        private void iniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TxtPrimN.Visible = true;
            lblPN.Visible = true;
        }
        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }
        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void TxtPrimN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void TxtResultado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
