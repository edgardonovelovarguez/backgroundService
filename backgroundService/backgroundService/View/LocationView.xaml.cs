using backgroundService.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace backgroundService.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LocationView : ContentPage
    {
        public LocationView()
        {
            InitializeComponent();
            BindingContext = new LocationViewModel();
        }
    }
}