using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ContactBook.Models;
using Microsoft.AspNetCore.Http;

namespace ContactBook.Controllers
{
    public class BuyerController : Controller
    {
        private readonly ContactBookContext _context;

        public BuyerController(ContactBookContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index(string SearchString)
        {
            Int32 userid = Convert.ToInt32(HttpContext.Session.GetInt32("UserId"));


            if (HttpContext.Session.GetString("Username") != null)
            {
                var contact = from m in _context.Contact
                              select m;
                if (!String.IsNullOrEmpty(SearchString))
                {
                    contact = contact.Where(s => s.Item.Contains(SearchString));
                }

                return View(await contact.ToListAsync());
            }

            else
            {
                return RedirectToAction("index", "Account");
            }
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (HttpContext.Session.GetString("Username") != null)
            {
                if (id == null)
                {
                    return NotFound();
                }
                
                var contact = await _context.Contact
                    .FirstOrDefaultAsync(m => m.Id == id);

                var user = from u in _context.User
                           where u.UserId==contact.UserId
                           select u.FirstName;
                var cell = from l in _context.User
                           where l.UserId == contact.UserId
                           select l.Cell;

                HttpContext.Session.SetString("FarmerName",user.First());
                HttpContext.Session.SetString("Mobile", cell.First());
                if (contact == null)
                {
                    return NotFound();
                }

                return View(contact);
            }
            else
            {
                return RedirectToAction("Index", "Account");
            }
        }

    }
}
