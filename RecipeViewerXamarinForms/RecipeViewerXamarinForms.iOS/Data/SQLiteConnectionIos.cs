using System;
using System.IO;
using RecipeViewerXamarinForms.ORM;
using RecipeViewerXamarinForms.iOS.Data;
using SQLite.Net;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteConnectionIos))]
namespace RecipeViewerXamarinForms.iOS.Data
{
    public class SQLiteConnectionIos : ISQLiteConnection
    {
        public SQLiteConnectionIos()
        {
        }

        public SQLiteConnection GetConnection()
        {
            var fileName = "Recipes.sqlite";
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, fileName);

            var platform = new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS();
            var connection = new SQLite.Net.SQLiteConnection(platform, path);

            return connection;
        }
    }
}