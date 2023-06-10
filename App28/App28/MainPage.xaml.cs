using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App28
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            buttonChange.Clicked += ButtonChange_Clicked;
            buttonIMC.Clicked += ButtonIMC_Clicked;
        }

        private void ButtonIMC_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new IMC());
        }

        private void ButtonChange_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }
    }
}
