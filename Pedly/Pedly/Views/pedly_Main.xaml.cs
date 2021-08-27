using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pedly.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class pedly_Main : ContentPage
    {

        public pedly_Main()
        {
            
            InitializeComponent();
            
        }


        private async void Logout_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pedly_Login());
            
        }
    }
       
}