using Models;

namespace DTOs
{
    public class CategoryDTO
    {
        public int Id { get; set; }

        public string? CategoryName { get; set; }

        public CategoryDTO() { }
        public CategoryDTO(Category category) =>
            (Id, CategoryName) = (category.Id, category.CategoryName);
    }   
}