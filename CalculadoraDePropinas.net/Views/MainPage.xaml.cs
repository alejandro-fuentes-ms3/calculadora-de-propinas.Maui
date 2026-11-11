using CalculadoraDePropinas.net.ViewModels;

namespace CalculadoraDePropinas.net.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();
	}
}