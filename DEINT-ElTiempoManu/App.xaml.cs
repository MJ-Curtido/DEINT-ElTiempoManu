using DEINT_ElTiempoManu.MVVM.views;

namespace DEINT_ElTiempoManu;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new PaginaInicial();
	}
}
