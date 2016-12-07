﻿using LocalizationSample.Resources;
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

            //Title = "ローカライズサンプル";
            //button.Text = "タッチ";

            // リソースファイルに定義した文字列を取得して設定
            Title = AppResources.Title;
            button.Text = AppResources.buttonText;


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
            // label.Text = count.ToString() + "回タッチされました。";
            // リソースファイルに定義した文字列を取得して設定
            label.Text = String.Format(AppResources.TouchMSG, count.ToString());
        }
    }
}
