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
    public partial class Oktoober : ContentPage
    {

        Label lbl, lbl1, lbl2, lbl3, lbl4;
        Image img;
        public Oktoober()
        {
            Title = "Oktoober";
            lbl = new Label()
            {
                Text = "Simunapäev",
                FontAttributes = FontAttributes.Bold,
                FontSize = 24,
                TextColor = Color.Black,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl1 = new Label()
            {
                Text = "21. oktoobril",
                FontAttributes = FontAttributes.Italic,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl2 = new Label()
            {
                Text = "Simunapäev on 28. oktoobril tähistatav apostlite Siimona ja Juuda Taddeuse mälestuspäev, neist esimese järgi on päev ka nimetuse saanud.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
                TextType = TextType.Html,
            };
            lbl3 = new Label()
            {
                Text = "Lõuna-Tartumaal, Viljandimaal ja Võrumaal märkis see päev jäätumise algust ja talveteede ootust. ",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl4 = new Label()
            {
                Text = "Eestis on neile apostlitele pühendatud Simuna kirik. ",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };
            img = new Image
            {
                Source = ImageSource.FromFile("Simunapäev.jpg"),
                Margin = new Thickness(15, 20, 15, 5),
            };
            StackLayout stackLayout = new StackLayout()
            {
                Children = { lbl, lbl1, lbl2, lbl3, lbl4, img },
            };
            ScrollView scroll = new ScrollView { Content = stackLayout };
            Content = scroll;

        }
    }
}