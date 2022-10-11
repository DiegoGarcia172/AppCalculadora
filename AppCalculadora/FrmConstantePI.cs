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
    public partial class FrmConstantePI : Form
    {
        public FrmConstantePI()
        {
            InitializeComponent();
        }

        private void ConstantePiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtPrimN.TextLength == 0)
            {
                MessageBox.Show("Primero inserta un numero");
            }
            txtResultado.Text = (Math.PI * 2 * double.Parse(txtPrimN.Text)).ToString();
            MessageBox.Show("Tu el resultado de tu constante es\n" + (Math.PI * 2 * double.Parse(txtPrimN.Text)).ToString());
            if (DialogResult != DialogResult.OK)
            {
                txtPrimN.Clear();
                txtResultado.Clear();
            }
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
        private void txtPrimN_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
