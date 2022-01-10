using BorrowerList1.Data;
using BorrowerList1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BorrowerList1.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ItemController(ApplicationDbContext db)
        {
            _db = db;
        }
        
        public IActionResult Index()
        {
            IEnumerable<Items> objlist = _db.Item;
            return View(objlist);
        }

        //Get-Create
        public IActionResult Create() 
        {
            return View();
        }

        //POST-Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Items obj)
        {
            _db.Item.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
