using System;
using System.IO;
using RecipeViewerXamarinForms.Data;
using RecipeViewerXamarinForms.Droid.Data;
using SQLite.Net;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteConnectionAndroid))]
namespace RecipeViewerXamarinForms.Droid.Data
{
    public class SQLiteConnectionAndroid : ISQLiteConnection
    {
        public SQLiteConnectionAndroid()
        {
        }

        public SQLiteConnection GetConnection()
        {
            var fileName = "Recipes.sqlite";
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, fileName);

            var platform = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
            var connection = new SQLite.Net.SQLiteConnection(platform, path);

            return connection;
        }
    }
}