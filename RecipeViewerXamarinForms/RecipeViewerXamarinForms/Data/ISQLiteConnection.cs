using SQLite.Net;

namespace RecipeViewerXamarinForms.Data
{
    public interface ISQLiteConnection
    {
        SQLiteConnection GetConnection();
    }
}
