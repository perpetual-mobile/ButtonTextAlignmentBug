using System;
using Xamarin.Forms;

namespace BugButtonAllignment
{
    public static class App
    {
        public static Page GetMainPage()
        {   
            var label = new Label {
                Text = "label",
            };
            var button = new MyButton {
                Text = "button",
                Command = new Command(o => {
                    label.Text += ".";
                }),
                HeightRequest = 20,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };
//            var button2 = new MyButton {
//                Text = "button2",
//                Command = new Command(o => {
//                    label.Text += ".";
//                }),
//                HeightRequest = 20,
////                VerticalOptions = LayoutOptions.FillAndExpand,
//            };

            return new ContentPage { Content = new StackLayout { Children = { label, button } } };
        }
    }

    public class MyButton: Button
    {
    }
}

