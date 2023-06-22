using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EP1_JuanP_Cabezas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class registro : ContentPage
    {
        string usuario;
        public registro(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = "usuario conectado" + " " + "Es" + " " + usuario;
            this.usuario = usuario;
        }

        private void btnResumen_Clicked(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string user = lblUser.Text;
            string total = txtResultado.Text;
            string dato1 = txtDato1.Text;
            string dato2 = txtDato2.Text;
            string dato3 = txtDato3.Text;
            string dato4 = txtDato4.Text;
            await Navigation.PushAsync(new Resumen(nombre, apellido, user, total, dato1, dato2, dato3, dato4));

        }

        private void btnPago_Clicked(object sender, EventArgs e)
        {

            double Monto = Convert.ToDouble(txtMonto.Text);
            double carcularPago = (1800 - Monto)/3 * 90;
            txtPago.Text = carcularPago.ToString();

        }
    }
}