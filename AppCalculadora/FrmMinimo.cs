using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppCalculadora
{
    public partial class FrmMinimo : Form
    {
        double numero1, numero2;
        
        public FrmMinimo()
        {
            InitializeComponent();
            LblPN.Visible = false;
            LblR.Visible = false;
            LblSN.Visible = false;
            TxtPrimN.Visible = false;
            TxtResultado.Visible = false;
            TxtSegundoNum.Visible = false;
        }
        private void IniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TxtPrimN.Visible = true;
            TxtSegundoNum.Visible = true;
            LblSN.Visible = true;
            LblPN.Visible = true;
        }
        private void MinimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TxtPrimN.TextLength == 0 )
            {
                MessageBox.Show("Primero inserta un numero");
            }
           numero1 = double.Parse(TxtPrimN.Text);
           numero2 = double.Parse(TxtSegundoNum.Text);
           if (Math.Max(numero1, numero2) == numero1)
           {
             TxtResultado.Visible = true;
             LblR.Visible = true;
             TxtResultado.Text = "Max = " + numero1 + " Min = " + numero2;
             MessageBox.Show("Max = " + numero1 + " Min = " + numero2);
             if (DialogResult != DialogResult.OK)
             {
                TxtPrimN.Clear();
                TxtSegundoNum.Clear();
                TxtResultado.Clear();
                TxtResultado.Visible = false;
                LblR.Visible = false;
             }
              return;
           }
           else
           {
                TxtResultado.Visible = true;
                LblR.Visible = true;
                TxtResultado.Text = "Max = " + numero2 + " Min = " + numero1;
           }
            MessageBox.Show("Max = " + numero2 + " Min = " + numero1);
            if (DialogResult != DialogResult.OK)
            {
                TxtPrimN.Clear();
                TxtSegundoNum.Clear();
                TxtResultado.Clear();
                TxtResultado.Visible = false;
                LblR.Visible = false;
            }
        }
        private void MenuDeOperacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }
        private void TxtPrimN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtSegundoNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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
        private void CerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
