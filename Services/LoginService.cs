using Microsoft.Data.SqlClient;
using ProjetoSiteAcademia.Models;

namespace ProjetoSiteAcademia.Services
{
    public class LoginService : ILoginService
    {
        public const string CONNECTION_STRING = @"Server=localhost,1433;Database=BLOG;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=true";
        public bool LoginUser(UserModel user)
        {
            bool isValid = false;
            try
            {
                using (var connection = new SqlConnection(CONNECTION_STRING))
                {
                    connection.Open();
                    Console.WriteLine("Banco conectado com sucesso !");
                    var query = "SELECT COUNT(*) FROM USERS WHERE [EMAIL] = @EMAIL AND [PASSWORD] = @PASSWORD";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EMAIL", value: user.EMAIL);
                        command.Parameters.AddWithValue("@PASSWORD", value: user.PASSWORD);
                        var count = (int)command.ExecuteScalar();
                        isValid = count > 0;
                    }
                }
                return isValid;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Algo deu errado: " + ex.Message);
            }
            return isValid;
        }
    }
}