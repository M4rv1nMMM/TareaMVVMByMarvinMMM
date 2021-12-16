using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaMVVMByMarvinMMM.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TareaMVVMByMarvinMMM.ViewModel;

namespace TareaMVVMByMarvinMMM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AgregarEmpleadoPage : ContentPage
    {
        public AgregarEmpleadoPage()
        {
            InitializeComponent();
            BindingContext = new EmpleadoViewModel();
        }

        private async void btnAgregar_Clicked(object sender, EventArgs e)
        {
            if (validardata())
            {
                Empleado emp = new Empleado
                {
                    Nombre = txtNombre.Text,
                    Apellidos = txtApellidos.Text,
                    Edad = Convert.ToInt32(txtEdad.Text),
                    Direccion = txtDireccion.Text,
                    Puesto = txtPuesto.Text
                };
                await App.SQLiteBD.SavedEmpleadoAsync(emp);
                await DisplayAlert("Registro", "Se guardo exitosamente", "Ok");
                await Navigation.PushAsync(new EmpleadosPage());
            }
            else
            {
                await DisplayAlert("Advertencia", "Ingresar todos los datos", "Ok");
            }
        }
        public bool validardata()
        {
            bool resp;
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                resp = false;
            }
            else if (string.IsNullOrEmpty(txtApellidos.Text))
            {
                resp = false;
            }
            else if (string.IsNullOrEmpty(txtEdad.Text))
            {
                resp = false;
            }
            else if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                resp = false;
            }
            else if (string.IsNullOrEmpty(txtPuesto.Text))
            {
                resp = false;
            }
            else
            {
                resp = true;
            }
            return resp;
        }
    }
}