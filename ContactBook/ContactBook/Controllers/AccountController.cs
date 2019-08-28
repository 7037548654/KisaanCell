using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactBook.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ContactBook.Controllers
{
    public class AccountController : Controller
    {
        private readonly ContactBookContext _context;

        public AccountController(ContactBookContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            LogOnModel model = new LogOnModel();
            return View("~/Views/Account/Index.cshtml", model);
            
        }
        public IActionResult SignUp()
        {
            SignUpModel model = new SignUpModel();
            return View("~/Views/Account/SignUp.cshtml", model);

        }

        public IActionResult DoLogon(LogOnModel model)
        { 
            string username = model.Username;
            string password = model.Password;
            string type = model.type;
            var sql = from u in _context.User
                      where u.Username == username && u.Password == password && u.type == type
                      select u;
            var data=from d in _context.User
                      where d.Username == username && d.Password == password && d.type == type
                      select d.UserId;


            if (sql.Count() > 0 && data.Count() > 0)
            {
                HttpContext.Session.SetString("Username", username);
                HttpContext.Session.SetString("Type", type);
                HttpContext.Session.SetInt32("UserId", data.First());
                if (type == "Seller")
                {
                    return RedirectToAction("index", "Contacts");
                }
                else if (type == "Buyer")
                {
                    return RedirectToAction("index", "Buyer");
                }
                else {
                    return RedirectToAction("index");
                }
            }
            else
                return RedirectToAction("index");

        }
        public IActionResult DoSignUp(SignUpModel model)
        {
            if (!ModelState.IsValid)
            {

                return View("~/Views/Account/SignUp.cshtml", model);
            }
            User user = new User();
            
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.Username = model.Username;
            user.Password = model.Password;
            user.DOB = model.DOB;
            user.Address = model.Address;
            user.Cell = model.Cell;
            user.type = model.type;
            _context.Update(user);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("index");
        }
        
            }
}