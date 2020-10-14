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
    public partial class April : ContentPage
    {
        Label lbl, lbl1, lbl2, lbl3, lbl4, lbl5;
        Image img;
        public April()
        {
            Title = "April";
            lbl = new Label()
            {
                Text = "Suur reede",
                FontAttributes = FontAttributes.Bold,
                FontSize = 24,
                TextColor = Color.Black,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl1 = new Label()
            {
                Text = "10. aprill",
                FontAttributes = FontAttributes.Italic,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl2 = new Label()
            {
                Text = "Suur reede on kristlik püha, mil tähistatakse Jeesus Kristuse ristilöömist ja surma Kolgata mäel. See kuulub kokku rea teiste pühadega, mis seostuvad " +
                "Jeesuse eluga. Suur reede eelneb lihavõttepühadele ning võib langeda kokku juudiusu paasapühadega.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
                TextType = TextType.Html,
            };
            lbl3 = new Label()
            {
                Text = "Kanooniliste evangeeliumite järgi löödi Jeesus tõenäoliselt risti reedel (päev enne sabatit; Johannese evangeelium 19:42). Tõenäoliselt toimus see kas" +
                "aastal 33 või 34 (nagu pakkus välja Isaac Newton, võrreldes kuuseise ning piibliaegse ja juuliuse kalendri erinevust). Kuuvarjutuse järgi otsustades (ja" +
                "kooskõlas Peetruse sõnadega Apostlite tegude raamatus, 2:20) toimus see reedel, 3. aprillil 33. aastal.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl4 = new Label()
            {
                Text = "Enamikus kristlikes usulahkudes on tavaks pidada suurel reedel erilisi jumalateenistusi. Nendeks puhkudeks on kirjutatud ka arvukalt muusikat," +
                "näiteks Johann Sebastian Bachi Matteuse passioon.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl5 = new Label()
            {
                Text = "Katoliku kirikus on suur reede paastupäev. Luteri kirikus oli suur reede 16.-20. sajandil aasta suurim püha, mil töötegemine oli keelatud ja kõige suurem hulk" +
                "inimesi tuli armulauale. Viimasel ajal on suuremad luterlikud kirikud siiski hakanud loobuma kombest korraldada suurel reedel armulauda.",
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
                Children = { lbl, lbl1, lbl2, lbl3, lbl4, lbl5, img },
            };
            ScrollView scroll = new ScrollView { Content = stackLayout };
            Content = scroll;
        }
    }
}