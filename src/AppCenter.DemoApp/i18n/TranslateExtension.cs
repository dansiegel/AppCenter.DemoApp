using System;
using System.Collections.Generic;
using System.Reflection;
using System.Resources;
using System.Text;
using AppCenter.DemoApp.Resources;
using Plugin.Multilingual;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCenter.DemoApp.i18n
{
    // You exclude the 'Extension' suffix when using in Xaml markup
    [ContentProperty(nameof(Text))]
    internal class TranslateExtension : IMarkupExtension
    {
        private const string ResourceId = "AppCenter.DemoApp.Resources.AppResources";

        private static readonly Lazy<ResourceManager> resmgr = new Lazy<ResourceManager>(() => new ResourceManager(ResourceId, typeof(TranslateExtension).GetTypeInfo().Assembly));

        public string Text { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            var ci = CrossMultilingual.Current.CurrentCultureInfo;

            var translation = resmgr.Value.GetString(Text, ci);

            if (translation == null)
            {
#if DEBUG
                throw new ArgumentException($"Key '{Text}' was not found in resources '{ResourceId}' for culture '{ci.Name}'.", nameof(Text));
#else
                translation = Text; // returns the key, which GETS DISPLAYED TO THE USER
#endif
            }
            return translation;
        }
    }
}
