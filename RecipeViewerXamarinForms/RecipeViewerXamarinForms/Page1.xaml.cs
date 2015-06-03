using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace RecipeViewerXamarinForms
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            MainText = "Test";
        }

        public string MainText { get; set; }
    }
}
