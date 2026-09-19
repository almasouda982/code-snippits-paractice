using Microsoft.AspNetCore.Mvc;
using WebAppInClass.Data;
using WebAppInClass.Models;
using Microsoft.AspNetCore.Authorization;
using BCrypt.Net;


namespace WebAppInClass.Controllers
{
    [Authorize]
    public class UsersController : Controller
    {
        // DI
        private readonly AppDbContext _db;

        public UsersController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<User> users = _db.Users.ToList();
            return View(users);
        }

        //======
        // Create
        //======

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(User user)
        {
            user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Please correct the errors and try again.");
                return View(user);
            }
            _db.Users.Add(user);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //======
        // Edit
        //======
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var usr = _db.Users.Find(Id);
            if (usr == null)
            {
                return NotFound();
            }
            return View(usr);
        }
        [HttpPost]
        public ActionResult Edit(User user)
        {

            if (ModelState.IsValid)
            {
                var oldUser = _db.Users.Find(user.Id);

                if (oldUser == null)
                {
                    return NotFound();
                }
                else
                {
                    oldUser.Name = user.Name;
                    oldUser.UserName = user.UserName;
                    oldUser.Email = user.Email;
                    oldUser.IsLocked = user.IsLocked;
                }

                if (!string.IsNullOrEmpty(user.Password))
                {
                    oldUser.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
                }


                _db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(user);
        }

        //==========
        // Delete
        //==========
        [HttpGet]
        public ActionResult Delete(int Id)
        {
            var usr = _db.Users.Find(Id);
            if (usr == null)
            {
                return NotFound();
            }

            return View(usr);
        }

        [HttpPost]
        public ActionResult Delete(User user)
        {

            _db.Users.Remove(user);
            _db.SaveChanges();
            return RedirectToAction("Index");



        }
    }
}
