using MauiAppFilmes.Categorias;

namespace MauiAppFilmes
{
    public partial class MainPage : ContentPage
    {
     

        public MainPage()
        {
            InitializeComponent();
        }

        async private void btn00_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Categorias.Ficcaocientifica.NewPage1());
        }
        async private void btn10_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Categorias.Drama());
        }
        async private void btn20_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Categorias.Aventura());
        }
        async private void btn30_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Categorias.Infantil());
        }
        async private void btn01_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Categorias.nacional());
        }
        async private void btn11_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Categorias.terror());
        }
    }

}
