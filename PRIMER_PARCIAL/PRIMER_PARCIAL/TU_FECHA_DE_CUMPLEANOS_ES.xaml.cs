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
    public partial class TU_FECHA_DE_CUMPLEANOS_ES : ContentPage
    {
        public TU_FECHA_DE_CUMPLEANOS_ES()
        {
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
            ADIVINAR.Clicked += ADIVINAR_Clicked;
        }

        private void ADIVINAR_Clicked(object sender, EventArgs e)
        {
            var fecha = FECHA.Text;
            var numero = Convert.ToInt64(fecha);
            var resultado = numero - 365;
            var convert2 = Convert.ToString(resultado);
            var longitud = convert2.Length;
            if (longitud != 4)
            {
                var dia = convert2.Substring(0, longitud - 2);
                var mes = convert2.Substring(longitud - 2);
                var fin = "0"+dia + " / " + mes;
                CUMPLE.Text = fin.ToString();
            }
            else
            {
                var dia = convert2.Substring(0, longitud - 2);
                var mes = convert2.Substring(longitud - 2);
                var fin = dia + " / " + mes;
                CUMPLE.Text = fin.ToString();
            }
        }
    }
}