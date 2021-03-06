using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace app_de_adivinar_el_numero
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
            cadena2 = cadena2.Substring((tamCadena - 1), 1);
            cadena1 = cadena1.Remove(cadena1.Length - 1);

            int resta = int.Parse(cadena1) - 4;


            Resultado.Text = resta.ToString();
            DisplayAlert("Resultado", "El numero que estas pensando es" + resta, "Finalizar");



        }
    }
}
