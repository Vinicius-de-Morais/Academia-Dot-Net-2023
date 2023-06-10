using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App28
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IMC : ContentPage
    {
        public IMC()
        {
            InitializeComponent();
            exec.Clicked += Exec_Clicked;
        }
         
        private void Exec_Clicked(object sender, EventArgs e)
        {
            try
            {
                float alturaFloat = float.Parse(altura.Text);
                float pesoFloat = float.Parse(peso.Text);

                float imc = pesoFloat / (float)Math.Pow(alturaFloat, 2);

                resultado.Text = name.Text + ", seu IMC foi de: " + imc;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao executar o IMC: " + e.ToString());
            }
            
        }
    }
}