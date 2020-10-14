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
    public partial class Juuni : ContentPage
    {
        Label lbl, lbl1, lbl2, lbl3, lbl4, lbl5, lbl6;
        Image img;
        public Juuni()
        {
            Title = "Juuni";
            lbl = new Label()
            {
                Text = "Nelipühade 1. püha",
                FontAttributes = FontAttributes.Bold,
                FontSize = 24,
                TextColor = Color.Black,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl1 = new Label()
            {
                Text = "24. juuni",
                FontAttributes = FontAttributes.Italic,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl2 = new Label()
            {
                Text = "Jaanipäev on Eestis 24. juunil tähistatav püha. 24. juunile eelnevat 23. juuni päeva nimetatakse jaanilaupäevaks ja nendevahelist ööd jaaniööks, seda" +
                "tähistatakse Eestis, Lätis ja põhjamaades jaanituledega.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
                TextType = TextType.Html,
            };
            lbl3 = new Label()
            {
                Text = "Jaanipäeva nimetus pärineb kirikukalendrist, kirikus tähistatakse sel päeval Ristija Johannese sünnipäeva.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl4 = new Label()
            {
                Text = "Eesti Vabariigis on jaanilaupäev ja jaanipäev riigipühad; jaanilaupäeval peetakse Eestis võidupüha, mis tähistab Eesti vägede võitu Vabadussõjas Võnnu"+
                "lahingus 23. juunil 1919 Landeswehri üle.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl5 = new Label()
            {
                Text = "Pärimuslik jaanipidu Vana-Vigala ohvrihiie juures (juuni 2016)",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl6 = new Label()
            {
                Text = "Jaaniõhtut ja -ööd tähistatakse Eestis laialdaselt jaanituledega, millel on sümboolne seos pööripäeva ja päikese kõrgseisuga. Sel puhul on kombeks"+
                "korraldada nii rahvapidusid kui ka tähistada püha sõprade ja tuttavate keskel väiksemate lõkkeõhtute või grillimisega koduaias või looduses. Tänapäevalgi"+
                "on jaanipäev eestlaste jaoks üks aasta tähtsamaid pühi, mida ka välismaal viibides teistest sagedamini tähistatakse.",
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
                Children = { lbl, lbl1, lbl2, lbl3, lbl4, lbl5, lbl6, img },
            };
            ScrollView scroll = new ScrollView { Content = stackLayout };
            Content = scroll;
        }
    }
}