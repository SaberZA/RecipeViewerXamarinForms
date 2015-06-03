using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using RecipeViewerXamarinForms.ViewModels;

namespace RecipeViewerXamarinForms
{
    public partial class MyPage : ContentPage
    {
        public string MainText { get; set; }
        public MyPage()
        {
            InitializeComponent();
            MainText = "Hello Xamarin";
			BindingContext = new MyPageViewModel {
				Message = "Hello Sweet World!"
			};

//            boxViewColor.Color = Color.Blue;
        }
    }
}
