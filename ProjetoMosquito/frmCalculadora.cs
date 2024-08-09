using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMosquito
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        //limpar campos
        public void limparCampos ()
        {
            txtValor1.Clear();
            txtValor2.Clear();
            lblResultadobox.Text = "";
            rdbAdicao.Checked = false;
            rdbdivisao.Checked = false;
            rdbMultiplicar.Checked = false;
            rdbSubtracao.Checked = false;
            txtValor1.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, resp = 0;

            num1 = Convert.ToDouble(txtValor1.Text);
            num2 = Convert.ToDouble(txtValor2.Text); //conversão indireta

            //instaniciar a classe/objeto = usar o objeto em diferentes lugar se mudar sua estrutura / cria-se uma cópia / criar uma variavel
            // do mesmo tipo, chama metodo construtor
            // nome do objeto(tipo da variavel/operacoes) + nome da variável (criada/op)

            Operacoes op = new Operacoes();

            if (rdbAdicao.Checked)
            {
                resp = op.somar(num1, num2);
            }

            if (rdbSubtracao.Checked)
            {
                resp = op.subtrair(num1, num2);
            }

            if (rdbMultiplicar.Checked)
            {
                resp = op.multiplicar(num1, num2);
            }

            if (rdbdivisao.Checked)
            {
                if (num2==0)
                {
                    MessageBox.Show("Impossível divisão por 0",
                        "SistemaABC",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1);

                    //executar o metodo limparCampos
                    limparCampos();

                }
                else {
                    resp = op.dividir(num1, num2);
                }
               
            }
            
            lblResultadobox.Text = resp.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
    }
}
