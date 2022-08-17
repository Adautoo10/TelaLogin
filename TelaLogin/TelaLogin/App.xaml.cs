using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;

using TelaLogin.View;
using TelaLogin.Model;

namespace TelaLogin
{
    public partial class App : Application
    {
        public List<DadosDoUsuario> list_usuarios = new List<DadosDoUsuario>
        {
            new DadosDoUsuario()
            {
                Email = "aluno@etec",
                Nome = "Aluno",
                Senha = "123"
            },
            new DadosDoUsuario()
            {
                Email = "prof@etc",
                Nome = "Professor",
                Senha = "456"
            }
        };

        public App()
        {
            InitializeComponent();

            if (Properties.ContainsKey("usuario_logado"))
                MainPage = new Proteção();
            else
                MainPage = new Login();
        }

        protected override void OnStart()
        {

        }

        protected override void OnSleep()
        {

        }

        protected override void OnResume()
        {

        }

    }
}