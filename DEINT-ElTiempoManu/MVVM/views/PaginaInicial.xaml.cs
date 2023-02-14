using AndroidX.Lifecycle;

namespace DEINT_ElTiempoManu.MVVM.views;

public partial class PaginaInicial : ContentPage
{
	public PaginaInicial()
	{
		InitializeComponent();

		BindingContext = new ViewModel();
	}
}