using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace RecipeViewerXamarinForms
{
    public partial class MyPage : ContentPage
    {
        public string MainText { get; set; }
        public MyPage()
        {
            InitializeComponent();
            MainText = "Hello Xamarin";
//            boxViewColor.Color = Color.Blue;
        }
    }
}
