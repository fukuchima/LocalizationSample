using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using Xamarin.Forms;
using LocalizationSample.Resources;

namespace LocalizationSample
{
    public partial class XamlMainView : ContentPage
    {
        int count = 0;
        public XamlMainView()
        {
            InitializeComponent();
            button.Clicked += Button_Clicked;

        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            count += 1;
            label.Text = String.Format(AppResources.TouchMSG, count.ToString());
        }

    }
}
