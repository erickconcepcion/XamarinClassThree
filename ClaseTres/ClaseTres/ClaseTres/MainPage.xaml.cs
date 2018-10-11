using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ClaseTres
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Comidas = new FoodGenerator().GenerateFood();
            lstComidas.ItemsSource = Comidas;
        }
        List<Comida> Comidas { get; set; }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            lstComidas.BeginRefresh();
            if (string.IsNullOrWhiteSpace(e.NewTextValue))
            {
                lstComidas.ItemsSource = Comidas;
            }
            else
            {
                lstComidas.ItemsSource = Comidas.Where(x => 
                x.Nombre.ToLower().Contains(e.NewTextValue.ToLower())
                ||
                x.Descripcion.ToLower().Contains(e.NewTextValue.ToLower()
                ));
            }
            lstComidas.EndRefresh();
        }

        private void ViewCell_Tapped(object sender, EventArgs e)
        {
                        
            Navigation.PushAsync(new ProfilePage((Comida)((ViewCell)sender).BindingContext));
        }
    }
}
