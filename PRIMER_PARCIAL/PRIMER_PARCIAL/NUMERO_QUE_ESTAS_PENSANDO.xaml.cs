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
    public partial class NUMERO_QUE_ESTAS_PENSANDO : ContentPage
    {
        public NUMERO_QUE_ESTAS_PENSANDO()
        {
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
            LISTO.Clicked += LISTO_Clicked;
        }

        private void LISTO_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TU_NUMERO_ES());
        }
    }
}