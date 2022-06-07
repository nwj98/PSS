using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using SqlKata;
using SqlKata.Compilers;
using SqlKata.Execution;

namespace PSS.Database
{
    public static class DBcontext
    {
        static MySqlConnection connection = null;
        public static MySqlConnection GetConnection()
        {
            if(connection == null)
            {
                connection = new MySqlConnection
                    ("Server=localhost;Database=c#_employees;Uid=root;Pwd=root;");
            }
            
    
            return connection;
        }
        static QueryFactory db = null;
        public static QueryFactory Db()
        {
            if(db == null)
            {
                var compiler = new MySqlCompiler();
                db = new QueryFactory(GetConnection(), compiler);
            }

            return db;
        }
    }
}
