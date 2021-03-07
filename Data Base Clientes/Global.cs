using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Global 
{
    class Global
    {
        //Responsavel pela coneção com o banco
        public static MySqlConnection Conexao;

        //Função responsavel pela instruçoes a serem execultadas
        public static MySqlCommand Comando;

        //Adapter responsavel por inserir dados a uma datatable
        public static MySqlDataAdapter Adaptador;

        //Responsavel por ligar o banco em controles com a propriedade DataSource
        public static DataTable datTabela;


        public static void conectar()
        {
            //Estabelece os parametros para a conexão com o banco
            Conexao = new MySqlConnection("server=localhost;uid=Luiz;pwd=800529");

            //Abre conexão com o banco de dados
            Conexao.Open();

            //Informa a instrução no SQL
            Comando = new MySqlCommand("CREAT DATABASE IF NOT EXISTS bd_Data-base-Clientes; use bd_Data-Base-Clientes", Conexao);

            //Execulta a Query no MySql (raio do workbench)
            Comando.ExecuteNonQuery();
            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS cidades" +
                                       "(id integer auto_increment primary key," +
                                        "nome char(40), " +
                                        "uf char(02))", Conexao);
            Comando.ExecuteNonQuery();

            //fecha a conexão com o banco de dados
            Conexao.Close();

        }
    }
}
