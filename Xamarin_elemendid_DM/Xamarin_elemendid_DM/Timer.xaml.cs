using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace Xamarin_elemendid_DM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Timer : ContentPage
    {
        public Timer()
        {
            InitializeComponent();

            TImer.Clicked += btn_timer;
        }
        private void btn_timer(object sender, EventArgs e)
        {
            TImer.
        }
        private void site(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://docs.microsoft.com/en-us/dotnet/api/system.timers.timer?view=netcore-3.1" BrowserLaunchMode.SystemPreferred);
        }
    }
}