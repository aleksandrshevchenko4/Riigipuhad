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
    public partial class November : ContentPage
    {

        Label lbl, lbl1, lbl2, lbl3;

        public November()
        {
            Title = "November";
            lbl = new Label()
            {
                Text = "Hingedepäev",
                FontAttributes = FontAttributes.Bold,
                FontSize = 24,
                TextColor = Color.Black,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl1 = new Label()
            {
                Text = "2. novembril",
                FontAttributes = FontAttributes.Italic,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl2 = new Label()
            {
                Text = "Katoliiklikus kirikukalendris kehtestati 1006. aastal 2. november hingedepäeva ehk usklike surnute mälestuspäevana.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
                TextType = TextType.Html,
            };
            lbl3 = new Label()
            {
                Text = "Eestlastel jääb hingedepäev hingedeaja sisse. Hingedepäeva on nimetatud juba 14. sajandi allikates, kuid selle " +
                "tähistamine on jäänud omauskumustele tugineva hingedeaja varju."+
                "1990. aastatel levis tava süüdata hingedepäeval koduakendel ja kalmistul sugulaste haudadel lahkunute mälestuseks küünlad.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };

            StackLayout stackLayout = new StackLayout()
            {
                Children = { lbl, lbl1, lbl2, lbl3},
            };
            ScrollView scroll = new ScrollView { Content = stackLayout };
            Content = scroll;

        }

        public November(Label lbl, Label lbl1, Label lbl2, Label lbl3)
        {
            this.lbl = lbl;
            this.lbl1 = lbl1;
            this.lbl2 = lbl2;
            this.lbl3 = lbl3;
        }
    }
}
