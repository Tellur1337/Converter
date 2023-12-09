using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Converter
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            string classId = button.ClassId;


            switch (classId)
            {
                case "Long":
                    await Navigation.PushAsync(new Long());
                    break;
                case "Speed":
                    await Navigation.PushAsync(new Speed());
                    break;
                case "Energy":
                    await Navigation.PushAsync(new Energy());
                    break;
                case "Square":
                    await Navigation.PushAsync(new Square());
                    break;
                case "Weight":
                    await Navigation.PushAsync(new Weight());
                    break;
                default:
                    break;
            }
        }
    }
}
