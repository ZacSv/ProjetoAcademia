using Microsoft.AspNetCore.Mvc;
using ProjetoSiteAcademia.Models;
using ProjetoSiteAcademia.Services;
namespace ProjetoSiteAcademia.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;
        private readonly ILoginService _loginService;

        public AccountController(IUserService userService, ILoginService loginService)
        {
            _userService = userService;
            _loginService = loginService;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
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
                try
                {
                    if (ModelState.IsValid)
                    {
                        _userService.CreateUser(usuario);
                    }

                    return View("Login");
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

        public ActionResult Login(UserModel user)
        {
            if (_loginService.LoginUser(user))
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Email ou senha inválido");
                return View();
            }
        }
    }
}