using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RendimentoVeicular
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public static decimal ValidarDecimal(TextBox txt)
        {
            try
            {
                return Convert.ToDecimal(txt.Text);
            }
            catch
            {
                txt.Focus();
                throw new Exception("Preencha corretamente o campo" + txt.Name.ToUpper().Replace("TBX", " ")); 
            }
        }

        public void LimparTela()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = string.Empty;
                }
                else if(ctl is Label && Convert.ToInt32(ctl.Tag).Equals(1))
                {
                    ctl.Text = string.Empty;
                }
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                decimal km = ValidarDecimal(tbxKM); 
                decimal litros = ValidarDecimal(tbxLitros);

                decimal rendimento = km / litros;
                decimal consumo = litros / km;

                lblRendResul.Text = rendimento.ToString("N1");
                lblConResul.Text = consumo.ToString("N3");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Main_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Escape)
                {
                    LimparTela();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
