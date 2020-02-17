using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinFormsSandbox
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class OpacitySlider : ContentPage
    {
        public OpacitySlider()
        {
            InitializeComponent();

            slider.Value = 1;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Button Clicked!", "Press OK button to close this window...", "OK");
        }

    } 
}
