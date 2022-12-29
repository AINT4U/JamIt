using Microsoft.Maui.Controls.PlatformConfiguration;

namespace JamIT;

public partial class App : Application
{
    const int WindowWidth = 400;
    const int WindowHeight = 300;
    public App()
	{
		InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState activationState) =>
        new Window(new AppShell())
        {
            Width = 1100,
            Height = 666,
            X = 100,
            Y = 100
        };


}
