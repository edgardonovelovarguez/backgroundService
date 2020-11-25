using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using backgroundService.Droid;
using backgroundService.ServiceInterface;
using Xamarin.Forms;
[assembly: Dependency(typeof(Coordenadas))]
namespace backgroundService.Droid
{
    public class Coordenadas : InterfaceService
    {
        public async Task<string> GetCoordenadas()
        {
            string s = "Hola";
            Toast.MakeText(Android.App.Application.Context, s, ToastLength.Short).Show();
             return s;
        }
    }
}