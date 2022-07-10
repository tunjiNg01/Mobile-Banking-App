namespace MobileBankingApp.Views;

public partial class DashboardPage : ContentPage
{
    bool x = true;
	public DashboardPage()
	{
		InitializeComponent();
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        if (x)
            await Shell.Current.GoToAsync("signin");
    }
}