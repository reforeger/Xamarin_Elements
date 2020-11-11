using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_elemendid_DM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Entry_P : ContentPage
    {
        public Entry_P()
        {

        }

        public async void Button_Clicked(object sender, EventArgs e)

        {
            InitializeComponent();
            Volume = Volume_,
            Pitch = Pitch_,
        };
        if (text.Text !=null) { await Xamarin.Essentials.TextToSpeach.SpeakAsync(text.Text, settings); }
        private void Slider_ValueChanged(object sender, ValueChangedEventArgs)
            )

    }
}