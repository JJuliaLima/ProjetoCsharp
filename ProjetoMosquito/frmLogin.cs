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
    public partial class frmLogin : Form  
    {
        public frmLogin() // metodo construtor mesmo nome da classe principal
        {
            InitializeComponent();  //executa metodo
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e) //metodo executado dentro de outro metodo/função
        {
            //Close();
            //this.Close(); this= aponta classe mais proxima
            Application.Exit();  // fecha toda aplicação
        }
    }
}
