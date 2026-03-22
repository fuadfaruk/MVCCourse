using Microsoft.AspNetCore.Mvc;
using MVCCourse.Models;
using System.ComponentModel;

namespace MVCCourse.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            var categories = CategoryRepository.GetCategories();
            return View(categories);
        }

        public IActionResult Edit(int? id)
        {
            var category = CategoryRepository.GetCategoryById(id ?? 0);
            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                CategoryRepository.UpdateCategory(category.CategoryId, category);
                return RedirectToAction(nameof(Index));
            }

            return View(category);
        }

        public IActionResult Add()
        {
            var category = new Category();
            return View(category);
        }

        [HttpPost]
        public IActionResult Add(Category category)
        {
            if (ModelState.IsValid)
            {
                CategoryRepository.AddCategory(category);
                return RedirectToAction(nameof(Index));
            }

            return View(category);
        }
    }
}
