using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CrashOnClose
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotSoSpecialPage : ContentPage
    {
        public NotSoSpecialPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync(false);
        }
    }
}