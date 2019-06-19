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
            var layout = new StackLayout { Padding = new Thickness(5, 10) };
            var label = new Label { Text = "\"You have the most beautiful eyes...\"", TextColor = Color.FromHex("#7F00FF"), FontSize = 30 };
            var button = new Button { Text = "Give Me a New Chat Up Line", TextColor = Color.FromHex("#000000"), FontSize = 20 };
            layout.Children.Add(label);
            layout.Children.Add(button);
            this.Content = layout;

            //chatUpLines[0] = "Heaven must be missing an angel.";
            //chatUpLines[1] = "I may not be Fred Flintstone, but I can make your bed rock.";
            //chatUpLines[2] = "God damn, your mother must be proud.";
        }
    }
}
