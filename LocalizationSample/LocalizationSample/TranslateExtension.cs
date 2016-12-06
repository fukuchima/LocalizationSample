using System;
using System.Resources;
using Xamarin.Forms.Xaml;

namespace LocalizationSample
{
    public class TranslateExtension : IMarkupExtension
    {
        public string Key { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (string.IsNullOrEmpty(Key))
                return "Error";

            ResourceManager resmgr = Resources.AppResources.ResourceManager;
            return resmgr.GetString(Key) ?? "Error";
        }
    }
}
