namespace MauiAppEtecFlix.Categorias;

public partial class Drama : ContentPage
{
	public Drama()
	{
		InitializeComponent();
	}

    private void btnHistorias_Clicked(object sender, EventArgs e)
    {

    }

    private void btnHistorias_Clicked_1(object sender, EventArgs e)
    {

    }

    private void btnHistorias_Clicked_2(object sender, EventArgs e)
    {

    }

    private void btnAdoraveis_Clicked(object sender, EventArgs e)
    {

    }

    private void btnBaleia_Clicked(object sender, EventArgs e)
    {

    }

    private void btnUmlugar_Clicked(object sender, EventArgs e)
    {

    }

    private void btnHistorias_Clicked_3(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Filmes.historias());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
      
    }

    private void btnAdoraveis_Clicked_1(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Filmes.adoraveis());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void btnBaleia_Clicked_1(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Filmes.baleia());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void btnUmlugar_Clicked_1(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Filmes.umlugar());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}