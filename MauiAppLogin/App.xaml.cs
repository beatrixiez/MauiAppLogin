using Microsoft.Extensions.DependencyInjection;

namespace MauiAppLogin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = new Window(new AppShell())
            {
                Width = 400,
                Height = 700
            };

            return window;
        }
    }
}