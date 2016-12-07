using System;
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
            // イベントの処理
            button.Clicked += (sender, e) => {
                count += 1;
                label.Text = String.Format(AppResources.TouchMSG, count.ToString());
            };

        }
    }
}
