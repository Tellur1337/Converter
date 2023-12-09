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
    public partial class Energy : ContentPage
    {
        public Energy()
        {
            InitializeComponent();
        }
        public void Button_Click(object sender, EventArgs e)
        {
            double count = Convert.ToDouble(entry.Text);
            if (input.SelectedIndex == 0)       // 0 - джоуль, 1 - квт*ч, 2 - калорий.
            {
                if (output.SelectedIndex == 1)
                    count /= 3600000;
                else if (output.SelectedIndex == 2)
                    count /= 4.1868;
            }
            else if (input.SelectedIndex == 1)
            {
                if (output.SelectedIndex == 0)
                    count *= 3600000;
                else if (output.SelectedIndex == 2)
                    count *= 859845.22785899;
            }
            else
            {
                if (output.SelectedIndex == 0)
                    count *= 4.1868;
                else if (output.SelectedIndex == 1)
                    count /= 859845.22785899;
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
