using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaMVVMByMarvinMMM.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareaMVVMByMarvinMMM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmpleadosPage : ContentPage
    {
        public EmpleadosPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            TraerData();

        }
        public async void TraerData()
        {
            var emplist = await App.SQLiteBD.GetEmpleadosAsync();
            if (emplist!=null)
            {
                ListViewEmpleados.ItemsSource = emplist;
            }
        }

        private async void btnAgregar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AgregarEmpleadoPage());
        }

        private async void ListViewEmpleados_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var obj = (Empleado)e.SelectedItem;
            var page = new Views.EditarEmpleadoPage();
            Empleado emp = new Empleado
            {
                IdEmpleado = Convert.ToInt32(obj.IdEmpleado.ToString())
            };
            page.BindingContext = emp;
            await Navigation.PushAsync(page);
        }
    }
}