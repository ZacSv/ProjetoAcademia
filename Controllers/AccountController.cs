using Microsoft.AspNetCore.Mvc;
using ProjetoSiteAcademia.Models;
using ProjetoSiteAcademia.Services;
namespace ProjetoSiteAcademia.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;

        public AccountController(IUserService userService)
            => _userService = userService;

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Register(UserModel user)
        {
            if (user != null)
            {
                UserModel usuario = new UserModel();
                usuario.USERNAME = user.USERNAME;
                usuario.EMAIL = user.EMAIL;
                usuario.PASSWORD = user.PASSWORD;
                Console.WriteLine(user);
                try
                {
                    if (ModelState.IsValid)
                    {
                        Console.WriteLine(usuario);
                        _userService.CreateUser(usuario);
                        ViewBag.NAME = user.USERNAME;
                        ViewBag.EMAIL = user.EMAIL;
                        ViewBag.PASSWORD = user.PASSWORD;
                    }

                    return View(user);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Houve algum erro:" + ex.Message);
                    return View(user);
                }
            }
            else
            {
                Console.WriteLine("O usuário não foi criado, job abortado");
            }
            return View();

        }
    }
}