using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TareaMVVMByMarvinMMM.Views;

namespace TareaMVVMByMarvinMMM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new EmpleadosPage();
            //MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
