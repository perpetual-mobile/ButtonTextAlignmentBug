using System;
using Xamarin.Forms;

namespace BugButtonAllignment
{
    public class App
    {
        static ScrollView _scrollView;
        static StackLayout _buttonsStack;
        static Grid _buttonsGrid;

        public static Page GetMainPage()
        {   
            _buttonsStack = new StackLayout();
            _scrollView = new ScrollView {
                Orientation = ScrollOrientation.Horizontal,
                Content = _buttonsStack,
                HeightRequest = 100
            };

            _buttonsStack.Children.Add(new Button {
                Text = "Add Control",
                WidthRequest = 400
            });
            _buttonsStack.Children.Add(new Button {
                Text = "Insert Control",
            });
            _buttonsStack.Children.Add(new Button {
                Text = "Remove Control",
            });

            return new ContentPage { 
                Content = _scrollView,
            };
        }

        private static StackLayout ScrollStackLayout {
            get { return (StackLayout)_scrollView.Content; }
        }

        private static void OnAddControl()
        {
            ScrollStackLayout.Children.Add(new Button { Text = "hello" });
            ForceRelayout();
        }

        private static void OnInsertControl()
        {
            ScrollStackLayout.Children.Insert(0, new Button { Text = "hello" });
            ForceRelayout();
        }

        private static void OnRemoveControl()
        {
            if (ScrollStackLayout.Children.Count > 0) {
                ScrollStackLayout.Children.RemoveAt(0);
                ForceRelayout();
            }
        }

        private static void ForceRelayout()
        {
            ScrollStackLayout.ForceLayout();
            _scrollView.ForceLayout();
        }

    }
}

