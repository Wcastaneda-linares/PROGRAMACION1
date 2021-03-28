using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toyota_Yaris.Clases;
using WMPLib;

namespace Toyota_Yaris
{
    public partial class botonQuinta : Form
    {
        ClsAutoMotor carrito;
        WindowsMediaPlayer sonido;
        public botonQuinta()
        {
            InitializeComponent();
        }

        private void BotonInicio_Click(object sender, EventArgs e)
        {
            carrito = new ClsAutoMotor("Toyota Yaris",10);

            carrito.color = "Blanco";
            carrito.placas = "P-534ABC";
            carrito.modelo = 2008;
            carrito.tipo = "Automovil";
            buttonMusica.Visible = false;
            buttonMusica.Enabled = false;
            buttonAcelerar.Visible = false;
            buttonEncender.Visible = true;
            buttonFrenar.Visible = true;
            labelEstado.Visible = true;
            labelEstadoVelocidad.Visible = true;
            BotonInicio.Visible = false;
            buttonPrimera.Visible = false;
            buttonSegunda.Visible = false;
            buttonTercera.Visible = false;
            buttonCuarta.Visible = false;
            buttonRetroceso.Visible = false;
            buttonQuinta.Visible = false;
            buttonPrimera.Enabled = true;
            buttonSegunda.Enabled = false;
            buttonTercera.Enabled = false;
            buttonCuarta.Enabled = false;
            buttonQuinta.Enabled = false;
            labelVel.Visible = true;
            MessageBox.Show($"\tDATOS DEL VEHICULO \n\nMarca: {carrito.marca} \nModelo: {carrito.modelo} \nColor: {carrito.color} \nPlacas: {carrito.placas} \nVelocidad: {200} km/h");
        }

        private void buttonEncender_Click(object sender, EventArgs e)
        {
            if (sonido != null)
            {
                sonido.controls.stop();
                sonido = null;
            }
            labelEstado.Text = $"El carro {carrito.marca} : {carrito.encender()} ";
            buttonAcelerar.Visible = true;
            buttonAcelerar.Enabled = false;
            buttonPrimera.Visible = true;
            buttonSegunda.Visible = true;
            buttonTercera.Visible = true;
            buttonCuarta.Visible = true;
            buttonRetroceso.Visible = true;
            buttonQuinta.Visible = true;
            buttonPrimera.Enabled = true;
            buttonSegunda.Enabled = false;
            buttonTercera.Enabled = false;
            buttonCuarta.Enabled = false;
            buttonQuinta.Enabled = false;
            buttonMusica.Visible = true;
            buttonMusica.Enabled = true;
            labelVel.Visible = true;
        }

        private void buttonAcelerar_Click(object sender, EventArgs e)
        {
            if (carrito == null)
            {
                MessageBox.Show("Crea el carro Primero");
            }
            else
            {
                labelEstadoVelocidad.Text = carrito.Acelerar();
            }
            buttonEncender.Visible = false;
        }

        private void buttonPrimera_Click(object sender, EventArgs e)
        {
            labelEstadoVelocidad.Text = carrito.Acelerar();
            buttonEncender.Visible = true;
            buttonEncender.Enabled = true;
            buttonAcelerar.Visible = true;
            buttonAcelerar.Enabled = true;
            buttonRetroceso.Visible = true;
            buttonPrimera.Enabled = false;
            buttonSegunda.Enabled = true;
            buttonTercera.Enabled = false;
            buttonCuarta.Enabled = false;
            buttonQuinta.Enabled = false;
            labelEstado.Text = $"Limite de esta velocidad {carrito.vel_max} Km/h";
            labelVel.Text = "1";
        }

        private void buttonSegunda_Click(object sender, EventArgs e)
        {
            carrito = new ClsAutoMotor("",20);
            labelEstadoVelocidad.Text = carrito.Acelerar1();
            buttonRetroceso.Visible = true;
            buttonRetroceso.Enabled = false;
            buttonEncender.Visible = true;
            buttonEncender.Enabled = false;
            buttonPrimera.Enabled = true;
            buttonSegunda.Enabled = false;
            buttonTercera.Enabled = true;
            buttonCuarta.Enabled = false;
            buttonQuinta.Enabled = false;
            labelVel.Text = "2";
            labelEstado.Text = $"Limite de esta velocidad {carrito.vel_max} Km/h";
        }


        private void buttonTercera_Click(object sender, EventArgs e)
        {
            carrito = new ClsAutoMotor("", 30);
            labelEstadoVelocidad.Text = carrito.Acelerar2();
            buttonRetroceso.Visible = true;
            buttonRetroceso.Enabled = false;
            buttonEncender.Visible = true;
            buttonEncender.Enabled = false;
            buttonPrimera.Enabled = false;
            buttonSegunda.Enabled = true;
            buttonTercera.Enabled = true;
            buttonCuarta.Enabled = true;
            buttonQuinta.Enabled = false;
            labelVel.Text = "3";
            labelEstado.Text = $"Limite de esta velocidad {carrito.vel_max} Km/h";
        }

        private void buttonCuarta_Click(object sender, EventArgs e)
        {
            carrito = new ClsAutoMotor("", 40);
            labelEstadoVelocidad.Text = carrito.Acelerar3();
            buttonEncender.Visible = true;
            buttonEncender.Enabled = false;
            buttonRetroceso.Visible = true;
            buttonRetroceso.Enabled = false;
            buttonPrimera.Enabled = false;
            buttonSegunda.Enabled = false;
            buttonTercera.Enabled = true;
            buttonCuarta.Enabled = true;
            buttonQuinta.Enabled = true;
            labelVel.Text = "4";
            labelEstado.Text = $"Limite de esta velocidad {carrito.vel_max} Km/h";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            carrito = new ClsAutoMotor("", 200);
            labelEstadoVelocidad.Text = carrito.Acelerar4();
            buttonEncender.Visible = false;
            buttonRetroceso.Visible = true;
            buttonRetroceso.Enabled = false;
            buttonPrimera.Enabled = false;
            buttonSegunda.Enabled = false;
            buttonTercera.Enabled = false;
            buttonCuarta.Enabled = true;
            buttonQuinta.Enabled = false;
            labelVel.Text = "5";
            labelEstado.Text = $"Limite de velocidad {carrito.vel_max} Km/h";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //botonFrenar
            labelEstadoVelocidad.Text = carrito.DetenerMarcha();
            buttonEncender.Visible = true;
            buttonEncender.Enabled = true;
            buttonRetroceso.Visible = true;
            buttonRetroceso.Enabled = true;
            buttonPrimera.Enabled = true;
            buttonSegunda.Enabled = false;
            buttonTercera.Enabled = false;
            buttonCuarta.Enabled = false;
            buttonQuinta.Enabled = false;
            labelVel.Text = "Freno";
        }

        private void buttonInicio_Load(object sender, EventArgs e)
        {

        }

        private void buttonRetroceso_Click(object sender, EventArgs e)
        {
            carrito = new ClsAutoMotor("", 10);
            labelEstadoVelocidad.Text = carrito.DetenerMarcha2();
            buttonEncender.Visible = true;
            buttonEncender.Enabled = false;
            buttonAcelerar.Visible = true;
            buttonPrimera.Visible = true;
            buttonSegunda.Visible = true;
            buttonTercera.Visible = true;
            buttonCuarta.Visible = true;
            buttonQuinta.Visible = true;
            buttonPrimera.Enabled = true;
            buttonSegunda.Enabled = false;
            buttonTercera.Enabled = false;
            buttonCuarta.Enabled = false;
            buttonQuinta.Enabled = false;
            labelVel.Text = "Retroceso";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (sonido != null)
            {
                sonido.controls.pause();
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonMusica_Click(object sender, EventArgs e)
        {  
            picturePlay.Visible = true;
            picturePlay.Enabled = true;
            pictureDetener.Visible = true;
            pictureDetener.Enabled = true;
            pictureBox4.Visible = true;
            pictureBox4.Enabled = true;
            buttonMusica.Visible = true;
            buttonMusica.Enabled = true;

            try
            {
                if (sonido == null)
                {
                    sonido = new WindowsMediaPlayer();
                    sonido.URL = Application.StartupPath + @"\mp3\Los Angeles Azules.mpeg";
                    sonido.controls.play();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }

        }

        private void picturePlay_Click(object sender, EventArgs e)
        {
            if (sonido != null)
            {
                double tiempo = sonido.controls.currentPosition;
                sonido.controls.currentPosition = tiempo;
                sonido.controls.play();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (sonido != null)
            {
                sonido.controls.stop();
                sonido = null;
            }
        }
    }
}
