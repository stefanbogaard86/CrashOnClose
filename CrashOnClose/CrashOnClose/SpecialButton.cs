using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;
using static Xamarin.CommunityToolkit.Effects.TouchEffect;

namespace CrashOnClose
{
    public class SpecialButton : Button
    {
        public SpecialButton() => SetLongPressCommand(this, MyLongPressCommand);

        private ICommand MyLongPressCommand => new AsyncCommand(LongPressCommand);

        private Task LongPressCommand()
        {
            Debug.WriteLine("Long Press");
            return Task.CompletedTask;
        }
    }
}
