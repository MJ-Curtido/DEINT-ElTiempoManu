using SkiaSharp.Views.Maui.Controls.Hosting;

namespace DEINT_ElTiempoManu;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseSkiaSharp()
			.ConfigureEssentials(essentials =>
			{
				essentials.UseMapServiceToken("DcLO3Opo5GFZdtexZqiL~JnVewwhmIY6Y3N7kXkoqUw~As7Az9aR73lYue370jNwTx6mRih5QpjNXu5wdq8_v_gLIE6zEvdVc4Rcfeac73hd");
			})
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		return builder.Build();
	}
}
