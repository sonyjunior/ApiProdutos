using Microsoft.EntityFrameworkCore;

namespace ApiProdutos
{
    internal class MySqlServerVersion
    {
        private DbContextOptionsBuilder dbContextOptionsBuilder;
        private string mySqlConnection;

        public MySqlServerVersion(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            this.dbContextOptionsBuilder = dbContextOptionsBuilder;
        }

        public MySqlServerVersion(string mySqlConnection)
        {
            this.mySqlConnection = mySqlConnection;
        }
    }
}