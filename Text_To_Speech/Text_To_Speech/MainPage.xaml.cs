using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
using Plugin.TextToSpeech;

namespace Text_To_Speech
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            TextToSpeech.SpeakAsync("hello ");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync(MainEntry.Text);
        }
    }
}
