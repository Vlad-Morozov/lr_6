namespace Astronomy.Pages;
[QueryProperty(nameof(AstroName), "astroName")]
[QueryProperty(nameof(Circumference), "circumference")]

public partial class AstronomicalBodyPage : ContentPage
{

    public AstronomicalBodyPage()
    {
        InitializeComponent();
    }

    void UpdateAstroBodyUI(string astroName)
    {
        AstronomicalBody body = FindAstroData(astroName);

        Title = body.Name;

        lblIcon.Text = body.EmojiIcon;
        lblName.Text = body.Name;
        lblMass.Text = body.Mass;
        lblCircumference.Text = body.Circumference;
        lblAge.Text = body.Age;
    }

    AstronomicalBody FindAstroData(string astronomicalBodyName)
    {
        return astronomicalBodyName switch
        {
            "comet" => SolarSystemData.HalleysComet,
            "earth" => SolarSystemData.Earth,
            "moon" => SolarSystemData.Moon,
            "sun" => SolarSystemData.Sun,
            _ => throw new ArgumentException()
        };
    }



    string astroName;
    public string AstroName
    {
        get => astroName;
        set
        {
            astroName = value;
            // this is a custom function to update the UI immediately
            UpdateAstroBodyUI(astroName);

        }

    }


    string circumference;
    public string Circumference
    {
        get => circumference;
        set
        {
            circumference = value;
            lblCircumference.Text = $"{circumference}";

        }
    }
}