
using PARCIAL2.model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PARCIAL2
{
    
    public partial class MainPage : ContentPage
    {
        private ListaProductos list = new ListaProductos();
        product products = new product();

        public MainPage()
        {
            InitializeComponent();

            

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            products.nombre = txtnombre.Text;
            products.precio = int.Parse(txtprecio.Text);
            products.desc = txtdesc.Text;

            list.dataproduct.Add(products);
            managerlist.GList.Add(products);
            clear();
           
            await Navigation.PushModalAsync(new NavigationPage(new viewlist()));

        }

      
        void clear()
        {
            txtnombre.Text = "";
            txtprecio.Text = "";
            txtdesc.Text = "";
        }
    }
}
