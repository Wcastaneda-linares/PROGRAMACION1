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
    public partial class TU_NUMERO_ES : ContentPage
    {
        public TU_NUMERO_ES()
        {
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
            CALCULAR.Clicked += CALCULAR_Clicked;
        }

        private void CALCULAR_Clicked(object sender, EventArgs e)
        {
            var enter = escribir.Text;
            var largo = enter.Length;
            var nuevo = enter.Substring(0, largo - 1);
            var convert = Convert.ToInt32(nuevo);
            var fin = convert - 4;
            FINAL.Text = fin.ToString();
        }
    }
}