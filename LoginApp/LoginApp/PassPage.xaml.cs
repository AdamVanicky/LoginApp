using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PassPage : ContentPage
    {
        public PassPage()
        {
            InitializeComponent();
        }

        public PassPage(UserRecord ur)
        {
            InitializeComponent();
            BindingContext = ur;
        }

    }
}