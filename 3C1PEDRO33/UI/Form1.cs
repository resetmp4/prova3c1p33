using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3C1PEDRO33.CODE.BLL;
using _3C1PEDRO33.CODE.DTO;
using _3C1PEDRO33.UI;

namespace _3C1PEDRO33
{
    public partial class Form1 : Form
    {
        LoginBLL loginBLL = new LoginBLL();
        LoginDTO loginDTO = new LoginDTO();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            loginDTO.Usuario = txt1.Text;
            loginDTO.Senha = txt2.Text;

            if (loginBLL.RealizarLogin(loginDTO) == true)
            {
                Form2 games = new Form2();
                games.ShowDialog();
            }
            else
            {
                MessageBox.Show("Verifique o e-mail e senha.", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
