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

namespace _3C1PEDRO33.UI
{
    public partial class Form2 : Form
    {
        //Criação dos objetos que acessam a camada de negócio
        GamesBLL medbll = new GamesBLL();
        GamesDTO meddto = new GamesDTO();
        public Form2()
        {
            InitializeComponent();
            dataGridView1.DataSource = medbll.Listar();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //Preenchimento do objeto 
            meddto.Id = int.Parse(txt_id.Text);
            meddto.Videogames = txt_videogames.Text;
            meddto.Perifericos = txt_perifericos.Text;
            meddto.Games= txt_games.Text;

            //Envio do dto preenchido para o método inserir
            medbll.Inserir(meddto);

            //mensagem de cadastrado 
            MessageBox.Show("Cadastrado com sucesso!", "jogos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = medbll.Listar();
            //limpar campos
            txt_id.Clear();
            txt_games.Clear();
            txt_videogames.Clear();
            txt_perifericos.Clear();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //Preenchimento do objeto 
            meddto.Id = int.Parse(txt_id.Text);
            meddto.Videogames = txt_videogames.Text;
            meddto.Perifericos = txt_perifericos.Text;
            meddto.Games = txt_games.Text;

            //Envio do dto preenchido para o método inserir
            medbll.Editar(meddto);

            //mensagem de cadastrado 
            MessageBox.Show("Cadastrado com sucesso!", "jogos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = medbll.Listar();
            //limpar campos
            txt_id.Clear();
            txt_games.Clear();
            txt_videogames.Clear();
            txt_perifericos.Clear();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //Preenchimento do objeto 
            meddto.Id = int.Parse(txt_id.Text);
            meddto.Videogames = txt_videogames.Text;
            meddto.Perifericos = txt_perifericos.Text;
            meddto.Games = txt_games.Text;

            //Envio do dto preenchido para o método inserir
            medbll.Excluir(meddto);

            //mensagem de cadastrado 
            MessageBox.Show("Cadastrado com sucesso!", "jogos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = medbll.Listar();
            //limpar campos
            txt_id.Clear();
            txt_games.Clear();
            txt_videogames.Clear();
            txt_perifericos.Clear();
        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
