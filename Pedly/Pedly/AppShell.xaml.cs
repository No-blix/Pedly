
using Pedly.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Pedly
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(pedly_Main), typeof(pedly_Main));
            Routing.RegisterRoute(nameof(Pedly_Login), typeof(Pedly_Login));
            Routing.RegisterRoute(nameof(Registration), typeof(Registration));
        }
    }
}
