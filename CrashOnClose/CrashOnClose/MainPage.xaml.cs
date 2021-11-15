using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CrashOnClose
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new SpecialPage());
        }

        private void Button_OnClicked2(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new NotSoSpecialPage());
        }
    }
}
