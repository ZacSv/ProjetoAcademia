using ProjetoSiteAcademia.Models;

namespace ProjetoSiteAcademia.Services
{
    public interface ILoginService
    {
        public bool LoginUser(UserModel user);
    }

}