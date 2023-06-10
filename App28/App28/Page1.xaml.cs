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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

            exec.Clicked += Exec_Clicked;
        }

        private void Exec_Clicked(object sender, EventArgs e)
        {
            string[] vetNome = name.Text.Split(' ');
            string nameFormat = "";
            if (vetNome.Length > 1)
            {
                nameFormat = vetNome[vetNome.Length - 1] + "." + vetNome[0];
            }
            else
            {
                nameFormat = vetNome[0] + ".";
            }

            emailLabel.Text = "Seu email será: " + nameFormat + "@ufn.edu.br";
        }
    }
}