using MobileBankingApp.Views;

namespace MobileBankingApp;
public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute("signin", typeof(SignPage));
    }
}
