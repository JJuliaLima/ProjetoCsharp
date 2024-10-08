﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProjetoMosquito
{
    public partial class frmLogin : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);


        public frmLogin() // metodo construtor mesmo nome da classe principal
        {
            InitializeComponent();  //executa metodo
        }

        private void btnSair_Click(object sender, EventArgs e) //metodo executado dentro de outro metodo/função
        {
            //Close();
            //this.Close(); this= aponta classe mais proxima
            Application.Exit();  // fecha toda aplicação
        }

       
        public void limparcampos()
        {
            txtUsuario.Clear();
            txtSenha.Clear();
            txtUsuario.Focus();
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            } 
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.Focus();
            }
        }

       
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("senac") && txtSenha.Text.Equals("senac"))
            {

                frmMenuPrincipal abrir = new frmMenuPrincipal(); //instancia(importa), chama metodo construtor
                abrir.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("usuário ou senha inválido");
                limparcampos();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)  //executa codigo de controle de menu. bloqueia a função de fechar, maximizar janela
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }
    }
}
