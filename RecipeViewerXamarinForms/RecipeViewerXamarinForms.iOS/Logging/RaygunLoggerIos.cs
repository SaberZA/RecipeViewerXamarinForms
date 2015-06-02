using Mindscape.Raygun4Net;
using RecipeViewerXamarinForms.iOS.Logging;
using Xamarin.Forms;

[assembly: Dependency(typeof(RaygunLoggerIos))]
namespace RecipeViewerXamarinForms.iOS.Logging
{
    public class RaygunLoggerIos : ILogger
    {
        public void LoadLogger()
        {
            RaygunClient.Attach("FWrCAqt5HnayPOTkiozuYA==");
        }
    }
}