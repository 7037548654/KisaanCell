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
    public class ContactsController : Controller
    {
        private readonly ContactBookContext _context;

        public ContactsController(ContactBookContext context)
        {
            _context = context;
        }

        // GET: Contacts
        public async Task<IActionResult> Index(string SearchString)
        {
            

            Int32 userid = Convert.ToInt32(HttpContext.Session.GetInt32("UserId"));


                    if (HttpContext.Session.GetString("Username") != null)
                    {
                var contact = from m in _context.Contact
                             select m;
                if (_context.Contact != null)
                {
                    contact = contact.Where(m => m.UserId == userid);
                }
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
            
            


            // GET: Contacts/Details/5
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
                if (contact == null)
                {
                    return NotFound();
                }

                return View(contact);
            }
            else
            {
                return RedirectToAction("Index","Account");
            }
        }

        // GET: Contacts/Create
        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("Username") != null)
            {

                return View();
            }
            else
            {
                return RedirectToAction("Index","Account");
            }
        }

        // POST: Contacts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Item,Quantity,Price,Location,UserId")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                contact.UserId = Convert.ToInt32(HttpContext.Session.GetInt32("UserId"));
                _context.Add(contact);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contact);
        }

        // GET: Contacts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (HttpContext.Session.GetString("Username") != null)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var contact = await _context.Contact.FindAsync(id);
                if (contact == null)
                {
                    return NotFound();
                }
                return View(contact);
            }
            else
            {
                return RedirectToAction("index","Account");
            }
        }

        // POST: Contacts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Item,Quantity,Price,Location,UserId")] Contact contact)
        {
            if (id != contact.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                
                try
                {
                    contact.UserId = Convert.ToInt32(HttpContext.Session.GetInt32("UserId"));
                    _context.Update(contact);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactExists(contact.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(contact);
        }

        // GET: Contacts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (HttpContext.Session.GetString("Username") != null)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var contact = await _context.Contact
                    .FirstOrDefaultAsync(m => m.Id == id);
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

        // POST: Contacts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contact = await _context.Contact.FindAsync(id);
            _context.Contact.Remove(contact);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactExists(int id)
        {
            return _context.Contact.Any(e => e.Id == id);
        }
    }
}

