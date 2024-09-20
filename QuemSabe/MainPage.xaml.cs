namespace QuemSabe;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	void ProximaPagina(object sender, EventArgs args)
	{
		Application.Current.MainPage = new GamePage();
		
	}

}

