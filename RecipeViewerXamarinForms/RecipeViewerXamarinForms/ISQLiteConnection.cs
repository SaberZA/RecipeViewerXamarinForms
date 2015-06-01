using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net;

namespace RecipeViewerXamarinForms.ORM
{
    public interface ISQLiteConnection
    {
        SQLiteConnection GetConnection();
    }
}
