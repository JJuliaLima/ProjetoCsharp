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
    public partial class frmCalculos : Form
    {
        public frmCalculos()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //criando metodo de soma valores

        public double somaValor(double num1, double num2)
        {
            return (num1 + num2);
        }



        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Text="";
            txtNum2.Clear();  
            lblResultado.Text = ""; //clear não funciona com label
            txtNum1.Focus(); // traz foco no componente escolhido
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            // declarando variáveis
            double num1, num2, resul;

            // atribuindo valores as variáveis
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);

            // Calculo
            // resul = num1 + num2;
            resul = somaValor(num1, num2);

            //Enviando valor para a resposta
            lblResultado.Text = resul.ToString();

        }
    }
}
