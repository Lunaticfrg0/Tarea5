using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea5.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea5.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChangesPage : ContentPage
    {
        public ChangesPage()
        {
            InitializeComponent();
            BindingContext = new ChangesPageViewModel();
        }
    }
}