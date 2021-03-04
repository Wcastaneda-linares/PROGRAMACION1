using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PRIMER_PARCIAL
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
            PRIMERBOTON.Clicked += PRIMERBOTON_Clicked;
            SEGUNDOBOTON.Clicked += SEGUNDOBOTON_Clicked;
        }

        private void SEGUNDOBOTON_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FECHA_DE_CUMPLEANOS());
        }

        private void PRIMERBOTON_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NUMERO_QUE_ESTAS_PENSANDO());
        }
    }
}
