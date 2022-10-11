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
    public partial class FrmRaiz : Form
    {
        Double Num, Resultado;
        public FrmRaiz()
        {
            InitializeComponent();
            txtResultado.Visible = false;
            txtPrimN.Visible = false;
            lblR.Visible = false;
            lblN.Visible = false;
        }
        private void IniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblN.Visible = true;
            txtPrimN.Visible = true;
        }
        private void RaizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Num = Convert.ToDouble(txtPrimN.Text);
            Resultado = Math.Sqrt(Num);
            if (txtPrimN.TextLength == 0)
            {
                MessageBox.Show("Antes inserta un numero");
            }
            else
            {
                txtResultado.Visible = true;
                lblR.Visible = true;
                txtResultado.Text = Resultado.ToString();
                MessageBox.Show("El resultado de la raiz es\n" + Resultado);
                if (DialogResult != DialogResult.OK)
                {
                    txtPrimN.Clear();
                    txtResultado.Clear();
                    txtResultado.Visible = false;
                    lblR.Visible = false;
                }
            }
        }
        private void MenuDeOperacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }
        private void CerrarToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
