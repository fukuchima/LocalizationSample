using LocalizationSample.Resources;
using System;

using Xamarin.Forms;

namespace LocalizationSample
{
    public class MainView : ContentPage
    {
        int count = 0;
        Button button = new Button();
        Label label = new Label();

        public MainView()
        {
            Title = "ローカライズサンプル";
            button.Text = "タッチ";


            button.Clicked += Button_Clicked;
            label.HorizontalOptions = LayoutOptions.Center;

            Content = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.Center,
            
                Children = {
                    label,
                    button 
                }
            };
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            count += 1;
            label.Text = count.ToString() + "回タッチされました";
        }
    }
}
