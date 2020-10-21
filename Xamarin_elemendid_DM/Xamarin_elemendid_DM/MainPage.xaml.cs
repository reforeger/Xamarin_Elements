using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Markup;
using Xamarin.Forms.Markup.LeftToRight;

namespace Xamarin_elemendid_DM
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {

            Button Tbl_btn = new Button { Text = "Tableview" };
            Tbl_btn.BackgroundColor = Color.DarkCyan;
            StackLayout st = new StackLayout();
            st.Children.Add(Tbl_btn);
            Content = st;
            st.BackgroundColor = Color.DarkKhaki;
            st.Margin = 30;
            Tbl_btn.Clicked += Tbl_btn_Clicked;

            Button Tbl_btn1 = new Button { Text = "Entry/Editor" };
            Tbl_btn1.BackgroundColor = Color.DarkCyan;
            st.Children.Add(Tbl_btn1);
            Content = st;
            Tbl_btn1.Clicked += Tbl_btn1_Clicked;

            Button Tbl_btn2 = new Button { Text = "Listview" };
            Tbl_btn2.BackgroundColor = Color.DarkCyan;
            st.Children.Add(Tbl_btn2);
            Content = st;
            Tbl_btn2.Clicked += Tbl_btn2_Clicked;

            Button Tbl_btn3 = new Button { Text = "Datapicker" };
            Tbl_btn3.BackgroundColor = Color.DarkCyan;
            st.Children.Add(Tbl_btn3);
            Content = st;
            Tbl_btn3.Clicked += Tbl_btn3_Clicked;

            Button Tbl_btn4 = new Button { Text = "Webview" };
            Tbl_btn4.BackgroundColor = Color.DarkCyan;
            st.Children.Add(Tbl_btn4);
            Content = st;
            Tbl_btn4.Clicked += Tbl_btn4_Clicked;

            Button Tbl_btn5 = new Button { Text = "Timer" };
            Tbl_btn5.BackgroundColor = Color.DarkCyan;
            st.Children.Add(Tbl_btn5);
            Content = st;
            Tbl_btn5.Clicked += Tbl_btn5_Clicked;

            Button Tbl_btn6 = new Button { Text = "Slider and Stepper" };
            Tbl_btn6.BackgroundColor = Color.DarkCyan;
            st.Children.Add(Tbl_btn6);
            Content = st;
            Tbl_btn6.Clicked += Tbl_btn6_Clicked;


            Button Tbl_btn7 = new Button { Text = "Switch" };
            Tbl_btn7.BackgroundColor = Color.DarkCyan;
            st.Children.Add(Tbl_btn7);
            Content = st;
            Tbl_btn7.Clicked += Tbl_btn7_Clicked;

        }

        private async void Tbl_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tableview());
            
        }

        private async void Tbl_btn1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Entry_Editor());

        }

        private async void Tbl_btn2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Listview());

        }

        private async void Tbl_btn3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Datapicker());

        }

        private async void Tbl_btn4_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Webview());

        }
        private async void Tbl_btn5_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Timer());

        }
        private async void Tbl_btn6_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Slider_and_Stepper());

        }
        private async void Tbl_btn7_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Switch());

        }
    }
}
