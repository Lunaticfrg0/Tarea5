using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Internals;

namespace Tarea5.Services
{
    public interface IGetDeviceOrientationService
    {
        DeviceOrientation GetOrientation();   
    }
}
