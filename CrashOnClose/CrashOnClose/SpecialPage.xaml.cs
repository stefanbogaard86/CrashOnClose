using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CrashOnClose
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SpecialPage : ContentPage
    {
        public SpecialPage()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            this.Navigation.PopModalAsync(false);
        }
    }
}