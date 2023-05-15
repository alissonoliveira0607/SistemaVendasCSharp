using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppControleVendas.Connection
{
    public class ConnectionFactory
    {
        /* Definindo classe responsável pela conexão com o banco onde o atemplate do arquivo de configuração encontra-se no App.Config */

        public MySqlConnection GetConnection()
        {
            //Definindo o ConfigurationManager com o DB
            string connection = ConfigurationManager.ConnectionStrings["bdvendas"].ConnectionString;

            //Instanciando um objeto MysqlConnection chamado conn
            MySqlConnection conn = new MySqlConnection(connection);
            return conn;
        }

    }
}
