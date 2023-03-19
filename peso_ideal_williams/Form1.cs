using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace peso_ideal_williams
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool radioSelecionado = false;
        private void changePesoIdeal ()
        {
            if (radioSelecionado)
            {
                try
                {
                    double altura = Convert.ToDouble(fmAltura.Text);

                    if (radioMasc.Checked)
                    {
                        lblPesoIdeal.Text = ((72.7 * altura) - 58).ToString();
                    }
                    else if (radioFem.Checked)
                    {
                        lblPesoIdeal.Text = ((62.1 * altura) - 44.7).ToString();
                    }
                }
                catch (Exception e)
                {
                    //MessageBox.Show("Insira os dados corretamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
            
        }



        private void fmAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            changePesoIdeal();
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !e.Equals(".") && !(e.KeyChar.ToString() == ","))
            {
                e.Handled = true;
            }

        }

        private void radioCheckedChanged(object sender, EventArgs e)
        {
            radioSelecionado = true;
            changePesoIdeal();
        }
    }
}
