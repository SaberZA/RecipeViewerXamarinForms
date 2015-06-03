using System;

namespace RecipeViewerXamarinForms.ViewModels
{
	public class MyPageViewModel : BaseViewModel
	{
		private string message;
		public string Message {
			get { return message; }
			set {
				//set the new value of the message
				message = value;
				//notify the view that this has changed so it knows to refresh.
				//this comes from the base view model we created
				OnPropertyChanged ("Message");
			}
		}
		public MyPageViewModel ()
		{
			//set the default message to show
			Message = "Hello world!";
		}
	}
}

