using Android.App;
using Android.Widget;
using XGuidGenerator.Droid.Implementations;
using XGuidGenerator.Interfaces;

[assembly: Xamarin.Forms.Dependency(typeof(Toast_Android))]
namespace XGuidGenerator.Droid.Implementations
{
    class Toast_Android : IToast
    {
        public void Show(string message)
        {
            Toast.MakeText(Application.Context, message, ToastLength.Short).Show();
        }
    }
}