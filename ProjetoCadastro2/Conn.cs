using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCadastro2
{
    class Conn
    {
        
        private static string server = @"(localdb)\MSSQLLocalDB";
        private static string dataBase = "Cadastro";
        private static string user = "sa";
        private static string password = "senha";

        public static string StrCon
        {
            get { return $"Data Source ={server}; Integrated Security=true;Initial Catalog={dataBase}; User ID ={user}; Password={password}"; }
        }
    }
}
