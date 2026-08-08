using Microsoft.AspNetCore.Mvc;
using ModelsAndModelBinding.Models;

namespace ModelsAndModelBinding.Controllers
{
    public class SpellController : Controller
    {
        // Get: /Spell/Create
        [HttpGet]
        public IActionResult Create()
        {  
            return View(); 
        }

        // Post: /Spell/Create
        [HttpPost]
        public IActionResult Create(Spell spell)
        {
            if (ModelState.IsValid)
            {
                // Add spell to the database (SpellDb.Add(spell);)
                TempData["SuccessMessage"] = $"{spell.Name} (Level {spell.Level}, Rarity Tier {spell.Rarity}) was successfully inscribed into the grimoire!";
                return RedirectToAction("Index");
            }

            return View(spell);

        }

        // Get: /Spell/Index
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
