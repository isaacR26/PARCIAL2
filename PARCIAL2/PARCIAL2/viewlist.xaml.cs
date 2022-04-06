using PARCIAL2.model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PARCIAL2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class viewlist : ContentPage, INotifyPropertyChanged
    {
       
        public ICommand TestReload { get; set; }

        public ICommand GoToDetailCommand { get; set; }

        private product _selectedProduct;

        public product SelectedProduct
        {
            get { return _selectedProduct; }
            set { _selectedProduct = value; OnPropertyChanged(); }
        }

        private ObservableCollection<product> _blist;

        public ObservableCollection<product> BList
        {
            get { return _blist; }
            set { _blist = value; OnPropertyChanged(); }
        }
        public viewlist()
        {
            InitializeComponent();

            ListaProductos list = new ListaProductos();

            list.xdefecto();

            BList = new ObservableCollection<product>();

            foreach (var elements in list.dataproduct)
            {
                BList.Add(new product()
                {
                    nombre = elements.nombre,
                    precio = elements.precio,
                    desc = elements.desc
                });
            }



            TestReload = new Command(() =>
            {

                var NewElements = managerlist.GList.Except(list.dataproduct).ToList();

                foreach (var listelement in NewElements)
                {
                   
                    BList.Add(new product()
                    {
                    
                    nombre = listelement.nombre,
                    precio = listelement.precio,
                    desc = listelement.desc,
                    });

                    list.dataproduct.Add(listelement);
                }
            });

            GoToDetailCommand = new Command(() =>
            {

                if (SelectedProduct != null)
                {
                    product sendProducts = new product();
                    sendProducts.nombre = SelectedProduct.nombre;
                    sendProducts.precio = SelectedProduct.precio;
                    sendProducts.desc = SelectedProduct.desc;

                    Navigation.PushAsync(new descripcion(sendProducts));

                }
            });



            BindingContext = this;
        }

       

        

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void SwipeItem_Invoked(object sender, EventArgs e)
        {
           
                    product sendProducts = new product();
                  //   sendProducts.nombre = txtnombre.text; 
                    sendProducts.precio = SelectedProduct.precio;
                    sendProducts.desc = SelectedProduct.desc;

                 await Navigation.PushAsync(new descripcion(sendProducts));

            //    }
          //  });
          

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
           
        }
    }
}