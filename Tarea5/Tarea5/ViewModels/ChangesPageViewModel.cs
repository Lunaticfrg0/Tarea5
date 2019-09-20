using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Tarea5.Services;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Tarea5.ViewModels
{
   public class ChangesPageViewModel
    {
        public ICommand GetDeviceOrientation { get; set; }

        public ChangesPageViewModel()
        {
            GetDeviceOrientation = new Command(() =>
            {
            IGetDeviceOrientationService service = DependencyService.Get<IGetDeviceOrientationService>();
            DeviceOrientation orientation = service.GetOrientation();

            App.Current.MainPage.DisplayAlert("Orientation is: ", orientation.ToString(), "Ok");
            });
        }
    }
}
