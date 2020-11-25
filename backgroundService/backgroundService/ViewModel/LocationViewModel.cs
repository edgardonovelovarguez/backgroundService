using backgroundService.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace backgroundService.ViewModel
{
    public class LocationViewModel
    {
        public LocationViewModel() { }

        public ICommand StarServiceCommand { get => new Command(async () => await GetMessage()); }

        private async Task GetMessage()
        {
            string data = await DependencyService.Get<InterfaceService>().GetCoordenadas();
            string f = data.ToString();

        }
    }
}
