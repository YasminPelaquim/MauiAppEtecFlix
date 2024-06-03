namespace MauiAppEtecFlix.Categorias;

public partial class Documentario : ContentPage
{
	public Documentario()
	{
		InitializeComponent();
	}

    private void btnElena_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Filmes.elena());

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void ImageButton_Clicked_2(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Filmes.senna());

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void ImageButton_Clicked_3(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Filmes.quemsou());

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void ImageButton_Clicked_4(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Filmes.stuztz());

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}