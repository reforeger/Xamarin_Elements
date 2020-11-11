using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_elemendid_DM
{
    float Volume_;
    float Pitch_;
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Entry_P : ContentPage
    {
        public Entry_P()
        {
            InitializeComponent();
            Volume_ = (float)vol.Value;
            Pitch_ = (float)pit.Value;
        }

        public async void Button_Clicked(object sender, EventArgs e)
        SpeechOptions settings = new SpeechOptions()
        {

            
            Volume = Volume_,
            Pitch = Pitch_,
        };
        if (text.Text !=null) { await Xamarin.Essentials.TextToSpeach.SpeakAsync(text.Text, settings); }
        else if (text.Text !=null) { await Xamarin.Essentials.TextToSpeach.SpeakAsync(text.Placeholder, settings); }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs)
        {
            Volume_ = (float).vol.Value;
        }
        private void Slider_ValueChanged1(object sender, ValueChangedEventArgs)
        {
            Pitch_ = (float).pit.Value;
        }

    }
}