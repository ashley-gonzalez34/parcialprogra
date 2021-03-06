using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App__para_adivinar_la_fecha_de_nacimiento
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Adivinar_Clicked(object sender, EventArgs e)
        {
            var Num = Numero.Text;

            string cadena1 = Num.ToString();
            string cadena2 = cadena1;

            int tamCadena = cadena2.Length;
            cadena2 = cadena2.Substring((tamCadena - 2), 2);
            cadena1 = cadena1.Remove(cadena1.Length - 2);

            int resta = int.Parse(cadena1) - 365;


            Resultado.Text = resta.ToString();
            DisplayAlert("Resultado", "La fecha es " + resta, "mes es " + cadena1, "Finalizar");

        }
    }
}
