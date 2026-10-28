using Microsoft.Extensions.DependencyInjection;

namespace MauiAppLogin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            string? usuario_logado = null;

            Task.Run(async () =>
            {
                usuario_logado = await SecureStorage.Default.GetAsync("usuario_logado");

                if(usuario_logado == null)
                {
                    Application.Current.Windows[0].Page = new Login();
                } else
                {
                    Application.Current.Windows[0].Page = new Protegida();
                }
            });
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = new Window(new Login())
            {
                Width = 400,
                Height = 700
            };

            return window;
        }
    }
}