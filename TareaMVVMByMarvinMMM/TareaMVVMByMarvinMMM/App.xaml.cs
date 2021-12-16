using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TareaMVVMByMarvinMMM.Views;
using TareaMVVMByMarvinMMM.Data;
using System.IO;

namespace TareaMVVMByMarvinMMM
{
    public partial class App : Application
    {
        static SQLiteHelper db;
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new EmpleadosPage());
            //MainPage = new NavigationPage(new AgregarEmpleadoPage());
            //MainPage = new NavigationPage(new EditarEmpleadoPage());
        }
        public static SQLiteHelper SQLiteBD
        {
            get
            {
                if (db == null)
                {
                    db = new SQLiteHelper(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "emple.db3"));
                }
                return db;
            }
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
