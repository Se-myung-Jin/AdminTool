using System.Linq;
using AdminTool.DataContext;
using AdminTool.Models;
using AdminTool.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdminTool.Controllers
{
    public class AdminController : Controller
    {
        /// <summary>
        /// 로그인
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(AdminUserView model)
        {
            if (ModelState.IsValid)
            {
                using (var db = new AdminUserContext())
                {
                    var key = Util.GetMd5Hash(Util.key);

                    var user = new AdminUser
                    {
                        UserID = Util.Encrypt(model.UserID, key),
                        UserPassword = Util.Encrypt(model.UserPassword, key)
                    };

                    var searchUser = db.User.FirstOrDefault(u => u.UserID.Equals(user.UserID) && u.UserPassword.Equals(user.UserPassword));

                    if (searchUser != null)
                    {
                        HttpContext.Session.SetInt32("USER_UUID", searchUser.UserNo);
                        return RedirectToAction("Index", "Home");
                    }
                }
                ModelState.AddModelError(string.Empty, "사용자 ID 혹은 비밀번호가 일치하지 않습니다.");
            }
            return View(model);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("USER_UUID");

            return RedirectToAction("Login", "Admin");
        }

        /// <summary>
        /// 회원가입
        /// </summary>
        /// <returns></returns>
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(AdminUser model)
        {
            if (ModelState.IsValid)
            {
                var key = Util.GetMd5Hash(Util.key);

                using (var db = new AdminUserContext())
                {
                    var newUser = new AdminUser
                    {
                        UserID = Util.Encrypt(model.UserID, key),
                        UserPassword = Util.Encrypt(model.UserPassword, key)
                    };
                    db.User.Add(newUser);
                    db.SaveChanges();
                }
                return RedirectToAction("Login", "Admin");
            }
            return View(model);
        }
    }
}