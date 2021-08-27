using Pedly.Models;
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
    public partial class Registration : ContentPage
    {
        public Registration()
        {
            InitializeComponent();

            
           
        }

        private void backButton_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new Pedly_Login());
        }

        private void register_Clicked(object sender, EventArgs e)
        {
            User user = new User()
            {

            }; 

        }
    }
}