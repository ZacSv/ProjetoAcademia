using Microsoft.Data.SqlClient;
using ProjetoSiteAcademia.Models;
namespace ProjetoSiteAcademia.Services
{
    //Serviço para criação de um usuário
    public class UserService : IUserService
    {
        public const string CONNECTION_STRING = @"Server=localhost,1433;Database=BLOG;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=true";

        public UserModel CreateUser(UserModel user)
        {

            try
            {
                using (var connection = new SqlConnection(CONNECTION_STRING))
                {
                    connection.Open();
                    Console.WriteLine("Banco conectado com sucesso !");
                    var query = "INSERT INTO USERS VALUES (@USERNAME, @EMAIL, @PASSWORD)";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@USERNAME", value: user.USERNAME);
                        command.Parameters.AddWithValue("@EMAIL", value: user.EMAIL);
                        command.Parameters.AddWithValue("@PASSWORD", value: user.PASSWORD);
                        int rows = command.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            Console.WriteLine("Usuário inserido com sucesso");
                        }
                        else
                        {
                            Console.WriteLine("Falha ao inserir o usuário");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Algo deu errado" + ex.Message);

            }

            return user;

        }
    }

}