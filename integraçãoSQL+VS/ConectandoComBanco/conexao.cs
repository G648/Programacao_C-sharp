using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectandoComBanco
{
    class Conexao
    {
        //Aqui vai a string para acessar o banco de dados
        private static string ConnStr = @"Data Source=DESKTOP-AD6KDJ2\SERVIDORTARDE;Initial Catalog=BancoDeDados;Integrated Security=True";

        //Método para conectar com a base de dados
        public static SqlConnection GetConect()
        {
            var conn = new SqlConnection(ConnStr);

            return conn;
        }
    }
}
