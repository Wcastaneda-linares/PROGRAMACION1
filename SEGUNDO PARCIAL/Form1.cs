using SEGUNDO_PARCIAL.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEGUNDO_PARCIAL
{
    public partial class Form1 : Form
    {
        private string[] ArregloNotas;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {

            ClsArchivo ar = new ClsArchivo();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Porfa Selecciona tu Archivo Plano";
            ofd.InitialDirectory = @"C:\Users\PC\Desktop\TAREAS";
            ofd.Filter = "Archivo Plano (*.csv)|*.csv";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;
                string resultado = ar.LeerTodoArchivo(archivo);
                ArregloNotas = ar.LeerArchivo(archivo);
                textBoxResultado.Text = resultado;
            }
            buttonPromedio.Enabled = true;
            buttonPromediosPorSeccion.Enabled = true;
            buttonPromediosGeneralSeccion.Enabled = true;
            ClasificarAlumnos.Enabled = true;
            buttonNombreNotaMayor.Enabled = true;
            buttonNombreNotaMayorSeccion.Enabled = true;
            buttonLimpiar.Enabled = true;

        }


        private void buttonPromedio_Click(object sender, EventArgs e)
        {
            ClsPromedios Promedios = new ClsPromedios();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;
            foreach (string linea in ArregloNotas)
            {
                string[] datosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Correlativo] = datosUnitarios[0];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Nombre] = datosUnitarios[1];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial1] = datosUnitarios[2];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial2] = datosUnitarios[3];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial3] = datosUnitarios[4];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Seccion] = datosUnitarios[5];
                NumeroLinea++;

            }
            int promedioParcial2 = Promedios.promedios_por_parcial(ArregloDosDimensiones, 3);
            listBoxResultado.Items.Add($"El Promedio General del Parcial 2 es: {promedioParcial2}");

            buttonPromedio.Enabled = false;
            buttonPromediosPorSeccion.Enabled = false;
            buttonPromediosGeneralSeccion.Enabled = false;
            ClasificarAlumnos.Enabled = false;
            buttonNombreNotaMayor.Enabled = false;
            buttonNombreNotaMayorSeccion.Enabled = false;
            buttonLimpiar.Enabled = true;

        }

        private void buttonPromediosPorSeccion_Click(object sender, EventArgs e)
        {
            ClsPromedios secciones = new ClsPromedios();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;
            int total = 0;
            foreach (string linea in ArregloNotas)
            {
                string[] datosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Correlativo] = datosUnitarios[0];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Nombre] = datosUnitarios[1];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial1] = datosUnitarios[2];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial2] = datosUnitarios[3];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial3] = datosUnitarios[4];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Seccion] = datosUnitarios[5];
                var seccion = ArregloDosDimensiones[NumeroLinea, enumColumnas.Seccion];
                if (seccion == "A")
                {
                    NumeroLinea++;
                    int paricial2 = secciones.promedios_por_seccion(ArregloDosDimensiones, 3, seccion);
                    total = paricial2 / NumeroLinea;
                }

            }
            listBoxResultado.Items.Add($"Nombre de la seccion A");
            listBoxResultado.Items.Add($"Segundo Parcial");
            listBoxResultado.Items.Add($"Total de Alumnos {NumeroLinea}");
            listBoxResultado.Items.Add($"El Promedio es: {total}");

            buttonPromedio.Enabled = false;
            buttonPromediosPorSeccion.Enabled = false;
            buttonPromediosGeneralSeccion.Enabled = false;
            ClasificarAlumnos.Enabled = false;
            buttonNombreNotaMayor.Enabled = false;
            buttonNombreNotaMayorSeccion.Enabled = false;
            buttonLimpiar.Enabled = true;
        }

        private void buttonPromediosGeneralSeccion_Click(object sender, EventArgs e)
        {
            ClsPromedios PromediosGeneralesSeccion = new ClsPromedios();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumA = 0;
            int NumB = 0;
            int NumC = 0;
            int NumD = 0;
            int totalA = 0;
            int totalB = 0;
            int totalC = 0;
            int totalD = 0;
            foreach (string linea in ArregloNotas)
            {
                string[] datosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumA, enumColumnas.Correlativo] = datosUnitarios[0];
                ArregloDosDimensiones[NumA, enumColumnas.Nombre] = datosUnitarios[1];
                ArregloDosDimensiones[NumA, enumColumnas.Parcial1] = datosUnitarios[2];
                ArregloDosDimensiones[NumA, enumColumnas.Parcial2] = datosUnitarios[3];
                ArregloDosDimensiones[NumA, enumColumnas.Parcial3] = datosUnitarios[4];
                ArregloDosDimensiones[NumA, enumColumnas.Seccion] = datosUnitarios[5];
                var seccionA = ArregloDosDimensiones[NumA, enumColumnas.Seccion];
                if (seccionA == "A")
                {
                    NumA++;
                    int PromedioSeccionA = PromediosGeneralesSeccion.promedios_general_seccion(ArregloDosDimensiones, 2, seccionA);
                    totalA = PromedioSeccionA / NumA;
                }
            }
            foreach (string linea in ArregloNotas)
            {
                string[] datosUnitarios = linea.Split(';');

                ArregloDosDimensiones[NumB, enumColumnas.Correlativo] = datosUnitarios[0];
                ArregloDosDimensiones[NumB, enumColumnas.Nombre] = datosUnitarios[1];
                ArregloDosDimensiones[NumB, enumColumnas.Parcial1] = datosUnitarios[2];
                ArregloDosDimensiones[NumB, enumColumnas.Parcial2] = datosUnitarios[3];
                ArregloDosDimensiones[NumB, enumColumnas.Parcial3] = datosUnitarios[4];
                ArregloDosDimensiones[NumB, enumColumnas.Seccion] = datosUnitarios[5];
                var seccionB = ArregloDosDimensiones[NumB, enumColumnas.Seccion];
                if (seccionB == "B")
                {
                    NumB++;
                    int PromedioSeccionB = PromediosGeneralesSeccion.promedios_general_seccion(ArregloDosDimensiones, 2, seccionB);
                    totalB = PromedioSeccionB / NumB;
                }
            }
            foreach (string linea in ArregloNotas)
            {
                string[] datosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumC, enumColumnas.Correlativo] = datosUnitarios[0];
                ArregloDosDimensiones[NumC, enumColumnas.Nombre] = datosUnitarios[1];
                ArregloDosDimensiones[NumC, enumColumnas.Parcial1] = datosUnitarios[2];
                ArregloDosDimensiones[NumC, enumColumnas.Parcial2] = datosUnitarios[3];
                ArregloDosDimensiones[NumC, enumColumnas.Parcial3] = datosUnitarios[4];
                ArregloDosDimensiones[NumC, enumColumnas.Seccion] = datosUnitarios[5];
                var seccionC = ArregloDosDimensiones[NumC, enumColumnas.Seccion];
                if (seccionC == "C")
                {
                    NumC++;
                    int PromedioSeccionC = PromediosGeneralesSeccion.promedios_general_seccion(ArregloDosDimensiones, 2, seccionC);
                    totalC = PromedioSeccionC / NumC;
                }
            }
            foreach (string linea in ArregloNotas)
            {
                string[] datosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumD, enumColumnas.Correlativo] = datosUnitarios[0];
                ArregloDosDimensiones[NumD, enumColumnas.Nombre] = datosUnitarios[1];
                ArregloDosDimensiones[NumD, enumColumnas.Parcial1] = datosUnitarios[2];
                ArregloDosDimensiones[NumD, enumColumnas.Parcial2] = datosUnitarios[3];
                ArregloDosDimensiones[NumD, enumColumnas.Parcial3] = datosUnitarios[4];
                ArregloDosDimensiones[NumD, enumColumnas.Seccion] = datosUnitarios[5];
                var seccionD = ArregloDosDimensiones[NumD, enumColumnas.Seccion];
                if (seccionD == "D")
                {
                    NumD++;
                    int PromedioSeccionD = PromediosGeneralesSeccion.promedios_general_seccion(ArregloDosDimensiones, 2, seccionD);
                    totalD = PromedioSeccionD / NumD;
                }

            }
            listBoxResultado.Items.Add($"seccion A");
            listBoxResultado.Items.Add($"Total de Alumnos {NumA}");
            listBoxResultado.Items.Add($"El Promedio es {totalA}");
            listBoxResultado.Items.Add($" ");
            listBoxResultado.Items.Add($"Seccion B");
            listBoxResultado.Items.Add($"Total de Alumnos {NumB}");
            listBoxResultado.Items.Add($"El Promedio es {totalB}");
            listBoxResultado.Items.Add($" ");
            listBoxResultado.Items.Add($"Seccion C");
            listBoxResultado.Items.Add($"Total de Alumnos {NumC}");
            listBoxResultado.Items.Add($"El Promedio es {totalC}");
            listBoxResultado.Items.Add($" ");
            listBoxResultado.Items.Add($"Seccion D");
            listBoxResultado.Items.Add($"Total de Alumnos {NumD}");
            listBoxResultado.Items.Add($"El Promedio es {totalD}");


            buttonPromedio.Enabled = false;
            buttonPromediosPorSeccion.Enabled = false;
            buttonPromediosGeneralSeccion.Enabled = false;
            ClasificarAlumnos.Enabled = false;
            buttonNombreNotaMayor.Enabled = false;
            buttonNombreNotaMayorSeccion.Enabled = false;
            buttonLimpiar.Enabled = true;

        }

        private void ClasificarAlumnos_Click(object sender, EventArgs e)
        {
            ClsPromedios promedio = new ClsPromedios();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;

            foreach (string linea in ArregloNotas)
            {
                string[] DatosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Correlativo] = DatosUnitarios[0];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Nombre] = DatosUnitarios[1];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial1] = DatosUnitarios[2];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial2] = DatosUnitarios[3];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial3] = DatosUnitarios[4];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Seccion] = DatosUnitarios[5];
                var seccion = Convert.ToString(ArregloDosDimensiones[NumeroLinea, enumColumnas.Seccion]);
                NumeroLinea++;
                string[,] alumnos = promedio.clasificar_alumnos(ArregloDosDimensiones, seccion);
                string NombredelAlumno = alumnos[0, 0];
                string Nota = alumnos[0, 1];

                listBoxResultado.Items.Add($"{NumeroLinea}).   {NombredelAlumno}    Nota...{Nota}");
                listBoxResultado.Items.Add($"");
            }
            buttonPromedio.Enabled = false;
            buttonPromediosPorSeccion.Enabled = false;
            buttonPromediosGeneralSeccion.Enabled = false;
            ClasificarAlumnos.Enabled = false;
            buttonNombreNotaMayor.Enabled = false;
            buttonNombreNotaMayorSeccion.Enabled = false;
            buttonLimpiar.Enabled = true;
        }

        private void buttonNombreNotaMayor_Click(object sender, EventArgs e)
        {
            ClsPromedios promedio = new ClsPromedios();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;
            foreach (string linea in ArregloNotas)
            {
                string[] DatosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Correlativo] = DatosUnitarios[0];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Nombre] = DatosUnitarios[1];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial1] = DatosUnitarios[2];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial2] = DatosUnitarios[3];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial3] = DatosUnitarios[4];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Seccion] = DatosUnitarios[5];
                NumeroLinea++;
            }

            string NombreNotaMayor = promedio.nombre_nota_mayor(ArregloDosDimensiones);
            listBoxResultado.Items.Add($"Nombre: {NombreNotaMayor}");

            buttonPromedio.Enabled = false;
            buttonPromediosPorSeccion.Enabled = false;
            buttonPromediosGeneralSeccion.Enabled = false;
            ClasificarAlumnos.Enabled = false;
            buttonNombreNotaMayor.Enabled = false;
            buttonNombreNotaMayorSeccion.Enabled = false;
            buttonLimpiar.Enabled = true;
        }
        private void buttonNombreNotaMayorSeccion_Click(object sender, EventArgs e)
        {
            ClsPromedios promedio = new ClsPromedios();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumA = 0;
            string seccionA = "A";
            foreach (string linea in ArregloNotas)
            {

                string[] DatosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumA, enumColumnas.Correlativo] = DatosUnitarios[0];
                ArregloDosDimensiones[NumA, enumColumnas.Nombre] = DatosUnitarios[1];
                ArregloDosDimensiones[NumA, enumColumnas.Parcial1] = DatosUnitarios[2];
                ArregloDosDimensiones[NumA, enumColumnas.Parcial2] = DatosUnitarios[3];
                ArregloDosDimensiones[NumA, enumColumnas.Parcial3] = DatosUnitarios[4];
                ArregloDosDimensiones[NumA, enumColumnas.Seccion] = DatosUnitarios[5];

                NumA++;
            }
            string NombreA = promedio.nombre_nota_mayor(ArregloDosDimensiones, seccionA);
            listBoxResultado.Items.Add($"Seccion *{seccionA}*");
            listBoxResultado.Items.Add($"Nombre: {NombreA}");
            listBoxResultado.Items.Add($"");


            int NumB = 0;
            string seccionB = "B";
            foreach (string linea in ArregloNotas)
            {

                string[] DatosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumB, enumColumnas.Correlativo] = DatosUnitarios[0];
                ArregloDosDimensiones[NumB, enumColumnas.Nombre] = DatosUnitarios[1];
                ArregloDosDimensiones[NumB, enumColumnas.Parcial1] = DatosUnitarios[2];
                ArregloDosDimensiones[NumB, enumColumnas.Parcial2] = DatosUnitarios[3];
                ArregloDosDimensiones[NumB, enumColumnas.Parcial3] = DatosUnitarios[4];
                ArregloDosDimensiones[NumB, enumColumnas.Seccion] = DatosUnitarios[5];
                NumB++;
            }
            string NombreB = promedio.nombre_nota_mayor(ArregloDosDimensiones, seccionB);
            listBoxResultado.Items.Add($"Seccion *{seccionB}*");
            listBoxResultado.Items.Add($"Nombre: {NombreB}");
            listBoxResultado.Items.Add($"");

            int NumC = 0;
            string seccionC = "C";
            foreach (string linea in ArregloNotas)
            {

                string[] DatosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumC, enumColumnas.Correlativo] = DatosUnitarios[0];
                ArregloDosDimensiones[NumC, enumColumnas.Nombre] = DatosUnitarios[1];
                ArregloDosDimensiones[NumC, enumColumnas.Parcial1] = DatosUnitarios[2];
                ArregloDosDimensiones[NumC, enumColumnas.Parcial2] = DatosUnitarios[3];
                ArregloDosDimensiones[NumC, enumColumnas.Parcial3] = DatosUnitarios[4];
                ArregloDosDimensiones[NumC, enumColumnas.Seccion] = DatosUnitarios[5];
                NumC++;
            }
            string NombreC = promedio.nombre_nota_mayor(ArregloDosDimensiones, seccionC);
            listBoxResultado.Items.Add($"Seccion *{seccionC}*");
            listBoxResultado.Items.Add($"Nombre: {NombreC}");
            listBoxResultado.Items.Add($"");

            int NumD = 0;
            string seccionD = "D";
            foreach (string linea in ArregloNotas)
            {

                string[] DatosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumD, enumColumnas.Correlativo] = DatosUnitarios[0];
                ArregloDosDimensiones[NumD, enumColumnas.Nombre] = DatosUnitarios[1];
                ArregloDosDimensiones[NumD, enumColumnas.Parcial1] = DatosUnitarios[2];
                ArregloDosDimensiones[NumD, enumColumnas.Parcial2] = DatosUnitarios[3];
                ArregloDosDimensiones[NumD, enumColumnas.Parcial3] = DatosUnitarios[4];
                ArregloDosDimensiones[NumD, enumColumnas.Seccion] = DatosUnitarios[5];
                NumC++;
            }
            string NombreD = promedio.nombre_nota_mayor(ArregloDosDimensiones, seccionD);
            listBoxResultado.Items.Add($"Seccion *{seccionD}*");
            listBoxResultado.Items.Add($"Nombre: {NombreD}");
            listBoxResultado.Items.Add($"");



            buttonPromedio.Enabled = false;
            buttonPromediosPorSeccion.Enabled = false;
            buttonPromediosGeneralSeccion.Enabled = false;
            ClasificarAlumnos.Enabled = false;
            buttonNombreNotaMayor.Enabled = false;
            buttonNombreNotaMayorSeccion.Enabled = false;
            buttonLimpiar.Enabled = true;
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            listBoxResultado.Items.Clear();
            buttonPromedio.Enabled = true;
            buttonPromediosPorSeccion.Enabled = true;
            buttonPromediosGeneralSeccion.Enabled = true;
            ClasificarAlumnos.Enabled = true;
            buttonNombreNotaMayor.Enabled = true;
            buttonNombreNotaMayorSeccion.Enabled = true;
        }


    }
}
