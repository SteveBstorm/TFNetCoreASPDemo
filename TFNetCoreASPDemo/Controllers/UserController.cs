using DataAccessLayer.Services;
using Microsoft.AspNetCore.Mvc;
using TFNetCoreASPDemo.Models;
using TFNetCoreASPDemo.Tools;

namespace TFNetCoreASPDemo.Controllers
{
    public class UserController : Controller
    {
        private readonly IFakeDBContext dbContext;
        private readonly IUserService userService;

        public UserController(IFakeDBContext fakeDb, IUserService us)
        {
            dbContext = fakeDb;
            userService = us;
        }
        public IActionResult Index()
        {
            return View(userService.GetAll().Select(x => x.ToAPI()));
        }

        public IActionResult Details(int id)
        {
            return View(dbContext.GetById(id));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(UserForm form)
        {
            if(!ModelState.IsValid)
                return View(form);

            userService.Create(form.ToData().ToDAL());
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            dbContext.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            return View(dbContext.GetById(id).ToForm());
        }

        [HttpPost]
        public IActionResult Edit(UserForm u)
        {
            if (!ModelState.IsValid)
                return View(u);
            dbContext.Update(u.ToData());
            return RedirectToAction("Index");
        }
    }
}
