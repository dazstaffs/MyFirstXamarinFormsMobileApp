using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AwesomeApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        //private string[] chatUpLines;
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnYesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ArrangeMOT());
        }

        private void btnNoClicked(object sender, EventArgs e)
        {

        }

    }
}
