using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Riigipuhad
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class August : ContentPage
    {

        Label lbl, lbl1, lbl2, lbl3;
        Image img;
        public August()
        {
            Title = "August";
            lbl = new Label()
            {
                Text = "Paasapäev",
                FontAttributes = FontAttributes.Bold,
                FontSize = 24,
                TextColor = Color.Black,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl1 = new Label()
            {
                Text = "19. augustil",
                FontAttributes = FontAttributes.Italic,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl2 = new Label()
            {
                Text = "Paasapäiv ehk Issanda Muutmise püha on setude kirikupüha 19. augustil, mille ajal käiakse hommikul kirikus, kus pühitsetakse õunu, mida viiakse koos muude toitudega kalmistule." +
                "Mitmel pool on sel päeval peetud kirmast ja külastatud sugulasi.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
                TextType = TextType.Html,
            };
            lbl3 = new Label()
            {
                Text = "20. sajandi alguses hakati peale õunte sööma paasapäeval ka muid puuvilju ning herneid. See on olnud veel värske mee proovimise päev. Obinitsas, Tailovas, Seretsovas ja muudes külades on see olnud oluline püha." +
                "Ka tänapäeval on näiteks Obinitsas paasapäev suur püha, kuhu sõidavad sugulased ja sõbrad üle Eesti kohale. " +
                "Valmistatakse pühadetoidud ja käiakse 1952. aastal ehitatud Issanda Muutmise kirikus teenistusel, võetakse osa ristikäigust[1]. Kalmistul kaetakse lähedaste haudadel lauad."+
                " Väga oluline on toidu pakkumine, jutlemine, kalmistul jalutamine ja sugulastega kohtumine." +
                "Õhtusel kirmasel esinevad aga ka mujalt tulnud laulikud. Lisaks sellele on 1990. aastatest alates kohalikus muuseumis avatud käsitöö- ja kunstinäitused ning õpikojad.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };
            img = new Image
            {
                Source = ImageSource.FromFile("emakeel.jpg"),
                Margin = new Thickness(15, 20, 15, 5),
            };
            StackLayout stackLayout = new StackLayout()
            {
                Children = { lbl, lbl1, lbl2, lbl3, img },
            };
            ScrollView scroll = new ScrollView { Content = stackLayout };
            Content = scroll;

        }
    }
}
