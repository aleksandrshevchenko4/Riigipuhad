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
    public partial class September : ContentPage
    {

        Label lbl, lbl1, lbl2, lbl3, lbl4;
        Image img;
        public September()
        {
            Title = "September";
            lbl = new Label()
            {
                Text = "Ussimaarjapäev",
                FontAttributes = FontAttributes.Bold,
                FontSize = 24,
                TextColor = Color.Black,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl1 = new Label()
            {
                Text = "8. september",
                FontAttributes = FontAttributes.Italic,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl2 = new Label()
            {
                Text = "Ussimaarjapäev on eesti rahvakalendri tähtpäev.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
                TextType = TextType.Html,
            };
            lbl3 = new Label()
            {
                Text = "Väike maarjapäev ehk ussimaarjapäev ehk ussi magamise päev (setud tähistavad hoopis 14. septembrit ehk viissenjapäeva kui usside magama minemise päeva) on " +
                "selle 19. sajandil vähetuntud ja 20. sajandiks unustatud päeva paralleelnimetused. Eestis teatakse püha alates 16. sajandist." ,
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl4 = new Label()
            {
                Text = "Üldine on olnud metsaminekukeeld põhjendusega, et mets tahab puhata ja ussid rahulikult urgu minna. Lubatud oli minna marjule. " +
                "Mõnevõrra oli levinud õmblemis- ja ketramiskeeld, et uss ei nõelaks. Sel päeval kaotavad nõelussid maaga kokku puutudes oma mürgi ja"+
                "nende salvamine pole enam ohtlik. Enamik koristus- ja külvitöid (rukkikülv, viljakoristus) pidi olema"+
                "lõpetatud. Mõnel pool usuti, et kesa sümboolselt kündmine hävitab kahjurid ja rukkiussid. Ussimaarjapäeva peeti õunte valmimise päevaks.",
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
                Children = { lbl, lbl1, lbl2, lbl3, lbl4, img },
            };
            ScrollView scroll = new ScrollView { Content = stackLayout };
            Content = scroll;

        }
    }
}