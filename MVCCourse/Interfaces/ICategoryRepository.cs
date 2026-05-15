using Microsoft.EntityFrameworkCore;
using MVCCourse.Models;

namespace MVCCourse.Interfaces
{
    public interface ICategoryRepository
    {
        public List<Category> GetCategories();
        public Category? GetCategoryById(int categoryId);
        public void AddCategory(Category category);
        public void UpdateCategory(int categoryId, Category category);
        public void DeleteCategory(int categoryId);
    }
}
