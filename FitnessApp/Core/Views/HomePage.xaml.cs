namespace FitnessApp.Core.Views;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
    }
    private void TapGestureRecognizer_Tapped(object sender, EventArgs e) => App.Current.MainPage = new NavigationPage(new ProfilePage());
}
