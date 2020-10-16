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
    public partial class Detsember : ContentPage
    {

        Label lbl, lbl1, lbl2;
        Image img;
        public Detsember()
        {
            Title = "Detsember";
            lbl = new Label()
            {
                Text = "Jõulud eesti rahvakalendris",
                FontAttributes = FontAttributes.Bold,
                FontSize = 24,
                TextColor = Color.Black,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl1 = new Label()
            {
                Text = "24. detsembrit",
                FontAttributes = FontAttributes.Italic,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl2 = new Label()
            {
                Text = "Jõulud (Lõuna-Eestis ka: talvistepüha) olid Eesti rahvakalendris aasta tähtsaimad pühad. " +
                "Jõulude aeg on Eestis väldanud toomapäevast (21. detsember) kolmekuningapäevani (6. jaanuar), saartel ja rannikul nuudipäevani (13. jaanuar)."+
                "Jõulude perioodil on eristatud jõulupühi, mis kestsid 25.–27. detsembrini."+
                "Neile eelnenud päeva, 24. detsembrit ehk jõuluõhtut peeti kogu jõuluaja tähtsaimaks tähiseks.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
                TextType = TextType.Html,
            };
            img = new Image
            {
                Source = ImageSource.FromFile("emakeel.jpg"),
                Margin = new Thickness(15, 20, 15, 5),
            };
            StackLayout stackLayout = new StackLayout()
            {
                Children = { lbl, lbl1, lbl2, img },
            };
            ScrollView scroll = new ScrollView { Content = stackLayout };
            Content = scroll;

        }
    }
}
