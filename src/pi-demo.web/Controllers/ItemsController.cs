using System;
using Microsoft.AspNetCore.Mvc;
using pi_demo.DataAccess;
using pi_demo.DataAccess.Entities;

namespace pi_demo.web.Controllers
{
    public class ItemsController : Controller
    {
        private readonly ItemsDatabaseContext _dbContext;

        public ItemsController(ItemsDatabaseContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public IActionResult Index()
        {
            {
                return View(_dbContext.Items);
            }
        }

        public IActionResult Create()
        {
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult Create(Item item)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Add(item);
                _dbContext.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}