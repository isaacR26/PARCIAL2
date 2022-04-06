using PARCIAL2.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PARCIAL2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class descripcion : ContentPage
    {
        public descripcion(product showProduct)
        {
            InitializeComponent();
            
            txtnombre.Text = showProduct.nombre;
            txtprecio.Text = Convert.ToString(showProduct.precio);
            txtdesc.Text = showProduct.desc;


            
           

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var nproduct = double.Parse(txtNproduc.Text);
            var precio = double.Parse(txtprecio.Text);

            var Valorcuneta = nproduct * precio;
            var Valorpropina = double.Parse(txtporcentaje.Text) / 100;
            var porc = Valorcuneta * Valorpropina;
            var Valortotal = Valorcuneta + porc;
            var xpersona = Valortotal / double.Parse(txtNpersonas.Text);
            aportepers.Text = Convert.ToString(xpersona);
            valortotal.Text = Convert.ToString(Valorcuneta);
            valorpropina.Text = Convert.ToString(porc);

            valorcuenta.Text = Convert.ToString(Valortotal);

        }
    }
}