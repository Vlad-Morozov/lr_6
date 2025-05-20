namespace Astronomy.Pages;
public partial class AstronomicalBodiesPage : ContentPage
{
	public AstronomicalBodiesPage()
	{
		InitializeComponent();
        string circumference = "111 km"; // або будь-яке інше значення, яке потрібно передати

        btnMoon.Clicked += async (s, e) => await Shell.Current.GoToAsync($"astronomicalbodydetails?astroName=moon&circumference={circumference}");
        btnEarth.Clicked += async (s, e) => await Shell.Current.GoToAsync("astronomicalbodydetails?astroName=earth");
        btnComet.Clicked += async (s, e) => await Shell.Current.GoToAsync("astronomicalbodydetails?astroName=comet");
        btnSun.Clicked += async (s, e) => await Shell.Current.GoToAsync("astronomicalbodydetails?astroName=sun");

    }
}