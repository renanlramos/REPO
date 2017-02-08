using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class clAcessoDB
    {
        //variável para receber a string de conexão
        public string vConexao = "";

        //método responsável por abrir a conexão com o banco
        //de dados

        public SqlConnection AbreBanco()
        {
            //Abre a Conexão com a Base de Dados
            SqlConnection conn = new SqlConnection(vConexao);
            conn.Open();
            return conn;
        }

    }
}
