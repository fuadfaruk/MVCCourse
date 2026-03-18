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
    }
}
