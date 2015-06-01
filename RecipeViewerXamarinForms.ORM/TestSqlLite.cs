using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite.Net;
using SQLite.Net.Interop;
using SQLite.Net.Platform.XamarinAndroid;

namespace RecipeViewerXamarinForms.ORM
{
    public class TestSqlLite
    {
        private SQLiteConnection _sqlLiteConnection;

        public TestSqlLite(SQLiteConnection sqlLiteConnection)
        {
            _sqlLiteConnection = sqlLiteConnection;
        }

        public void SetupTestDb()
        {
            _sqlLiteConnection.CreateTable<Recipe>();

            var recipeTest = new Recipe("Chicken ala King", "Cook chicken, mushrooms & cream");
            _sqlLiteConnection.Insert(recipeTest);
        }

        public List<Recipe> GetRecipesFromDb()
        {
            return _sqlLiteConnection.Table<Recipe>().ToList();
        }

        public void CloseConnection()
        {
            if (_sqlLiteConnection == null) return;
            _sqlLiteConnection.Close();
        }
    }
}
