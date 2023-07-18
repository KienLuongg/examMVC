using System;
using examMVC.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using examMVC.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace examMVC.Controllers
{
    public class ContactController : Controller
    {

        private readonly DataContext _context;
        public ContactController(DataContext dataContext)
        {
            _context = dataContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Contact> contacts = _context.Contacts.ToList<Contact>();
            return View(contacts);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ContactViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Contacts.Add(new Contact { ContactName = viewModel.ContactName });
                _context.Contacts.Add(new Contact { ContactNumber = viewModel.ContactNumber });
                _context.Contacts.Add(new Contact { GroupName = viewModel.GroupName });
                _context.Contacts.Add(new Contact { HireDate = viewModel.HireDate });
                _context.Contacts.Add(new Contact { Birthday = viewModel.Birthday });
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(viewModel);
        }
    }
}

