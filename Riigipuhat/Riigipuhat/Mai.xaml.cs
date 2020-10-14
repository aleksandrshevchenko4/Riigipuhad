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
    public partial class Mai : ContentPage
    {
        Label lbl, lbl1, lbl2, lbl3, lbl4, lbl5, lbl6;
        Image img;
        public Mai()
        {
            Title = "Mai";
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
                Text = "31. mai",
                FontAttributes = FontAttributes.Italic,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl2 = new Label()
            {
                Text = "Nelipühad on kristlik püha, millega mälestatakse Püha Vaimu laskumist apostlitele 50 päeva pärast Jeesuse Kristuse ülestõusmist ja 10 päeva" +
                "pärast taevaminemispüha. See on kiriku sünnipäev.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
                TextType = TextType.Html,
            };
            lbl3 = new Label()
            {
                Text = "Nelipühad on seotud juudi pühaga šavuot, mis tähistab Jumalalt Moosesele Siinai mäel kümne käsu andmist. Šavuoti peetakse seitse nädalat" +
                "pärast paasapühi ja ta on pärit kaugest paganlikust minevikust, mil tähistati lõikustänupüha.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl4 = new Label()
            {
                Text = "Eesti rahvakalendris kannavad nelipühad ka suvistepühade nime.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl5 = new Label()
            {
                Text = "Mälestatavast sündmusest jutustatakse Piiblis Apostlite tegude raamatu 2. peatükis.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl6 = new Label()
            {
                Text = "Nelipühade liturgiline värv on katoliku, luteri ja anglikaani kirikus tavapäraselt punane, õigeusu kirikutes reeglina roheline.",
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