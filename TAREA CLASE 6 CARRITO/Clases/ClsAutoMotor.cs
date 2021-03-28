using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Toyota_Yaris.Clases
{

    class ClsAutoMotor
    {
        public String marca { get; }
        public int vel_max { get; }
        public int vel_min { get; }
        public int modelo { get; set; }
        public String placas { get; set; }
        public String tipo { get; set;}
        public String color { get; set; }
        private int velocidadActual = 0;
        public bool encendido { get; set;}

        public ClsAutoMotor(string marcaCarro, int MaxVel)
        {
            this.vel_max = MaxVel;
            this.marca = marcaCarro;
        }

        public String encender()
        {
            String respuesta = "";
            if (encendido)
            {
                encendido = false;
                respuesta = "Ahora esta apagado";

            }
            else
            {

                encendido = true;
                respuesta = "Esta listo, Pon waze para que no te pierdas\nPone 1 o R para Avanzar";

            }
            velocidadActual = 0;
            return respuesta;
        }

        public String DetenerMarcha()
        {
            if (encendido)
            {
                return "Deten el carro primero";
            }
            if (velocidadActual==vel_min)
            {
                velocidadActual = vel_min;
                return $"Auto Detenido";

            }
            else
            {
                velocidadActual = 0;
                return $"Vas a {velocidadActual} Km/h";
            }
        }


        public String Acelerar()
        {

            if (velocidadActual == vel_max)
            {
                velocidadActual = vel_max;
                return $"Haz el siguiente cambio {vel_max} Km/h";
            }
            else
            {
                velocidadActual = velocidadActual+10;
                return $"Vas a {velocidadActual-10} Km/h";
            }

        }
        public String Acelerar1()
        {
            if (velocidadActual == vel_max)
            {
                velocidadActual = vel_max;
                return $"Haz el siguiente cambio {vel_max} Km/h";

            }

            else
            {
                velocidadActual = 10 + 10;
                return $"Vas a {velocidadActual-10} Km/h";
            }

        }
        public String Acelerar2()
        {


            if (velocidadActual == vel_max)
            {
                velocidadActual = vel_max;
                return $"Haz el siguiente cambio {vel_max} Km/h";

            }

            else
            {
                velocidadActual = velocidadActual + 30;
                return $"Vas a {velocidadActual-10} Km/h";
            }

        }
        public String Acelerar3()
        {

            if (velocidadActual == vel_max)
            {
                velocidadActual = vel_max;
                return $"Haz el siguiente cambio {velocidadActual} Km/h";
            }

            else
            {
                velocidadActual = velocidadActual + 40;
                return $"Vas a {velocidadActual-10} Km/h";
            }

        }

        public String Acelerar4()
        {

            if (velocidadActual == vel_max)
            {
                velocidadActual = vel_max;
                return $"Parale Chatio ya llegaste al tope {vel_max} Km/h";
            }

            else
            {
                velocidadActual = 40 + 10;
                return $"Vas a  {velocidadActual-10} Km/h";
            }

        }

        public String DetenerMarcha2()
        {
            if (encendido)
            {
                return "Deten el carro primero";
            }
            if (velocidadActual == vel_min)
            {
                velocidadActual = vel_min;
                return $"Auto Detenido";

            }
            else
            {
                velocidadActual = velocidadActual+10;
                return $"Vas a {velocidadActual} Km/h";
            }

        }

    }
}
