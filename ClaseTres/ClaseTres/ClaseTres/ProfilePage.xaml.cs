using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ClaseTres
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProfilePage : ContentPage
	{
        private Comida _comida;

        public ProfilePage ()
		{
			InitializeComponent ();
		}
        private void InnitValues()
        {
            Title = _comida.Nombre;
            ImImage.Source = _comida.ImageUrl;
            LabDescription.Text = _comida.Descripcion;
            LabDetails.Text = _comida.Details;
        }
        public ProfilePage(Comida comida)
        {
            InitializeComponent();
            _comida = comida;
            InnitValues();
        }
    }
}