using SQLite.Net.Attributes;

namespace RecipeViewerXamarinForms.ORM
{
    public class Recipe
    {
        public Recipe(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public Recipe()
        {
        }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(1000)]
        public string Description { get; set; }
    }
}