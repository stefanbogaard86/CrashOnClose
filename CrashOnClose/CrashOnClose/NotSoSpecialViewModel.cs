using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.ObjectModel;

namespace CrashOnClose
{
    public class NotSoSpecialViewModel : ObservableObject
    {
        public NotSoSpecialViewModel()
        {
            LongPressCommand = new AsyncCommand(LongPressAsync);
        }

        private Task LongPressAsync()
        {
            Debug.Write("Long press");
            return Task.CompletedTask;
        }

        public IAsyncCommand LongPressCommand { get; }
    }
}