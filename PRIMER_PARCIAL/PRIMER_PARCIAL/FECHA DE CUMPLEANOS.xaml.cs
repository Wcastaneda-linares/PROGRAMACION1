using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PRIMER_PARCIAL
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FECHA_DE_CUMPLEANOS : ContentPage
    {
        public FECHA_DE_CUMPLEANOS()
        {
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
            LISTO2.Clicked += LISTO2_Clicked;
        }

        private void LISTO2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TU_FECHA_DE_CUMPLEANOS_ES());
        }
    }
}