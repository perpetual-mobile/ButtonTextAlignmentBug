using System;
using Xamarin.Forms;

namespace BugButtonAllignment
{
    public class App
    {
        static ScrollView _scrollView;
        static StackLayout _buttonsStack;

        public static Page GetMainPage()
        {   
            _buttonsStack = new StackLayout();
            _scrollView = new ScrollView {
                Orientation = ScrollOrientation.Horizontal,
                Content = _buttonsStack,
            };
            Label l1 = new Label {
                Text = "LabelText",
            };

            _buttonsStack.Children.Add(l1);
            _buttonsStack.Children.Add(new Button {
                Text = "changeText",
                Command = new Command(() => l1.Text += "1"),
            });

            return new ContentPage { 
                Content = _scrollView,
            };
        }



       

    }
}

