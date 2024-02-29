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


        // get e post per DELETE
        public IActionResult Delete(int id)
        {
            Item? item = StaticDB.GetItemById(id);

            return View(item);
        }

        [HttpPost]
        public IActionResult Delete(Item item)
        {
            Item? deletedItem = StaticDB.HardDeleteItem(item.Id);

            return RedirectToAction("Index");
        }

        // get e post per EDIT
        public IActionResult Edit([FromRoute] int id)
        {
            Item? item = StaticDB.GetItemById(id);

            return View(item);
        }
        [HttpPost]
        public IActionResult Edit(Item item)
        {
            Item? updatedItem = StaticDB.UpdateItem(item);

            if (updatedItem != null)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }


    }
}
