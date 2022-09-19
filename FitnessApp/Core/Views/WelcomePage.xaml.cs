namespace FitnessApp.Core.Views;

public partial class WelcomePage : ContentPage
{
	public WelcomePage()
	{
		InitializeComponent();
	}

	private void TapGestureRecognizer_Tapped(object sender, EventArgs e) => App.Current.MainPage = new HomePage();
}
