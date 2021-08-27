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
    public partial class Pedly_Login : ContentPage
    {
        public Pedly_Login()
        {
            InitializeComponent();
      
        }

     
        private async void NewUserButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(Registration)}"); 
        }

       

        private void forgotPasswordButton_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("TRUE", "Hello World", "Ok");
        }

        private async void LoginButton_Clicked(object sender, EventArgs e)
        {
            if (true) {
                await Shell.Current.GoToAsync($"//{nameof(pedly_Main)}");
            }
            else
            {
                await Shell.Current.GoToAsync($"//{nameof(Pedly_Login)}");
            }
            
        }
    }
}