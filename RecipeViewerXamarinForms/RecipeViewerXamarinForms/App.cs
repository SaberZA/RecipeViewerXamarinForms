using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using RecipeViewerXamarinForms.Data;
using RecipeViewerXamarinForms.ORM;
using Xamarin.Forms;

namespace RecipeViewerXamarinForms
{
    public class App : Application
    {
        

        public App()
        {
            MainPage = new MyPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            
            var connection = DependencyService.Get<ISQLiteConnection>().GetConnection();
            DependencyService.Get<ILogger>().LoadLogger();

            var testSqlLiteAndroid = new TestSqlLite(connection);
            
            testSqlLiteAndroid.SetupTestDb();
            var recipesFromDb = testSqlLiteAndroid.GetRecipesFromDb();
			var recipesString = String.Join (",", recipesFromDb.Select (p => p.Name));
			Debug.WriteLine(recipesString);

//			throw new Exception ("Raising Exception with data form DB: " + recipesString);
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
