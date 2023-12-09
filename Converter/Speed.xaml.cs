using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Converter
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Speed : ContentPage
    {
        public Speed()
        {
            InitializeComponent();
        }
        public void Button_Click(object sender, EventArgs e)
        {
            double count = Convert.ToDouble(entry.Text);
            if (input.SelectedIndex == 0)       // 0 - MilePH, 1 - KmPH, 2 - MPS.
            {
                if (output.SelectedIndex == 1)
                    count *= 1.609344;
                else if (output.SelectedIndex == 2)
                    count /= 2.23693629205;
            }
            else if (input.SelectedIndex == 1)
            {
                if (output.SelectedIndex == 0)
                    count /= 1.609344;
                else if (output.SelectedIndex == 2)
                    count = count * 5 / 18;
            }
            else
            {
                if (output.SelectedIndex == 0)
                    count *= 2.23693629205;
                else if (output.SelectedIndex == 1)
                    count *= 3.6;
            }
            result.Text = count.ToString();
        }

        private void Button_Click_Reverse(object sender, EventArgs e)
        {
            int one = input.SelectedIndex;
            int two = output.SelectedIndex;

            one = one + two;
            two = one - two;
            one = one - two;

            input.SelectedIndex = one;
            output.SelectedIndex = two;
        }
    }
}