using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Mindscape.Raygun4Net;
using RecipeViewerXamarinForms.Droid.Logging;
using Xamarin.Forms;

[assembly: Dependency(typeof(RaygunLoggerAndroid))]
namespace RecipeViewerXamarinForms.Droid.Logging
{
    public class RaygunLoggerAndroid : ILogger
    {
        public void LoadLogger()
        {
            RaygunClient.Attach("FWrCAqt5HnayPOTkiozuYA==");
        }
    }
}