using Oracle.ManagedDataAccess.Client;
using System.Threading.Tasks;
namespace ProjetoSiteAcademia.Services
{
    public class DbService
    {
        private readonly string _connectionString;

        public DbService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("OracleDbConnection");
        }
    }

}