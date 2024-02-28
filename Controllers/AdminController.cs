using eserL5S3.Models;
using Microsoft.AspNetCore.Mvc;

namespace eserL5S3.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View(StaticDB.Items);
        }

        public IActionResult Delete(int id)
        {
            Item item = StaticDB.GetItemById(id);

            return View(item);
        }

        [HttpPost]
        public IActionResult Delete(Item item)
        {
            Item deletedItem = StaticDB.HardDeleteItem(item.Id);

            return RedirectToAction("Index");
        }

    }
}
