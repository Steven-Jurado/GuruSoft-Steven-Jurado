using laboratorio.portal.Helper;
using laboratorio.portal.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace laboratorio_portal.Controllers
{
    public class HomeController : Controller
    {

        private readonly IUserMapper _userMapper;

        public HomeController(IUserMapper userMapper)
        {
            _userMapper = userMapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View();
        }


        public async Task<IActionResult> List()
        {

            var response = await _userMapper.ListUserAsync();

            return Json(response);
        }

        [HttpPost]
        public async Task<IActionResult> SaveUser(UserHelper userHelper)
        {
            try
            {
                var response = await _userMapper.SaveUserAsync(userHelper);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
