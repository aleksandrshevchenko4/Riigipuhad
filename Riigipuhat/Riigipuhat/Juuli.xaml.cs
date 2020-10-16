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
    public partial class Juuli : ContentPage
    {

        Label lbl, lbl1, lbl2, lbl3;
        public Juuli()
        {
            Title = "Juuli";
            lbl = new Label()
            {
                Text = "Madlipäev",
                FontAttributes = FontAttributes.Bold,
                FontSize = 24,
                TextColor = Color.Black,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl1 = new Label()
            {
                Text = "22.juuli",
                FontAttributes = FontAttributes.Italic,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl2 = new Label()
            {
                Text = "Eestis on selle päeva kohta andmeid üksnes vähestes vanemates kirjalikes allikates, kus seda nimetatakse uudseleiva päevaks.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
                TextType = TextType.Html,
            };
            lbl3 = new Label()
            {
                Text = "See on Maarja Magdaleena mälestuspäev.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };
            ;
            StackLayout stackLayout = new StackLayout()
            {
                Children = { lbl, lbl1, lbl2, lbl3},
            };
            ScrollView scroll = new ScrollView { Content = stackLayout };
            Content = scroll;

        }
    }
}
