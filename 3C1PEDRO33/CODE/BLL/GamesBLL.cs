using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3C1PEDRO33.CODE.DAL;
using _3C1PEDRO33.CODE.DTO;

namespace _3C1PEDRO33.CODE.BLL
{
    internal class GamesBLL
    {
        //Objeto para acesso ao banco de dados
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "jogos";


        //O método de inserir recebe os dados via DTO 
        //e envia para o banco de dados através da classe AcessoBancoDados
        public void Inserir(GamesDTO medDto)
        {
            //Antes de criar o comando aqui, teste no PhpMyAdmin ou Worckbench
            string inserir = $"insert into {tabela} values(null,'{medDto.Games}','{medDto.Perifericos}', '{medDto.Videogames}')";
            conexao.ExecutarComando(inserir);
        }

        public void Editar(GamesDTO medDto)
        {
            string editar = $"update {tabela} set games = '{medDto.Games}', perifericos = '{medDto.Perifericos}', videogames = '{medDto.Videogames}' where id = '{medDto.Id}';";
            conexao.ExecutarComando(editar);
        }
        public void Excluir(GamesDTO medDto)
        {
            string excluir = $"delete from {tabela} where id = '{medDto.Id}';";
            conexao.ExecutarComando(excluir);
        }
        public DataTable Listar()
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarConsulta(sql);
        }

    }
}
