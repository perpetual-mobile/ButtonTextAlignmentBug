using System;
using Xamarin.Forms;

namespace BugButtonAllignment
{
    public class App
    {
        public static Page GetMainPage()
        {   
            Label l1 = new Label {
                Text = "LabelText",
            };

            return new ContentPage { 
                Content = new StackLayout {
                    Children = {
                        l1,
                        new Button {
                            Text = "changeText",
                            Command = new Command(() => l1.Text += "1"),
                        },
                    }
                }
            };
        }
    }
}

