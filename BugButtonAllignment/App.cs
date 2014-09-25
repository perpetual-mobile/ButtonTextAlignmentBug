using System;
using Xamarin.Forms;

namespace BugButtonAllignment
{
    public class App
    {
        public static Page GetMainPage()
        {    
            return new NavigationPage(new ContentPage { 
                Content = new ScrollView {
                    HeightRequest = 100,
                    Content = new StackLayout {
                        Children = {
                            new StackLayout {
                                Children = {
                                    new Button {
                                        Text = "b1",
                                    },
                                    new Button {
                                        Text = "b2",
                                    }
                                }
                            },
                            //no tap highlighting !
                            new Button {
                                Text = "Hello World",
                            },
                        },
                    },
                },
            });
        }
    }
}

