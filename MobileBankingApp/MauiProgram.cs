namespace MobileBankingApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("fa-regular-400.ttf", "IconSet");
				fonts.AddFont("fa-brands-400.ttf", "IconSetBrand");
                fonts.AddFont("Rubik-Bold.ttf", "BoldFont");
				fonts.AddFont("Rubik-Medium.ttf", "MediumFont");
				fonts.AddFont("Rubik-Regular.ttf", "RegularFont");
				fonts.AddFont("Rubik-Semibold.ttf", "SemiboldFont");
            });

		return builder.Build();
	}
}
