using ProjetoSiteAcademia.Models;

namespace ProjetoSiteAcademia.Services
{
    public interface IUserService
    {
        public UserModel CreateUser(UserModel user);
    }
}