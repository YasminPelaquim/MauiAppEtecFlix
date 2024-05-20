namespace MauiAppEtecFlix.Categorias;

public partial class Aventura : ContentPage
{
	public Aventura()
	{
		InitializeComponent();
	}

    private void btnJumanji_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Filmes.jumanji());

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void btnJurassic_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Filmes.jurassic());

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void btnZathura_Clicked(object sender, EventArgs e)
    {

    }

    private void btnHarry_Clicked(object sender, EventArgs e)
    {

    }
}