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
                // Port=3306 or Port=3307
                connection = new MySqlConnection
                    ("Server=localhost;Port=3307;Database=c#_employees;Uid=root;Pwd=root;");
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
