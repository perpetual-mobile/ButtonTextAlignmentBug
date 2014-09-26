using System;
using Xamarin.Forms;

namespace BugButtonAllignment
{
    public class App
    {
        public static Page GetMainPage()
        {   
            var label = new Label {
                Text = "label",
            };
            var buttonBad = new Button {
                Text = "buttonBad",
                Command = new Command(() => label.Text += "1"),
            };
            var buttonGood = new Button {
                Text = "buttonGood",
            };

            return new ContentPage { 
                Content = new StackLayout {
                    Children = {
                        label,
                        buttonBad,
                        buttonGood,
                    }
                }
            };
        }
    }
}

